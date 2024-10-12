#include "lib.h"

#include <iostream>

TestClass::TestClass(int32_t val) : val_(val) {};

void TestClass::Print() {
  std::cout << val_ << std::endl;
}