set(ActionsTest_DIR ../../build/install/lib/cmake/lib)
find_package(ActionsTest REQUIRED)
add_executable(main main.cc)
target_link_libraries(main PRIVATE ActionsTest::Lib)
