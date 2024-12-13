cmake_minimum_required(VERSION 3.15)
project(datacom)

set(CMAKE_C_STANDARD 11)

# Add the server executable
add_executable(weather_server weather_server.c)
target_link_libraries(weather_server Ws2_32)

# Add the client executable
add_executable(weather_client weather_client.c)
target_link_libraries(weather_client Ws2_32)
