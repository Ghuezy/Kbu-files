#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <winsock2.h>
#include <ws2tcpip.h>
#include <pthread.h>

#pragma comment(lib, "Ws2_32.lib")

#define PORT 8080
#define BUFFER_SIZE 1024

typedef struct {
    char city[50];
    char weather[100];
} WeatherInfo;

WeatherInfo weather_data[] = {
    {"Istanbul", "Cloudy, 15°C"},
    {"Ankara", "Sunny, 10°C"},
    {"Izmir", "Windy, 18°C"},
    {"Antalya", "Hot, 28°C"},
    {"Bursa", "Rainy, 12°C"},
    {"Adana", "Sunny, 25°C"},
    {"Konya", "Clear, 20°C"},
    {"Gaziantep", "Partly cloudy, 23°C"},
    {"Mersin", "Warm, 26°C"},
    {"Kayseri", "Cold, 8°C"}
};
int weather_data_count = sizeof(weather_data) / sizeof(weather_data[0]);


void *handle_client(void *client_socket);
void get_weather_info(const char *city, char *response);

int main() {
    WSADATA wsaData;
    if (WSAStartup(MAKEWORD(2, 2), &wsaData) != 0) {
        fprintf(stderr, "WSAStartup failed\n");
        return 1;
    }

    int server_fd = socket(AF_INET, SOCK_STREAM, 0);
    if (server_fd == INVALID_SOCKET) {
        perror("Socket creation failed");
        WSACleanup();
        return 1;
    }

    int opt = 1;
    setsockopt(server_fd, SOL_SOCKET, SO_REUSEADDR, (const char *)&opt, sizeof(opt));

    struct sockaddr_in address = {0};
    address.sin_family = AF_INET;
    address.sin_addr.s_addr = INADDR_ANY;
    address.sin_port = htons(PORT);

    if (bind(server_fd, (struct sockaddr *)&address, sizeof(address)) < 0) {
        perror("Bind failed");
        closesocket(server_fd);
        WSACleanup();
        return 1;
    }

    if (listen(server_fd, 3) < 0) {
        perror("Listen failed");
        closesocket(server_fd);
        WSACleanup();
        return 1;
    }

    printf("Weather Server listening on port %d\n", PORT);

    while (1) {
        struct sockaddr_in client_address;
        int addrlen = sizeof(client_address);
        int new_socket = accept(server_fd, (struct sockaddr *)&client_address, &addrlen);
        if (new_socket < 0) {
            perror("Accept failed");
            continue;
        }

        pthread_t thread_id;
        int *client_socket = malloc(sizeof(int));
        *client_socket = new_socket;
        pthread_create(&thread_id, NULL, handle_client, client_socket);
        pthread_detach(thread_id);
    }

    closesocket(server_fd);
    WSACleanup();
    return 0;
}

void *handle_client(void *client_socket) {
    int sock = *(int *)client_socket;
    free(client_socket);

    char buffer[BUFFER_SIZE];
    char response[BUFFER_SIZE];

    while (1) {
        int valread = recv(sock, buffer, BUFFER_SIZE, 0);
        if (valread <= 0) break;

        buffer[valread] = '\0';
        get_weather_info(buffer, response);

        send(sock, response, strlen(response), 0);
    }

    closesocket(sock);
    return NULL;
}

void get_weather_info(const char *city, char *response) {
    for (int i = 0; i < weather_data_count; i++) {
        if (strcasecmp(weather_data[i].city, city) == 0) {
            snprintf(response, BUFFER_SIZE, "Weather in %s: %s\n", city, weather_data[i].weather);
            return;
        }
    }
    snprintf(response, BUFFER_SIZE, "Weather data for %s not found\n", city);
}