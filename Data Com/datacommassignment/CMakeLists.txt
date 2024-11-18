cmake_minimum_required(VERSION 3.29)
project(datacommassignment C)

set(CMAKE_C_STANDARD 11)

add_executable(datacommassignment main.c
        weather_client.c
        weather_server.c
)
