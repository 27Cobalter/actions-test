add_executable(main main.cc)
target_link_libraries(main PRIVATE lib)

macro(PRE_INSTALL_SIGN filename)
  install(CODE "execute_process(COMMAND powershell -c 'echo InstallTime: ${filename}')")
endmacro()

PRE_INSTALL_SIGN("${CMAKE_RUNTIME_OUTPUT_DIRECTORY}/$<TARGET_FILE_NAME:main>")
# install(CODE "execute_process(COMMAND powershell -c 'echo InstallTime: ${CMAKE_RUNTIME_OUTPUT_DIRECTORY}/$<TARGET_FILE_NAME:main>')")
install(TARGETS main
RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR}
)

if(CMAKE_INSTALL_BINDIR)
  set(prop_install_bindir "${CMAKE_INSTALL_BINDIR}/")
endif()

set_property(INSTALL "${prop_install_bindir}$<TARGET_FILE_NAME:main>"
PROPERTY CPACK_START_MENU_SHORTCUTS "main"
)
set_property(INSTALL "${prop_install_bindir}$<TARGET_FILE_NAME:main>"
PROPERTY CPACK_DESKTOP_SHORTCUTS "main"
)
