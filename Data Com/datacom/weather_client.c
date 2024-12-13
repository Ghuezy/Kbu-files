#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <winsock2.h>
#include <ws2tcpip.h>

#pragma comment(lib, "Ws2_32.lib")

#define PORT 8080
#define BUFFER_SIZE 1024

void cleanup(int sock) {
    closesocket(sock);
    WSACleanup();
}

int main() {
    WSADATA wsaData;
    if (WSAStartup(MAKEWORD(2, 2), &wsaData) != 0) {
        fprintf(stderr, "WSAStartup failed\n");
        return 1;
    }

    int sock = socket(AF_INET, SOCK_STREAM, 0);
    if (sock < 0) {
        perror("Socket creation error");
        WSACleanup();
        return 1;
    }

    struct sockaddr_in serv_addr = {0};
    serv_addr.sin_family = AF_INET;
    serv_addr.sin_port = htons(PORT);

    if (inet_pton(AF_INET, "127.0.0.1", &serv_addr.sin_addr) <= 0) {
        fprintf(stderr, "Invalid server address\n");
        cleanup(sock);
        return 1;
    }

    if (connect(sock, (struct sockaddr *)&serv_addr, sizeof(serv_addr)) < 0) {
        perror("Connection failed");
        cleanup(sock);
        return 1;
    }

    char buffer[BUFFER_SIZE];
    while (1) {
        printf("Enter city name to get weather (or 'exit' to quit): ");
        if (fgets(buffer, BUFFER_SIZE, stdin) == NULL) break;

        buffer[strcspn(buffer, "\n")] = 0; // Remove trailing newline

        if (strcmp(buffer, "exit") == 0) break;

        send(sock, buffer, strlen(buffer), 0);

        int valread = recv(sock, buffer, BUFFER_SIZE, 0);
        if (valread > 0) {
            buffer[valread] = '\0';
            printf("%s", buffer);
        }
    }

    cleanup(sock);
    return 0;
}