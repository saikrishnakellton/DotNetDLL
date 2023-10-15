# https://www.youtube.com/watch?v=lnsTJRY1jPU&ab_channel=SMKTECH
# https://www.thecoderworld.com/install-ubuntu-on-virtualbox/
import clr
import os
import argparse

# clr.AddReference(os.getcwd()+"\dlls\CalcProject.dll")
# dll_path = os.path.join(os.getcwd(), "dlls", "CalcProject.dll").replace("\\", "/")
dll_path = os.path.join('D:\projects\DotNetDLL', "dlls", "CMSPVT.dll").replace("\\", "/")

clr.AddReference(dll_path)
from CalcProject import calculate

# obj = calculate()
# print(f"Addition of 1, 2 is {obj.Add(1,2)}")
# print(f"Substraction of 5, 2 is {obj.Add(5,2)}")


def main():
    stop = True
    while stop:
        # Create an instance of the calculate class
        obj = calculate()

        # Get user input for the operation
        operation = input('Select operation (add/sub/exit): ')
        if operation == 'exit':
            stop = False
            print(f"Thank you!")
            return
        # Get user input for operands
        operand1 = int(input('Enter the first operand: '))
        operand2 = int(input('Enter the second operand: '))

        # Perform the selected operation
        if operation == 'add':
            result = obj.Add(operand1, operand2)
            print(f"Addition of {operand1}, {operand2} is {result}")
        elif operation == 'sub':
            result = obj.Sub(operand1, operand2)
            print(f"Subtraction of {operand1}, {operand2} is {result}")
        else:
            print('Invalid operation. Please choose add or sub.')

if __name__ == '__main__':
    main()
