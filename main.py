# https://www.youtube.com/watch?v=lnsTJRY1jPU&ab_channel=SMKTECH
# https://www.thecoderworld.com/install-ubuntu-on-virtualbox/
import clr
import os

clr.AddReference(os.getcwd()+"\dlls\CalcProject.dll")
# dll_path = os.path.join(os.getcwd(), "dlls", "CalcProject.dll").replace("\\", "/")
# clr.AddReference(dll_path)
from CalcProject import calculate


obj = calculate()
print(obj.Add(1,2))