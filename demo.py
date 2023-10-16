# https://www.youtube.com/watch?v=lnsTJRY1jPU&ab_channel=SMKTECH
# https://www.thecoderworld.com/install-ubuntu-on-virtualbox/
# import clr
import os
import platform
print(platform.architecture())


import ctypes
from ctypes import*
# Load DLL into memory.
import pdb;pdb.set_trace()
your_dll = ctypes.windll.LoadLibrary('CMSPVT.dll')


# # clr.AddReference(os.getcwd()+"\dlls\CMSPVT.dll")
# dll_path = os.path.join(os.getcwd(), "clientdll", "CMSPVT.dll").replace("\\", "/")
# clr.AddReference(dll_path)
# your_dll = ctypes.windll.LoadLibrary('CMSPVT.dll')
# print(your_dll)
# # import pdb;pdb.set_trace()
# result = your_dll.clsPVTGas()

# # Print the result
# print(result)
# from ctypes import windll
# windll.kernel32.SetDllDirectoryW(r'D:\projects\DotNetDLL\clientdll')
# clr.AddReference('CMSPVT')

# clr.AddReference(os.getcwd()+"\dlls\CalcProject.dll")
# dll_path = os.path.join(os.getcwd(), "clientdll", "CMSPVT.dll").replace("\\", "/")
# clr.AddReference(dll_path)
# from clsPVTGas import FctRsPbCor

# obj = FctRsPbCor()
# print(f"Addition of 1, 2 is {obj.Add(1,2)}")
# print(f"Substraction of 5, 2 is {obj.Add(5,2)}")