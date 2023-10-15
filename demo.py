# https://www.youtube.com/watch?v=lnsTJRY1jPU&ab_channel=SMKTECH
# https://www.thecoderworld.com/install-ubuntu-on-virtualbox/
# import clr
import os
import platform
print(platform.architecture())


import ctypes
from ctypes import*
# Load DLL into memory.
mydll = cdll.LoadLibrary(os.getcwd()+"\dlls\CMSPVT.dll")
import pdb;pdb.set_trace()

hllDll = ctypes.WinDLL(os.getcwd()+"\dlls\CMSPVT.dll")
hllApiProto = ctypes.WINFUNCTYPE (
    ctypes.c_int,      # Return type.
    ctypes.c_void_p,   # Parameters 1 ...
    ctypes.c_void_p,
    ctypes.c_void_p,
    ctypes.c_void_p)   # ... thru 4.
hllApiParams = (1, "p1", 0), (1, "p2", 0), (1, "p3",0), (1, "p4",0),
hllApi = hllApiProto (("clsPVTGas", hllDll), hllApiParams)
p1 = ctypes.c_int (1)
p2 = ctypes.c_char_p (sessionVar)
p3 = ctypes.c_int (1)
p4 = ctypes.c_int (0)
hllApi (ctypes.byref (p1), p2, ctypes.byref (p3), ctypes.byref (p4))
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