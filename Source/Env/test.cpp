#include <gtest/gtest.h>

TEST(EnvTest, ENV_VAR) {
  const char* env_var = std::getenv("ENV_VAR");
  ASSERT_STREQ(env_var, "ACTIONS_TEST");
}