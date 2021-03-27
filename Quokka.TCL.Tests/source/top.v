`timescale 1ns / 1ps

module top (
	input clk,
	input rst,
	output wire [7:0] outCounter
);

reg [7:0] counter = 0;

assign outCounter = counter;

always @(posedge(clk))
begin
	if (rst)
		counter = 0;
	else
		counter = counter + 1;
end

endmodule