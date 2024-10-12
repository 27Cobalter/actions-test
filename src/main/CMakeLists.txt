add_executable(main main.cc)
target_link_libraries(main PRIVATE lib)

install(TARGETS main
RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR}
)
