create_project -part xcku5p-ffvb676-2-e -verbose test
set_property board_part xilinx.com:kcu116:part0:1.5 [current_project]
set_property target_language Verilog [current_project]
set_property default_lib work [current_project]
set_property platform.board_id kcu116 [current_project]
add_files C:/code/Quokka.TCL/Quokka.TCL.Tests/source/testbench.v C:/code/Quokka.TCL/Quokka.TCL.Tests/source/top.v
update_compile_order -fileset sources_1
set_property top testbench [current_fileset]
set_property top testbench [get_filesets sim_1]
set_property SOURCE_SET sources_1 [get_filesets sim_1]
set_property RUNTIME 0ns [get_filesets sim_1]
launch_simulation
restart
open_vcd C:/code/Quokka.TCL/Quokka.TCL.Tests/output/sim.vcd
log_vcd *
run 1000 ns
flush_vcd
close_vcd
close_sim
