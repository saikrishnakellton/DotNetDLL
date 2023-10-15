// Decompiled with JetBrains decompiler
// Type: clsPVTOil
// Assembly: CMSPVT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 201CCC60-7B31-408F-B41C-5D93C51866A1
// Assembly location: C:\Users\Sai Krishna\Downloads\CMSPVT.dll

using Microsoft.VisualBasic.CompilerServices;
using System;

public class clsPVTOil
{
  public static double FctMwtO(double GamaO)
  {
    double num;
    if (GamaO > 0.0)
    {
      if (GamaO >= 0.825)
      {
        num = 1945.0 - 1415.0 / GamaO;
      }
      else
      {
        double x = 0.109 / GamaO - 0.101;
        num = x == 0.0 ? 0.0 : Math.Pow(x, -1.552);
      }
    }
    else
      num = 0.0;
    return num;
  }

  public static double FctPrPb_Stand(double Tr, double GamaO, double RsPbCor, double GamaG)
  {
    double num1 = Tr + 273.16;
    double num2;
    try
    {
      num2 = num1 <= 0.0 || GamaO <= 0.0 || RsPbCor <= 0.0 || GamaG <= 0.0 ? 0.0 : 519.7 * Math.Pow(RsPbCor / GamaG, 0.83) * Math.Pow(10.0, 1.225 + 0.00164 * num1 - 1.769 / GamaO) * 0.01;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctPrPb_VasBegg(
    double Tr,
    double GamaO,
    double RsPbCor,
    double GamaG,
    double Tsep,
    double Psep)
  {
    double num1 = Tr + 273.16;
    double num2 = Tsep + 273.16;
    double num3;
    try
    {
      if (num1 > 0.0 && GamaO > 0.0 && RsPbCor > 0.0 && GamaG > 0.0 && num2 > 0.0 && Psep > 0.0)
      {
        double num4;
        double num5;
        double num6;
        double y;
        if (GamaO <= 0.876)
        {
          num4 = 0.0003204;
          num5 = 1881.24;
          num6 = 1748.29;
          y = 337.0 / 400.0;
        }
        else
        {
          num4 = 0.0007803;
          num5 = 2022.19;
          num6 = 1879.28;
          y = 0.9143;
        }
        double num7 = GamaG * (1.0 + 5.912E-05 * (141.5 / GamaO - 131.5) * 1.8 * (num2 - 255.388) * Math.Log(0.12645 * Psep) / Math.Log(10.0));
        double num8 = num4 * num7 * Math.Exp(num5 / (GamaO * num1) - num6 / num1);
        num3 = Math.Abs(num8) >= 1E-21 ? Math.Pow(RsPbCor / num8, y) / 100.0 : 0.0;
      }
      else
        num3 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num3 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num3;
  }

  public static double FctPrPb_Glaso(double Tr, double GamaO, double RsPbCor, double GamaG)
  {
    double num1 = Tr + 273.16;
    double num2;
    try
    {
      if (num1 > 0.0 && GamaO > 0.0 && RsPbCor > 0.0 && GamaG > 0.0)
      {
        double d = 4.519189 * Math.Pow(RsPbCor / GamaG, 0.816) * Math.Pow(num1 - 255.3822, 0.172) * Math.Pow(141.5 / GamaO - 131.5, -0.989);
        num2 = d >= 1E-10 ? 6.8947 * Math.Pow(10.0, 1.7669 + 1.7447 * (Math.Log(d) / Math.Log(10.0)) - 0.30218 * Math.Pow(Math.Log(d) / Math.Log(10.0), 2.0)) / 100.0 : 0.0;
      }
      else
        num2 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctPrPb_Meco(double Tr, double GamaO, double RsPbCor, double GamaG)
  {
    double x = Tr + 273.16;
    double num;
    try
    {
      num = x <= 0.0 || GamaO <= 0.0 || RsPbCor <= 0.0 || GamaG <= 0.0 ? 0.0 : 0.27770149 * Math.Pow(RsPbCor, 0.715082) * Math.Pow(GamaG, -1.87784) * Math.Pow(GamaO, 3.1437) * Math.Pow(x, 1.32657) / 100.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctPrPb_KartoSchm(
    double Tr,
    double GamaO,
    double RsPbCor,
    double GamaG,
    double Tsep,
    double Psep)
  {
    double num1 = (Tr + 273.16) * 1.8;
    double x1 = Tsep * 1.8 + 32.0;
    double num2 = Psep * 14.5038;
    double num3;
    try
    {
      if (num1 > 0.0 && GamaO > 0.0 && RsPbCor > 0.0 && GamaG > 0.0 && x1 > 0.0 && num2 > 0.0)
      {
        double x2 = 141.5 / GamaO - 131.5;
        double num4;
        double y1;
        double num5;
        double y2;
        if (x2 > 30.0)
        {
          num4 = 0.0315;
          y1 = 0.7587;
          num5 = 11.2895;
          y2 = 0.9143;
        }
        else
        {
          num4 = 0.05958;
          y1 = 0.7972;
          num5 = 13.1405;
          y2 = 0.9986;
        }
        double x3 = GamaG * (1.0 + 0.1595 * Math.Pow(x2, 0.4078) * Math.Pow(x1, -0.2466) * Math.Log(num2 / 114.7));
        num3 = Math.Pow(RsPbCor * 5.61742 / (num4 * Math.Pow(x3, y1) * Math.Pow(10.0, num5 * x2 / num1)), y2) / 14.5038;
      }
      else
        num3 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num3 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num3;
  }

  public static double FctPrPb_PetroFar(double Tr, double GamaO, double RsPbCor, double GamaG)
  {
    double x = Tr * 1.8 + 32.0;
    double num;
    try
    {
      if (x > 0.0 && GamaO > 0.0 && RsPbCor > 0.0 && GamaG > 0.0)
      {
        double y = 0.0007916 * Math.Pow(141.5 / GamaO - 131.5, 1.541) - 4.561E-05 * Math.Pow(x, 1.3911);
        num = (112.727 * Math.Pow(RsPbCor * 5.61742, 0.577421) / (Math.Pow(GamaG, 0.8439) * Math.Pow(10.0, y)) - 1391.51) / 14.5038;
      }
      else
        num = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctPrPb_Lasater(
    double Tr,
    double GamaO,
    double RsPb,
    double GamaG,
    double MwtO)
  {
    double Left = Tr + 273.16;
    double num;
    try
    {
      if (Left > 0.0 && GamaO > 0.0 && RsPb > 0.0 && GamaG > 0.0 && MwtO > 0.0)
      {
        double x = 0.0148 * RsPb / (0.0148 * RsPb + 350.0 * GamaO / MwtO);
        object Right = x <= 0.6 ? (object) (8.427 * Math.Exp(2.78 * x) - 4.01) : (object) (102.51 * Math.Pow(x, 3.56) + 24.2);
        num = Conversions.ToDouble(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) Left, Right), (object) GamaG), (object) 0.01));
      }
      else
        num = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctRs_Stand(double Tr, double Pr, double GamaO, double GamaG, double Pb)
  {
    if (Pr > Pb)
      Pr = Pb;
    double num1 = Tr + 273.16;
    double num2 = Pr * 100.0;
    double num3;
    try
    {
      num3 = num1 <= 0.0 || num2 <= 0.0 || GamaO <= 0.0 || GamaG <= 0.0 ? 0.0 : (GamaO == 1.769 ? 0.0 : GamaG * Math.Pow(num2 / (519.7 * Math.Pow(10.0, 1.225 + 0.00164 * num1 - 1.769 / GamaO)), 1.204));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num3 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num3;
  }

  public static double FctRs_VasBegg(double Tr, double Pr, double GamaO, double GamaG, double Pb)
  {
    if (Pr > Pb)
      Pr = Pb;
    double num1 = Tr + 273.16;
    double x = Pr * 100.0;
    double num2;
    if (num1 > 0.0 && x > 0.0 && GamaO > 0.0 && GamaG > 0.0)
    {
      double num3;
      double y;
      double num4;
      double num5;
      if (GamaO <= 0.876)
      {
        num3 = 0.0003204;
        y = 1.187;
        num4 = 1881.24;
        num5 = 1748.29;
      }
      else
      {
        num3 = 0.0007803;
        y = 1.0937;
        num4 = 2022.19;
        num5 = 1879.28;
      }
      double d = num4 / (GamaO * num1) - num5 / num1;
      num2 = d == 0.0 ? 0.0 : Math.Pow(x, y) * num3 * Math.Exp(d) * GamaG;
    }
    else
      num2 = 0.0;
    return num2;
  }

  public static double FctRs_Glaso(double Tr, double Pr, double GamaO, double GamaG, double Pb)
  {
    if (Pr > Pb)
      Pr = Pb;
    double x = (Tr + 273.16) * 1.8;
    double d = Pr * 14.5038;
    double num1;
    try
    {
      if (x > 0.0 && d > 0.0 && GamaO > 0.0 && GamaG > 0.0)
      {
        double num2 = Math.Pow(10.0, 2.8869 - Math.Pow(14.1811 - 3.3093 * Math.Log(d), 0.5));
        num1 = GamaG * Math.Pow(Math.Pow(141.5 / GamaO - 131.5, 0.989) / Math.Pow(x, 0.172) * num2, 1.225) / 5.61742;
      }
      else
        num1 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num1 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num1;
  }

  public static double FctRs_MECO(double Tr, double Pr, double GamaO, double GamaG, double Pb)
  {
    if (Pr > Pb)
      Pr = Pb;
    double x = (Tr + 273.16) * 1.8;
    double num1 = Pr * 14.5038;
    double num2;
    try
    {
      num2 = x <= 0.0 || num1 <= 0.0 || GamaO <= 0.0 || GamaG <= 0.0 ? 0.0 : Math.Pow(185.843208 * Math.Pow(GamaG, 1.87784) * Math.Pow(GamaO, -3.1437) * Math.Pow(x, -1.32657) * num1, 1.398441) / 5.61742;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctRs_KartoSchm(
    double Tr,
    double Pr,
    double GamaO,
    double GamaG,
    double Pb,
    double Tsep,
    double Psep)
  {
    if (Pr > Pb)
      Pr = Pb;
    double num1 = (Tr + 273.16) * 1.8;
    double x1 = Tsep * 1.8 + 32.0;
    double x2 = Pr * 14.5038;
    double num2 = Psep * 14.5038;
    double num3;
    try
    {
      if (num1 > 0.0 && x2 > 0.0 && GamaO > 0.0 && GamaG > 0.0 && num2 > 0.0 && x1 > 0.0)
      {
        double x3 = 141.5 / GamaO - 131.5;
        double num4;
        double y1;
        double y2;
        double num5;
        if (x3 > 30.0)
        {
          num4 = 0.0315;
          y1 = 0.7587;
          y2 = 1.0937;
          num5 = 11.2895;
        }
        else
        {
          num4 = 0.05958;
          y1 = 0.7972;
          y2 = 1.0014;
          num5 = 13.1405;
        }
        double x4 = GamaG * (1.0 + 0.1595 * Math.Pow(x3, 0.4078) * Math.Pow(x1, -0.2466) * Math.Log(num2 / 114.7));
        num3 = num4 * Math.Pow(x4, y1) * Math.Pow(x2, y2) * Math.Pow(10.0, num5 * x3 / num1) / 5.61742;
      }
      else
        num3 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num3 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num3;
  }

  public static double FctRs_PetroFar(
    double Tr,
    double Pr,
    double GamaO,
    double GamaG,
    double Pb)
  {
    if (Pr > Pb)
      Pr = Pb;
    double x = Tr * 1.8 + 32.0;
    double num1 = Pr * 14.5038;
    double num2;
    try
    {
      if (x > 0.0 && num1 > 0.0 && GamaO > 0.0 && GamaG > 0.0)
      {
        double y = 0.0007916 * Math.Pow(141.5 / GamaO - 131.5, 1.541) - 4.561E-05 * Math.Pow(x, 1.3911);
        num2 = Math.Pow((num1 / 112.727 + 12.34) * Math.Pow(GamaG, 0.8439) * Math.Pow(10.0, y), 1.731847) / 5.61742;
      }
      else
        num2 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctRs_Lasater(
    double Tr,
    double Pr,
    double GamaO,
    double GamaG,
    double MwtO,
    double Pb)
  {
    if (Pr > Pb)
      Pr = Pb;
    double num1 = Tr + 273.16;
    double num2 = Pr * 100.0;
    double num3;
    try
    {
      if (num1 > 0.0 && num2 > 0.0 && GamaO > 0.0 && GamaG > 0.0 && MwtO > 0.0)
      {
        double num4 = num2 * GamaG / num1;
        double num5;
        if (num4 >= 40.7)
          num5 = Math.Pow(0.0098 * num4 - 0.236, 0.281);
        else if (0.1187 * num4 + 0.476 <= 1E-19)
        {
          num3 = 0.0;
          goto label_14;
        }
        else
          num5 = 0.359 * Math.Log(0.1187 * num4 + 0.476);
        double num6;
        if (num5 != 1.0)
          num6 = 23643.0 * GamaO * num5 / (MwtO * (1.0 - num5));
        num3 = num6 >= 0.0 ? num6 : 0.0;
      }
      else
        num3 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num3 = 0.0;
      ProjectData.ClearProjectError();
    }
label_14:
    return num3;
  }

  public static double FctVisOd_BeggRob(double Tr, double GamaO)
  {
    double x = Tr * 1.8 + 32.0;
    double num;
    try
    {
      num = GamaO <= 0.0 ? 0.0 : Math.Pow(10.0, Math.Pow(x, -1.163) * Math.Exp(13.108 - 6.591 / GamaO)) - 1.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctVisOd_Beal(double Tr, double GamaO)
  {
    double num1 = (Tr + 273.16) * 1.8;
    double num2;
    try
    {
      if (GamaO > 0.0 && num1 > 0.0 && num1 != 260.0)
      {
        double x = 141.5 / GamaO - 131.5;
        num2 = !(x == 0.0 | x < 1E-18) ? (0.32 + 18000000.0 / Math.Pow(x, 4.53)) * Math.Pow(360.0 / (num1 - 260.0), Math.Pow(10.0, 0.43 + 8.33 / x)) : 0.0;
      }
      else
        num2 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctVisO_BeggRob(
    double Pr,
    double Pb,
    double Rs,
    double RsPb,
    double VisOd)
  {
    double num;
    try
    {
      num = Pr <= 0.0 || Pb <= 0.0 || Rs <= 0.0 || RsPb <= 0.0 || VisOd <= 0.0 ? 0.0 : (Pr <= Pb ? Math.Pow(5.615 * Rs + 100.0, -0.515) * 10.715 * Math.Pow(VisOd, Math.Pow(5.615 * Rs + 150.0, -0.338) * 5.44) : Math.Pow(Pr / Pb, 0.263 * Math.Pow(Pr * 100.0, 1.187) * Math.Exp(-11.513 - 0.0013021 * Pr)) * Math.Pow(5.615 * RsPb + 100.0, -0.515) * 10.715 * Math.Pow(VisOd, Math.Pow(5.615 * RsPb + 150.0, -0.338) * 5.44));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctVisO_ChewCon(double Rs, double VisOd)
  {
    double num;
    try
    {
      num = Rs <= 0.0 || VisOd <= 0.0 ? 0.0 : (-0.211543 * Math.Log(Rs) + 1.491501) * Math.Pow(VisOd, 1.932111 * Math.Pow(Rs, -0.221414));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctCmpO(double Tr, double Pr, double Rs, double GamaO, double GamaG)
  {
    double num1 = Tr + 273.16;
    double num2;
    try
    {
      if (num1 > 0.0 && Pr > 0.0 && Rs > 0.0 && GamaO > 0.0 && GamaG > 0.0)
      {
        double num3 = (28.11 * Rs + 30.96 * num1 - 1.18 * GamaG + 1784.315 / GamaO - 9571.6483) / (Pr * 10000000.0);
        num2 = num3 <= 0.0 ? 1E-05 : num3;
      }
      else
        num2 = 1E-05;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 1E-05;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctBo_Stand(double Pr, double Pb, double Tr, double GamaO, double GamaG)
  {
    double num1 = Tr + 273.16;
    double num2;
    try
    {
      double Rs = clsPVTOil.FctRs_Stand(Tr, Pr, GamaO, GamaG, Pb);
      if (Rs == 0.0)
      {
        num2 = 0.0;
      }
      else
      {
        double num3 = 0.972 + 0.000147 * Math.Pow(5.615 * Rs * Math.Pow(GamaG / GamaO, 0.5) + 2.25 * (num1 - 255.555), 1.175);
        num2 = Pr < Pb ? num3 : num3 * Math.Exp(clsPVTOil.FctCmpO(Tr, Pr, Rs, GamaO, GamaG) * 100.0 * (Pb - Pr));
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctBo_VasBegg(double Pr, double Pb, double Tr, double GamaO, double GamaG)
  {
    double num1 = Tr + 273.16;
    double num2;
    try
    {
      double Rs = clsPVTOil.FctRs_VasBegg(Tr, Pr, GamaO, GamaG, Pb);
      if (Rs == 0.0)
      {
        num2 = 0.0;
      }
      else
      {
        double num3;
        double num4;
        double num5;
        if (GamaO <= 0.876)
        {
          num3 = 0.002622;
          num4 = 1.1E-05;
          num5 = 1.337E-09;
        }
        else
        {
          num3 = 0.002826;
          num4 = 1.751E-05;
          num5 = -1.811E-08;
        }
        double num6 = 254.7 * num1 / GamaO - 236.7 * num1 - 73580.0 / GamaO + 68380.0;
        double num7 = 1.0 + num3 * Rs + num6 * (num4 + num5 * Rs);
        num2 = Pr < Pb ? num7 : num7 * Math.Exp(clsPVTOil.FctCmpO(Tr, Pr, Rs, GamaO, GamaG) * 100.0 * (Pb - Pr));
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double fctBo_Glaso(double Pr, double Pb, double Tr, double GamaO, double GamaG)
  {
    double num1 = Tr + 273.16;
    double num2;
    try
    {
      double Rs = clsPVTOil.FctRs_Glaso(Tr, Pr, GamaO, GamaG, Pb);
      if (Rs == 0.0)
      {
        num2 = 0.0;
      }
      else
      {
        double d = 5.61 * Rs * Math.Pow(GamaG / GamaO, 0.526) + 1089.0 / 625.0 * num1 - 445.3;
        double num3 = 1.0 + Math.Pow(10.0, 2.91329 * (Math.Log(d) / Math.Log(10.0)) - 6.58511 - 0.27683 * Math.Pow(Math.Log(d) / Math.Log(10.0), 2.0));
        num2 = Pr < Pb ? num3 : num3 * Math.Exp(clsPVTOil.FctCmpO(Tr, Pr, Rs, GamaO, GamaG) * 100.0 * (Pb - Pr));
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctBo_MECO(double Pr, double Pb, double Tr, double GamaO, double GamaG)
  {
    double num1 = Tr + 273.16;
    double num2;
    try
    {
      double Rs = clsPVTOil.FctRs_MECO(Tr, Pr, GamaO, GamaG, Pb);
      if (Rs == 0.0)
      {
        num2 = 0.0;
      }
      else
      {
        double x = Math.Pow(5.61 * Rs, 0.74239) * Math.Pow(GamaG, 0.323294) * Math.Pow(GamaO, -0.20204);
        double num3 = 0.497069 + 0.00155333 * num1 + 0.00182594 * x + 3.18099E-06 * Math.Pow(x, 2.0);
        num2 = Pr < Pb ? num3 : num3 * Math.Exp(clsPVTOil.FctCmpO(Tr, Pr, Rs, GamaO, GamaG) * 100.0 * (Pb - Pr));
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctBo_KartoSchm(
    double Pr,
    double Pb,
    double Tr,
    double GamaO,
    double GamaG,
    double Tsep,
    double Psep)
  {
    double num1 = Tr * 1.8 + 32.0;
    double num2;
    try
    {
      double Rs = clsPVTOil.FctRs_KartoSchm(Tr, Pr, GamaO, GamaG, Pb, Tsep, Psep);
      if (Rs == 0.0)
      {
        num2 = 0.0;
      }
      else
      {
        double x1 = Tsep * 1.8 + 32.0;
        double num3 = Psep * 14.5038;
        double x2 = 141.5 / GamaO - 131.5;
        double x3 = GamaG * (1.0 + 0.1595 * Math.Pow(x2, 0.4078) * Math.Pow(x1, -0.2466) * Math.Log(num3 / 114.7));
        double num4 = 0.0001;
        double y1 = 0.755;
        double y2 = 0.25;
        double y3 = 1.5;
        double num5 = 0.45;
        double y4 = 1.5;
        double num6 = 0.98496 + num4 * Math.Pow(Math.Pow(Rs * 5.61742, y1) * (Math.Pow(x3, y2) / Math.Pow(GamaO, y3)) + num5 * num1, y4);
        num2 = Pr < Pb ? num6 : num6 * Math.Exp(clsPVTOil.FctCmpO(Tr, Pr, Rs, GamaO, GamaG) * 100.0 * (Pb - Pr));
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctBo_PetroFar(
    double Pr,
    double Pb,
    double Tr,
    double GamaO,
    double GamaG)
  {
    double x = Tr * 1.8 + 32.0;
    double num1;
    try
    {
      double Rs = clsPVTOil.FctRs_PetroFar(Tr, Pr, GamaO, GamaG, Pb);
      if (Rs == 0.0)
      {
        num1 = 0.0;
      }
      else
      {
        double num2 = 1.0113 + 7.2046000000000008E-05 * Math.Pow(Math.Pow(Rs * 5.61742, 0.3738) * Math.Pow(GamaG, 0.2914) / Math.Pow(GamaO, 0.6265) + 0.24626 * Math.Pow(x, 0.5371), 3.0936);
        num1 = Pr < Pb ? num2 : num2 * Math.Exp(clsPVTOil.FctCmpO(Tr, Pr, Rs, GamaO, GamaG) * 100.0 * (Pb - Pr));
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num1 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num1;
  }

  public static double FctDenO(
    double Pr,
    double Pb,
    double GamaO,
    double GamaG,
    double Rs,
    double RsPb,
    double Bo,
    double BoPb,
    double Co)
  {
    double num;
    try
    {
      num = Pr <= 0.0 || Pb <= 0.0 || GamaO <= 0.0 || GamaG <= 0.0 || Rs <= 0.0 || RsPb <= 0.0 || Bo <= 0.0 || BoPb <= 0.0 || Co <= 0.0 ? 0.0 : (Pr <= Pb ? (GamaO * 1000.0 + GamaG * 1.224 * Rs) / Bo : (GamaO * 1000.0 + GamaG * 1.224 * RsPb) / BoPb * Math.Exp(Co * 100.0 * (Pr - Pb)));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctSigmaO(double MwtO, double DenO, double DenG)
  {
    double num;
    try
    {
      num = MwtO <= 0.0 || DenO <= 0.0 || DenG <= 0.0 || DenO == DenG ? 0.0 : (MwtO > 100.0 ? Math.Pow((278.0 + 2.35 * (MwtO - 100.0)) / MwtO * (DenO - DenG) * 0.001, 4.0) : Math.Pow((40.0 + 2.38 * MwtO) / MwtO * (DenO - DenG) * 0.001, 4.0));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num = 0.0;
      ProjectData.ClearProjectError();
    }
    return num;
  }

  public static double FctBt_Gen(
    double Tr,
    double Pr,
    double Pb,
    double GamaO,
    double GamaG,
    double Rs,
    double RsPb,
    double Bo,
    double Z)
  {
    double num1 = Tr + 273.16;
    double num2 = Pr * 100.0;
    double num3;
    try
    {
      if (num1 > 0.0 && num2 > 0.0 && Pb > 0.0 && GamaO > 0.0 && GamaG > 0.0 && Rs > 0.0 && RsPb > 0.0 && Bo > 0.0 && Z > 0.0)
      {
        if (Pr > Pb)
        {
          num3 = Bo;
        }
        else
        {
          double num4 = 1.0 / 160.0 * Z * num1 / num2;
          if (GamaG * Math.Pow(num2 / (519.7 * Math.Pow(10.0, 1.225 + 0.00164 * num1 - 1.769 / GamaO)), 1.24) - Rs < 0.0)
          {
            num3 = Bo;
          }
          else
          {
            double num5 = RsPb - Rs;
            num3 = Bo + num4 * num5;
          }
        }
      }
      else
        num3 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num3 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num3;
  }

  public static double FctBt_Glaso(double Tr, double Pr, double GamaO, double GamaG, double Rs)
  {
    double x1 = Tr * 1.8 + 32.0;
    double x2 = Pr * 100.0;
    double num1;
    try
    {
      if (x1 > 0.0 && Pr > 0.0 && GamaO > 0.0 && GamaG > 0.0 && Rs > 0.0)
      {
        double num2 = Math.Pow(x1, 0.5) / Math.Pow(GamaG, 0.3);
        double d = 5.61 * Rs * num2 * 8.5081 * Math.Pow(x2, -1.1089) * Math.Pow(GamaO, 2.9 * Math.Pow(10.0, -4.8E-05 / Rs));
        num1 = Math.Pow(10.0, 0.080135 + 0.47257 * (Math.Log(d) / Math.Log(10.0)) + 0.17351 * Math.Pow(Math.Log(d) / Math.Log(10.0), 2.0));
      }
      else
        num1 = 0.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num1 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num1;
  }

  public static double fctBt_Meco(double Tr, double Pr, double GamaO, double GamaG, double Rs)
  {
    double x1 = (Tr + 273.16) * 1.8;
    double x2 = Pr * 14.5038;
    double num;
    try
    {
      if (x1 > 0.0 && x2 > 0.0 && GamaO > 0.0 && GamaG > 0.0 && Rs > 0.0)
      {
        double x3 = Math.Pow(5.61 * Rs, 0.644516) * Math.Pow(GamaG, -1.07934) * Math.Pow(GamaO, 0.724874) * Math.Pow(x1, 2.00621) * Math.Pow(x2, -0.76191);
        num = 0.314693 + 1.06253E-05 * x3 + 1.8883E-11 * Math.Pow(x3, 2.0);
      }
      else
        num = 0.0;
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
