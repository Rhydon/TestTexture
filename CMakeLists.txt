cmake_minimum_required(VERSION 3.20)
project(DrawSVG)

set(CMAKE_CXX_STANDARD 14)

include_directories(include)
include_directories(lib)

add_library(glfw STATIC IMPORTED)
set_target_properties(glfw PROPERTIES
        IMPORTED_LOCATION "${CMAKE_CURRENT_SOURCE_DIR}/lib/glfw3.lib"
        INTERFACE_INCLUDE_DIRECTORIES "${CMAKE_CURRENT_SOURCE_DIR}/include")

link_directories(${CMAKE_CURRENT_SOURCE_DIR}/include/stb_image.h)

add_executable(main
	       glad.c
	       Shader.cpp
               main.cpp)

target_link_libraries(main 
		     PRIVATE glfw)
