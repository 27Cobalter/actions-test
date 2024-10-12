#include <cstdint>

#include <gtest/gtest.h>

#include <lib.h>

auto values = ::testing::Values(
  334,
  668
);

class MultiParams : public ::testing::TestWithParam<int> {
};

INSTANTIATE_TEST_CASE_P(, MultiParams,values);


TEST_P(MultiParams, Normal) {
  const auto param = GetParam();
  TestClass test(param);
  test.Print();
}