#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <winsock2.h>
#include <ws2tcpip.h>
#include <pthread.h>

#pragma comment(lib, "Ws2_32.lib")

#define PORT 8080
#define BUFFER_SIZE 1024

// Structure to hold city weather data
typedef struct {
    char city[50];
    char weather[100];
} WeatherInfo;

// Sample weather data
WeatherInfo weather_data[] = {
        {"New York", "Sunny, 25°C"},
        {"Los Angeles", "Cloudy, 20°C"},
        {"Chicago", "Rainy, 18°C"},
        {"Miami", "Hot, 30°C"},
        {"Dallas", "Windy, 22°C"}
};
int weather_data_count = sizeof(weather_data) / sizeof(weather_data[0]);

void *handle_client(void *client_socket);
void get_weather_info(char *city, char *response);

int main() {
    WSADATA wsaData;
    int result = WSAStartup(MAKEWORD(2, 2), &wsaData);
    if (result != 0) {
        printf("WSAStartup failed: %d\n", result);
        return 1;
    }

    int server_fd, new_socket;
    struct sockaddr_in address;
    int opt = 1;
    int addrlen = sizeof(address);

    if ((server_fd = socket(AF_INET, SOCK_STREAM, 0)) == 0) {
        perror("Socket failed");
        exit(EXIT_FAILURE);
    }

    setsockopt(server_fd, SOL_SOCKET, SO_REUSEADDR, (const char*)&opt, sizeof(opt));

    address.sin_family = AF_INET;
    address.sin_addr.s_addr = INADDR_ANY;
    address.sin_port = htons(PORT);

    if (bind(server_fd, (struct sockaddr *)&address, sizeof(address)) < 0) {
        perror("Bind failed");
        closesocket(server_fd);
        WSACleanup();
        exit(EXIT_FAILURE);
    }

    if (listen(server_fd, 3) < 0) {
        perror("Listen failed");
        closesocket(server_fd);
        WSACleanup();
        exit(EXIT_FAILURE);
    }

    printf("Weather Server listening on port %d\n", PORT);

    while ((new_socket = accept(server_fd, (struct sockaddr *)&address, (socklen_t*)&addrlen)) >= 0) {
        pthread_t thread_id;
        int *client_socket = malloc(sizeof(int));
        *client_socket = new_socket;
        pthread_create(&thread_id, NULL, handle_client, (void *)client_socket);
    }

    closesocket(server_fd);
    WSACleanup();
    return 0;
}

void *handle_client(void *client_socket) {
    int sock = *(int*)client_socket;
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

void get_weather_info(char *city, char *response) {
    for (int i = 0; i < weather_data_count; i++) {
        if (strcasecmp(weather_data[i].city, city) == 0) {
            sprintf(response, "Weather in %s: %s\n", city, weather_data[i].weather);
            return;
        }
    }
    sprintf(response, "Weather data for %s not found\n", city);
}
