add_executable(lib_test lib_test.cc)

include(GoogleTest)

target_link_libraries(lib_test PRIVATE lib GTest::gtest_main)

gtest_discover_tests(lib_test)