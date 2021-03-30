`timescale 1ns / 1ps

`define assert(expected, actual, message) \
        if (expected !== actual) begin \
            $display("Assert failed"); \
            $display(message); \
            $display("Expected: 0x%H, Actual: 0x%H", expected, actual); \
            /*$finish;*/ \
        end

module testbench_pass();
    reg clk;
    reg rst;
    wire [7:0] outCounter;
   // Clock gen
   initial begin
      clk = 1'b0;
      forever clk = #100 ~clk;
   end

   // reset logic, keep for 1 clock cycle
   initial begin
      rst = 1'b1;
      @(negedge clk);
      rst = 1'b0;
   end
   
    initial begin
        // reset
        @(negedge clk);
        // 1
        @(negedge clk);
        `assert(1, outCounter, "Counter value does not match (1)");
        @(negedge clk);
        `assert(2, outCounter, "Counter value does not match (2)");
        repeat(100) @(negedge clk);
    end      
    
       // DUT instantiation
   top dut (
		     .clk        (clk),
		     .rst        (rst),
		     .outCounter (outCounter)		     
		     );

endmodule
