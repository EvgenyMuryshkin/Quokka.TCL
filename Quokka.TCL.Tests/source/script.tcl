create_project -part xcku5p-ffvb676-2-e -verbose test
set_property board_part xilinx.com:kcu116:part0:1.5 [current_project]
set_property target_language Verilog [current_project]
set_property default_lib work [current_project]
add_files C:/code/Quokka.TCL/Quokka.TCL.Tests/source/testbench.v
add_files C:/code/Quokka.TCL/Quokka.TCL.Tests/source/top.v
update_compile_order -fileset sources_1
set_property top testbench [current_fileset]
set_property top testbench [get_filesets sim_1]
launch_simulation
close_sim
