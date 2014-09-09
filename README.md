Programmer's Model
Gemini is an accumulator-based processor with a single bus 
connecting the ALU, the accumulator (ACC) and program counter (PC) 
registers, and main memory.  The bus is used for both address and 
data.  The accumulator is the target of the load, arithmetic and 
logic operations.  It is the source for the store operation. It is 
not affected by branching.  A constant ZERO is used by the load 
instruction, which places the value from memory into the 
accumulator by adding ZERO plus the value into the accumulator. 
ZERO is otherwise inaccessible to the programmer. To clear the 
accumulator to zero, if desired, the programmer must load the 
value zero from memory.

From the programmer's view, Gemini instructions use a 
demultiplexer and a multiplexer to control the target of the 
accumulator, and to select the operand for the machine instruction 
(ZERO for load, the accumulator for arithmetic and logic).                                                      

Instruction Set
For this Project, Gemini has 17 instructions:

        (Note that $val indicates a memory location
                   #$val indicates an actual value from the text segment)

        - LDA #$val Sets the accumulator with the value
        - LDA $m	Sets the accumulator from a memory location
        - STA $m  Store the accumulator to a memory location
        - ADD $m	Add the value in memory to the accumulator
          ADD #$val     Add the value to the accumulator
        - SUB $m	Subtract the value in memory to the accumulator
          SUB #$val     Subtract the value to the accumulator
        - MUL $m        Multiply the accumulator by the value in memory
          MUL #$val     Multiply the accumulator by the value 
        - DIV $m        Divide the accumulator by the value in memory
          DIV #$val     Divide the accumulator by the value
        - AND $m	Logical "and" of memory and accumulator
          AND #$val     Logical "and" of value and accumulator
        - OR  $m	Logical "or" of memory and accumulator
          OR  #$val     Logical "or" or value and the accumulator
        - SHL #$val Shift the accumulator by the number of bits to the left
        - NOTA		Logical "not" of accumulator
        - BA lbl        Always branch to label (goto)
        - BE lbl	Branch to label if operation resulted in 0
        - BL lbl        Branch to label if operation resulted in Negative
        - BG lbl        Branch to label if operation resulted in Positive 
        - NOP           No Operation (Implemented by adding Zero to the ACC)
        - HLT           Quit the program (not needed if the last line of the program is the end)

The instructions have the following format:

	- two bytes
	

The reserved field in the first byte of the instruction would 
typically be used to extend the Gemini architecture with more 
instructions and/or addressing modes. The temptation of an 
architect to use these bits for unsupported instructions, and the 
ingenuity of users who hunted for and used the unsupported 
instructions, was the bane of early architects, who would drop the 
unsupported instructions only to have the users complain bitterly.
Addressing Modes
Gemini has a single direct-addressing memory mode.  Other 
addressing modes can be constructed by modifying the program in 
memory. This is known as self-modifying code, and was the only way 
to construct many programming constructs in the early days of 
computer architecture that we now take for granted.

Other addressing modes can be encoded in the reserved field, and 
implemented in the microcode.
Memory
Gemini has an eight-bit memory address field.  Thus all 
data must fit into a 256 byte main memory.
Assignment
Functionality
The software will take a file name of a file that contains Gemini Assembly constructed with newlines (Examples follow).
The software will run in a WinForms GUI.
The program will load the strings from the file and parse the strings one at a time.
If a program is invalid in any way, we should quit and tell the user the line number of the failure.
Finally, the parser will dump out a binary file representing the ASM code in machine language.
Next, the program will start running in the simulator component of the program. (You can separate these functions out however you like depending on time and how you want to do it- discussed in class)
If during program execution the simulator notices any problems (namely Segmentation Faults- it should also quit and tell the user the line number of the fault.
When a binaey file is read by the main program the following will happen:
Optional: Display the string in the simulator window to show the user what instruction is currently running. (IR will always show the binary representation of the code, you can also make it display human readable text too).
Show updates to all registers in the simulator window as the line of code is run.
GUI Design
The GUI should look something like the following screen shot: 
 

As each 'cycle' is taking place, the user is required to press the button to perform the next cycle. Pressing the run to end button will bring the user to the end of the program.
When the assembly in the program has finished- we will show nothing as the next instruction- keep the register values in place and simply wait for the user to quit or load a new program.
Parsing Gemini ASM files
Comments (!) and pointless whitespace should be ignored. Here is an example:
	! Ignore this comment
	add #$10        ! Add 10 to the accumulator
	
	and $10        ! And memory address 10 with the accumulator
	nop
	lda      #$10
			
The above is equivelant to:
	add #$10
	and $10
	nop
	lda #$10
			
Labels: Labels shall be handled a little differently than normal instructions

Here is an example of a label:
0| and $10
1| lbl:  ! Here's a label!
2| or $11

To handle this we will replace any instructions that use lbl with the index number of the instruction!
ble lbl

should end up looking like
ble 1

in our Instruction Vector since it is the second instruction. 

To do this, I recommend keeping 2 lists of instructions that contain labels and labels/index numbers as you come across them (Since we may or may not know where a label exists in a program as we read it- therefore we might not know the Instruction Vector Index of that label). 

So, when you come across ble lbl you will ask your list, do I know what index lbl is? If not, we push this instruction into out 'unknown instruction list'. If we do know the index, we simply replace the label string name with a number. At the end of parsing a program, we re-visit each instruction in our unknown list and place the label index number there. 

Finally, if there are any unknown instructions left- we cannot assemble this program! Note that having an unused label is just fine.
Binary Encoding of your Instructions
(NOTE: these values below are simply examples): 
Gemini ASM file (something like test1.s): 
main:
    lda #$1       
    add #$1

Processed by a new program you write called gasm (or built-in to your GUI program): 
1010000000000001        =  lda #$1
1100000000000001        =  add #$1

Binary stored into g.out
Your Gemini Emulator will read binary files and parse them.
You will be creating a RISC machine out of the Gemini architecture. 

Your binary instructions can be formatted any way you choose. No matter what implementation you choose, you may find the need to add more instructions than the ones listed above. As discussed in class, you should keep your instructions fitting in a 16-bit integer. The max value asked of your ISA will be 256 (decimal).

Suggested Program Design - Classes
The Class Layout should be as follows:
Main
Contains the GUI code
Contains a reference to Memory 
Needs access to the following from Memory:
int getInstructionCount()         //for top progress info
string getInstruction()
Contains a reference to CPU 
Needs access to the following from CPU:
Public access to all register values
int currentOperationNum()         //Tell the GUI what the CPU is doing currently
string currentOperation()
int getCurrentInstructionNumber() //To interface with memory
int getCurrentOperationCount()    //How many total operations have we done?
CPU
Contains the IPR to parse Instructions
Contains a reference to Memory
This class will hold the 11 registers. They will be of type int 
The register names are:
A
B
Acc
Zero
One
PC
MAR
MDR
TEMP
IR
CC
This class will also contain the ALU. It needs to have all of the code to execute the instructions.

IPE (Instruction Parser Engine)
Contains a reference to Memory to fill the Instruction Vector
Responsible for parsing ASM files
Responsible for encoding the instructions into binary
Responsible for saving binary to file

Memory
Contains the primitaves for memory access
This class will contain 2 different 'regions' of memory
List<short> Instructions;           // Instruction Vector
int Memory[256];                    // Main Memory
The Instructions List will hold binary encoded Gemini Assembly. This will be loaded from a file with each line of assembly delimited
Note that Memory[] should handle segmentation faults. As in Accessing Memory[256] should fail, but not break your program.
Project Steps
Here is how I recommend building this software- you can take whatever approach you prefer as this is an open project- just remember that the final results must operate as required! 

Make sure you understand how to update the GUI and process input from the user.

Create the IPR Class and make small tests to read instructions from a file and get them to the screen. Ensure that your IPR can handle invalid instructions, comments and whitespace.

Convert those strings to binary using the encoding we have discussed.

Create the Memory class and make your IPR interface with it to fill the Instruction Vector with instructions- then print them out.

Create the CPU class which will contain logic for the Gemini CPU ALU and memory operations. Remember from the GUI that we need to track operations and operation counts. Your CPU class should then contain the IPR and be able to actually run binary code.

Link the CPU/Memory classes with your GUI to complete this project.
Tests
You should create tests for your program to see how it operates throughout the build process. However, the program must pass these final tests and you will be required to answer the questions about the tests. 

Test 1 - Instruction Examination 
Download test1.s
main:
   lda #$1
   sta $0     ! 1 into Stack[0]
   sta $255   ! 1 into Stack[255]

   add $0     ! 2 in ACC
       
   lda $0
       sub $0     ! 0 in ACC

   lda $0
   and $255   ! 1 & 1 is 1 in ACC

       lda #$0
       or $0      ! 1 | 0 is 1 in ACC

       lda #$0
       nota       ! !0 in ACC

   nop


Test 2 - Invalid Instruction! 
Download test2.s
main:
   lda $0  Hey- I forgot to put !
   add #@3

Test 3 - Basic for() loop 
Download test3.s
main:
    lda #$5
    sta $2        ! x = 5  (Stack[2])
    lda #$0       ! for(int i = 0; i < 10; i++){
    sta $0        ! i is in Stack[0]
    lda #$10    
    sta $1        ! constant 10 pushed to stack (Stack[1])

check:
    lda $1
    sub $0
    bl out        ! 10 - i = Negative for condition to be true
luup:
    lda $0
    add #$1       ! i++
    sta $0

    lda $2        ! x
    add #$2       ! x += 2;
    and $0        ! x = x & i;
    ba check
out:
    lda $2        ! x Back into ACC for examination

Test 4 - Segmentation Fault 
Download test4.s
main:
   lda #$32
   sta $392       ! Stack[392]???


Test 5 - Convert to ASM 
Download test5.c 

Convert the following C code to Gemini ASM and run it through your simulator.
int main(void){
    int x = 3;
    int y = 0;
    int z;
    for(; y; x--){
        z = 2;
        y = x / z;
        z = z + x;
        if(y == 9) {
            y = z * 256 + x * 257;
            goto rehash;
        }
    }
    rehash:
        y = (y & x) & (x | y);
    out:
     // Place y into the ACC to examine
}
Turn In
You will need to turn in the following:
Entire Solution (Cleaned of bin/obj)
Screen captures of your solutions running (at least one at the end of each test running).
Any manually created asm (.s) files.
Binary conversions of those .s files (your assembled .out files for example)
Any additional Readme/notes you feel are needed for this project.