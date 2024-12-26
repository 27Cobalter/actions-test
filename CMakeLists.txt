cmake_minimum_required(VERSION 3.20)

set(CMAKE_TOOLCHAIN_FILE OFF CACHE BOOL "vcpkg")

project(actions-test LANGUAGES CXX)

set(CMAKE_EXPORT_COMPILE_COMMANDS ON)
set(CMAKE_CXX_STANDARD 23)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_CURRENT_BINARY_DIR}/bin)
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${CMAKE_CURRENT_BINARY_DIR}/lib)
set(CMAKE_INSTALL_PREFIX ${CMAKE_CURRENT_BINARY_DIR}/install)

if(NOT CPACK_GENERATOR)
  set(CPACK_GENERATOR "DEB;ZIP")
endif()

if(UNIX)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -march=native")
endif()

if(POLICY CMP0135)
  cmake_policy(SET CMP0135 NEW)
endif()

include(FetchContent)
FetchContent_Declare(
  googletest
  URL https://github.com/google/googletest/archive/refs/tags/v1.14.0.zip
)
set(gtest_force_shared_crt ON CACHE BOOL "" FORCE)
set(INSTALL_GTEST OFF)
FetchContent_MakeAvailable(googletest)
enable_testing()

set(CPACK_PACKAGE_NAME actions-test)
set(CPACK_PACKAGE_VENDOR 27Cobalter)
set(CPACK_PACKAGE_DESCRIPTION_SUMMARY "test project")
set(CPACK_PACKAGE_CONTACT 27Cobalter)
set(CPACK_PACKAGE_DIRECTORY ${CMAKE_CURRENT_BINARY_DIR}/package)
set(CPACK_WIX_VERSION 4)
set(CPACK_WIX_INSTALL_SCOPE perMachine)
set(CPACK_WIX_PROPERTY_MSIUSEREALADMINDETECTION "1")
set(CPACK_WIX_PROPERTY_InstallPrevileges "elevated")
set(CPACK_WIX_PROPERTY_AdminImage "yes")
set(CPACK_WIX_PROPERTY_WIX_ELEVATE_MODE 1)
set(CPACK_WIX_PROPERTY_IMPERSONATE YES)
set(CPACK_WIX_PROPERTY_AlwaysInstallElevated 1)

# set(CPACK_PACKAGING_INSTALL_PREFIX /opt/actions-test)

# set(CPACK_WIX_SKIP_PROGRAM_FOLDER ON)
# set(CPACK_PACKAGE_INSTALL_DIRECTORY "C:\\ProgramData")
# set(CPACK_PACKAGING_INSTALL_PREFIX "actions-test")
set(CPACK_WIX_EXTRA_SOURCES ${CMAKE_CURRENT_SOURCE_DIR}/wix/programdata.wxs)
include(CPack)

add_subdirectory(src)
