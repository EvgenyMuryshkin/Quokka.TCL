create_project -part xa7s6cpga196-2I -verbose test
set_property target_language Verilog [current_project]
add_files C:/code/Quokka.TCL/Quokka.TCL.Tests/source/testbench_fail.v C:/code/Quokka.TCL/Quokka.TCL.Tests/source/testbench_pass.v C:/code/Quokka.TCL/Quokka.TCL.Tests/source/top.v
update_compile_order -fileset sources_1
set_property top top [current_fileset]
set_property top testbench_fail [get_filesets sim_1]
set_property SOURCE_SET sources_1 [get_filesets sim_1]
set_property RUNTIME 0ns [get_filesets sim_1]
launch_runs -jobs 4 impl_1
wait_on_run impl_1
launch_simulation -mode post-implementation -type timing
restart
open_vcd C:/code/Quokka.TCL/Quokka.TCL.Tests/output/sim.vcd
log_vcd *
run 1000 ns
flush_vcd
close_vcd
close_sim
