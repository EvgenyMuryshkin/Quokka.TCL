`timescale 1ns / 1ps

module testbench();
    reg clk;
    reg rst;
    wire [7:0] outCounter;
   // Clock gen
   initial begin
      clk = 1'b0;
      forever clk = #10 ~clk;
   end

   // reset logic, keep for 1 clock cycle
   initial begin
      rst = 1'b1;
      @(negedge clk);
      rst = 1'b0;
   end
   
    initial begin
        @(negedge clk);
        repeat(2) @(negedge clk);
        $display("ASSERTION FAILED");
        $finish(2);
        repeat(100) @(negedge clk);
    end      
    
       // DUT instantiation
   top dut (
		     .clk        (clk),
		     .rst        (rst),
		     .outCounter (outCounter)		     
		     );

endmodule
