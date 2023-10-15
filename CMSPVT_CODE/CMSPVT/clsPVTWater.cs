// Decompiled with JetBrains decompiler
// Type: clsPVTWater
// Assembly: CMSPVT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 201CCC60-7B31-408F-B41C-5D93C51866A1
// Assembly location: C:\Users\Sai Krishna\Downloads\CMSPVT.dll

using Microsoft.VisualBasic.CompilerServices;
using System;

public class clsPVTWater
{
  public static double FctBw(double Tr, double Pr)
  {
    double x = Tr * 1.8 + 32.0;
    double num;
    try
    {
      num = x <= 0.0 || Pr <= 0.0 ? 0.0 : (1.0 - 2.8326000000000002E-08 * Pr * x - 3.63584E-11 * Math.Pow(Pr, 2.0) * x - 5.2058E-06 * Pr - 4.74041E-08 * Math.Pow(Pr, 2.0)) * (0.989999 + 0.00013339 * x + 5.50654E-07 * Math.Pow(x, 2.0));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctCmpW(double Tr, double Pr)
  {
    double x = Tr * 1.8 + 32.0;
    double num1 = Pr * 14.5038;
    double num2;
    try
    {
      num2 = x <= 0.0 || num1 <= 0.0 ? 0.0 : (3.8546 - 0.000134 * num1 + (4.77E-06 * num1 - 0.01052) * x + (0.00039267 - 8.8E-09 * num1) * Math.Pow(x, 2.0)) * 1E-05 / 14.5038;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctDenW(double Sal) => 16.0185 * (62.368 + 0.438603 * Sal + 0.00160074 * Math.Pow(Sal, 2.0));

  public static double FctSigmaW(double Pr)
  {
    double num;
    try
    {
      num = Pr <= 0.0 ? 0.0 : 1000.0 / Math.Pow(10.0, 1.19 + 0.001 * Pr);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctVisW(double Tr, double Pr, double Sal)
  {
    double x = Tr * 1.8 + 32.0;
    double num;
    try
    {
      num = x <= 0.0 || Pr <= 0.0 ? 0.0 : (109.574 - 8.40564 * Sal + 0.313314 * Math.Pow(Sal, 2.0) + 0.00872213 * Math.Pow(Sal, 3.0)) * Math.Pow(x, -(1.12166 - 0.0263951 * Sal + 0.000679461 * Math.Pow(Sal, 2.0) + 5.47119E-05 * Math.Pow(Sal, 3.0) - 1.55586E-06 * Math.Pow(Sal, 4.0))) * (0.9994 + 0.000584439 * Pr + 6.53439E-07 * Math.Pow(Pr, 2.0));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }
}
