// Decompiled with JetBrains decompiler
// Type: clsPVTGas
// Assembly: CMSPVT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 201CCC60-7B31-408F-B41C-5D93C51866A1
// Assembly location: C:\Users\Sai Krishna\Downloads\CMSPVT.dll

using Microsoft.VisualBasic.CompilerServices;
using System;

public class clsPVTGas
{
  public static double FctRsPbCor(
    double GORp,
    double SpegO,
    double SpegG,
    double Psep,
    double Tsep)
  {
    double d1 = Tsep * 1.8 + 32.0;
    double d2 = Psep * 14.5038;
    double num1 = Math.Log(10.0);
    double num2;
    try
    {
      num2 = GORp <= 0.0 ? 0.0 : (SpegO <= 0.0 || SpegG <= 0.0 || d2 <= 0.0 || d1 <= 0.0 ? GORp : GORp + Math.Pow(10.0, 306.0 / 625.0 - 4.916 * Math.Log(SpegO) / num1 + 3.469 * Math.Log(SpegG) / num1 + 1.501 * Math.Log(d2) / num1 - 0.9213 * Math.Log(d1) / num1) / 5.61742);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num2 = 0.0;
      ProjectData.ClearProjectError();
    }
    return num2;
  }

  public static double FctZ_Stand(double Pr, double Tr, double GamaG)
  {
    double num1 = (Tr + 273.16) * 1.8;
    double num2 = Pr * 14.5038;
    double num3;
    if (GamaG == 0.0)
    {
      num3 = 1.0;
    }
    else
    {
      double[,] numArray1 = new double[20, 21]
      {
        {
          0.0,
          1.058,
          1.0,
          0.868,
          0.746,
          0.588,
          0.443,
          0.353,
          0.266,
          0.256,
          0.251,
          0.26,
          0.281,
          0.343,
          0.407,
          0.534,
          0.664,
          0.904,
          1.23,
          1.753,
          2.23
        },
        {
          0.0,
          1.048,
          1.0,
          0.889,
          0.785,
          0.669,
          0.579,
          0.53,
          0.48,
          0.426,
          0.394,
          0.371,
          0.37,
          0.394,
          0.441,
          0.56,
          0.672,
          0.897,
          1.21,
          1.72,
          2.27
        },
        {
          0.0,
          1.041,
          1.0,
          0.901,
          0.819,
          0.733,
          0.672,
          0.64,
          0.605,
          0.571,
          0.541,
          0.497,
          0.467,
          0.451,
          0.49,
          0.582,
          0.683,
          0.893,
          1.193,
          1.682,
          2.18
        },
        {
          0.0,
          1.04,
          1.0,
          0.916,
          0.85,
          0.779,
          0.731,
          0.707,
          0.682,
          0.658,
          0.634,
          0.592,
          0.554,
          0.519,
          0.535,
          0.608,
          0.694,
          0.891,
          1.176,
          1.645,
          2.11
        },
        {
          0.0,
          1.036,
          1.0,
          0.928,
          0.871,
          0.812,
          0.773,
          0.753,
          0.732,
          0.71,
          0.691,
          0.656,
          0.626,
          0.582,
          0.582,
          0.633,
          0.71,
          0.889,
          1.164,
          1.616,
          2.09
        },
        {
          0.0,
          1023.0 / 1000.0,
          1.0,
          0.934,
          0.885,
          0.837,
          0.804,
          0.789,
          0.773,
          0.757,
          0.743,
          0.712,
          0.687,
          0.638,
          0.625,
          0.653,
          0.721,
          0.891,
          1.152,
          1.588,
          2.02
        },
        {
          0.0,
          1.029,
          1.0,
          0.942,
          0.898,
          0.856,
          0.829,
          0.817,
          0.803,
          0.791,
          0.779,
          0.755,
          0.732,
          0.688,
          0.669,
          0.687,
          0.742,
          0.896,
          1.145,
          1.558,
          2.0
        },
        {
          0.0,
          1.033,
          1.0,
          0.949,
          0.911,
          0.875,
          0.85,
          0.839,
          0.828,
          0.817,
          0.805,
          0.784,
          0.766,
          0.728,
          0.707,
          0.715,
          0.761,
          0.904,
          1.14,
          1.529,
          1.93
        },
        {
          0.0,
          1.014,
          1.0,
          0.953,
          0.921,
          0.889,
          0.869,
          0.859,
          0.85,
          0.841,
          0.832,
          0.815,
          0.799,
          0.765,
          0.745,
          0.746,
          0.787,
          0.914,
          1.135,
          1.508,
          1.85
        },
        {
          0.0,
          1021.0 / 1000.0,
          1.0,
          0.959,
          0.93,
          0.902,
          0.884,
          0.876,
          0.868,
          0.859,
          0.851,
          0.837,
          0.824,
          0.796,
          0.777,
          0.776,
          0.811,
          0.924,
          1.131,
          1.493,
          1.81
        },
        {
          0.0,
          1.016,
          1.0,
          0.968,
          0.945,
          0.924,
          0.909,
          0.901,
          0.895,
          0.889,
          0.882,
          0.871,
          0.861,
          0.84,
          0.825,
          0.818,
          0.847,
          0.945,
          1.13,
          1.47,
          1.76
        },
        {
          0.0,
          1013.0 / 1000.0,
          1.0,
          0.975,
          0.958,
          0.941,
          0.931,
          0.925,
          0.92,
          0.915,
          0.91,
          0.9,
          0.893,
          0.876,
          0.865,
          0.856,
          0.879,
          0.965,
          1.132,
          1.442,
          1.68
        },
        {
          0.0,
          1.01,
          1.0,
          0.98,
          0.967,
          0.953,
          0.945,
          0.941,
          0.938,
          0.934,
          0.93,
          0.924,
          0.918,
          0.904,
          0.896,
          0.892,
          0.912,
          0.988,
          1.136,
          1.424,
          1.66
        },
        {
          0.0,
          1009.0 / 1000.0,
          1.0,
          0.983,
          0.973,
          0.961,
          0.955,
          0.952,
          0.949,
          0.946,
          0.943,
          0.939,
          0.933,
          0.924,
          0.918,
          0.916,
          0.935,
          1.004,
          1.141,
          1.406,
          1.62
        },
        {
          0.0,
          1007.0 / 1000.0,
          1.0,
          0.987,
          0.978,
          0.97,
          0.964,
          0.962,
          0.96,
          0.957,
          0.954,
          0.95,
          0.947,
          0.941,
          0.938,
          0.939,
          0.955,
          1.02,
          1.143,
          1.39,
          1.51
        },
        {
          0.0,
          1009.0 / 1000.0,
          1.0,
          0.992,
          0.986,
          0.981,
          0.978,
          0.977,
          0.975,
          0.974,
          0.972,
          0.97,
          0.968,
          0.963,
          0.962,
          0.968,
          0.988,
          1.044,
          1.156,
          1.362,
          1.47
        },
        {
          0.0,
          1.002,
          1.0,
          0.996,
          0.992,
          0.989,
          0.987,
          0.987,
          0.986,
          0.985,
          0.984,
          0.983,
          0.982,
          0.98,
          0.981,
          0.99,
          1.012,
          1.062,
          1.158,
          1.347,
          1.42
        },
        {
          0.0,
          1001.0 / 1000.0,
          1.0,
          0.998,
          0.997,
          0.996,
          0.996,
          0.996,
          0.996,
          0.995,
          0.995,
          0.995,
          0.995,
          0.995,
          0.997,
          1007.0 / 1000.0,
          1.027,
          1.073,
          1.162,
          1.34,
          1.45
        },
        {
          0.0,
          1.0,
          1.0,
          1.0,
          1001.0 / 1000.0,
          1001.0 / 1000.0,
          1.002,
          1.002,
          1.002,
          1003.0 / 1000.0,
          1003.0 / 1000.0,
          1.004,
          1.006,
          1009.0 / 1000.0,
          1.012,
          1023.0 / 1000.0,
          1.039,
          1.081,
          1.164,
          1.336,
          1.43
        },
        {
          0.0,
          0.999,
          1.0,
          1.002,
          1.004,
          1007.0 / 1000.0,
          1.008,
          1009.0 / 1000.0,
          1.01,
          1.01,
          1011.0 / 1000.0,
          1.012,
          1.014,
          1019.0 / 1000.0,
          1.024,
          1.035,
          1.049,
          1.086,
          1.167,
          1.333,
          1.44
        }
      };
      double[] numArray2 = new double[21]
      {
        0.0,
        -0.2,
        0.0,
        0.4,
        0.7,
        1.0,
        1.2,
        1.3,
        1.4,
        1.5,
        1.6,
        1.8,
        2.0,
        2.5,
        3.0,
        4.0,
        5.0,
        7.0,
        10.0,
        15.0,
        20.0
      };
      double[] numArray3 = new double[21]
      {
        0.0,
        1.05,
        1.1,
        1.15,
        1.2,
        1.25,
        1.3,
        1.35,
        1.4,
        1.45,
        1.5,
        1.6,
        1.7,
        1.8,
        1.9,
        2.0,
        2.2,
        2.4,
        2.6,
        2.8,
        3.0
      };
      double num4 = num1 / (175.59 + 307.97 * GamaG);
      double num5 = (num2 + 14.696) / (700.55 - 47.94 * GamaG);
      if (num4 >= 1.05)
      {
        int index1 = 0;
        while (num4 > numArray3[index1])
        {
          checked { ++index1; }
          if (index1 > 19)
            goto label_21;
        }
        if (num5 > 0.0)
        {
          double num6 = (num4 - numArray3[checked (index1 - 1)]) / (numArray3[index1] - numArray3[checked (index1 - 1)]);
          int index2 = 2;
          while (num5 >= numArray2[index2])
          {
            if (num5 == numArray2[index2])
            {
              int index3 = checked (index1 - 1);
              double num7 = (numArray1[index3, index2] - numArray1[checked (index3 - 1), index2]) * num6 + numArray1[checked (index3 - 1), index2];
              if (num7 < 0.0)
                num7 = 0.1;
              if (num7 > 3.0)
                num7 = 3.0;
              num3 = num7;
              goto label_26;
            }
            else
            {
              checked { ++index2; }
              if (index2 > 18)
                goto label_21;
            }
          }
          int index4 = checked (index1 - 1);
          double num8 = (numArray1[index4, checked (index2 - 2)] - numArray1[checked (index4 - 1), checked (index2 - 2)]) * num6 + numArray1[checked (index4 - 1), checked (index2 - 2)];
          double num9 = (numArray1[index4, checked (index2 - 1)] - numArray1[checked (index4 - 1), checked (index2 - 1)]) * num6 + numArray1[checked (index4 - 1), checked (index2 - 1)];
          double num10 = (numArray1[index4, index2] - numArray1[checked (index4 - 1), index2]) * num6 + numArray1[checked (index4 - 1), index2];
          double num11 = (numArray1[index4, checked (index2 + 1)] - numArray1[checked (index4 - 1), checked (index2 + 1)]) * num6 + numArray1[checked (index4 - 1), checked (index2 + 1)];
          double num12 = (num5 - numArray2[checked (index2 - 1)]) * (num5 - numArray2[index2]) * (num5 - numArray2[checked (index2 + 1)]) / ((numArray2[checked (index2 - 2)] - numArray2[checked (index2 - 1)]) * (numArray2[checked (index2 - 2)] - numArray2[index2]) * (numArray2[checked (index2 - 2)] - numArray2[checked (index2 + 1)]));
          double num13 = num8 * num12 + num9 * ((num5 - numArray2[checked (index2 - 2)]) * (num5 - numArray2[index2]) * (num5 - numArray2[checked (index2 + 1)]) / ((numArray2[checked (index2 - 2)] - numArray2[checked (index2 - 1)]) * (numArray2[checked (index2 - 1)] - numArray2[index2]) * (numArray2[checked (index2 - 1)] - numArray2[checked (index2 + 1)]))) * -1.0 + num10 * ((num5 - numArray2[checked (index2 - 2)]) * (num5 - numArray2[checked (index2 - 1)]) * (num5 - numArray2[checked (index2 + 1)]) / ((numArray2[checked (index2 - 2)] - numArray2[index2]) * (numArray2[checked (index2 - 1)] - numArray2[index2]) * (numArray2[index2] - numArray2[checked (index2 + 1)]))) + num11 * ((num5 - numArray2[checked (index2 - 2)]) * (num5 - numArray2[checked (index2 - 1)]) * (num5 - numArray2[index2]) / ((numArray2[checked (index2 - 2)] - numArray2[checked (index2 + 1)]) * (numArray2[checked (index2 - 1)] - numArray2[checked (index2 + 1)]) * (numArray2[index2] - numArray2[checked (index2 + 1)]))) * -1.0;
          if (num13 < 0.0)
            num13 = 0.1;
          if (num13 > 3.0)
            num13 = 3.0;
          num3 = num13;
          goto label_26;
        }
      }
label_21:
      double num14 = 1.0 - 2.0 * (num4 - 1.3);
      double num15 = 1.0 - 6.0 * (num4 - 1.3) + 6.0 * Math.Pow(num4 - 1.3, 2.0);
      double num16 = 1.0 - 12.0 * (num4 - 1.3) + 30.0 * Math.Pow(num4 - 1.3, 2.0) - 20.0 * Math.Pow(num4 - 1.3, 3.0);
      double num17 = 1.06548 - 0.047613 * num14 - 0.010183 * num15 + 0.001455 * num16;
      double num18 = -0.283647 - 0.113977 * num14 - 0.044694 * num15 - 0.012622 * num16;
      double num19 = 0.142002 + 0.07989 * num14 + 0.008382 * num15 - 0.004143 * num16;
      double num20 = 0.073884 + 0.06832 * num14 + 0.031096 * num15 + 3.0 / 400.0 * num16;
      double num21 = 1.0 - 2.0 * (num5 / 15.0);
      double num22 = 1.0 - 6.0 * (num5 / 15.0) + 6.0 * Math.Pow(num5 / 15.0, 2.0);
      double num23 = 1.0 - 12.0 * (num5 / 15.0) + 30.0 * Math.Pow(num5 / 15.0, 2.0) - 20.0 * Math.Pow(num5 / 15.0, 3.0);
      double num24 = num18 * num21;
      double num25 = num17 + num24 + num19 * num22 + num20 * num23;
      if (num25 <= 0.0)
        num25 = 0.1;
      if (num25 > 3.0)
        num25 = 3.0;
      num3 = num25;
    }
label_26:
    return num3;
  }

  public static double FctZ_BB(double Pr, double Tr, double Ppc, double Tpc)
  {
    double num1;
    try
    {
      if (Pr > 0.0 && Tr > 0.0 && Ppc > 0.0 && Tpc + 273.16 > 0.0)
      {
        double num2 = clsPVTGas.FctTpr(Tr, Tpc);
        if (num2 < 1.0)
          num2 = 1.0;
        double x = clsPVTGas.FctPpr(Pr, Ppc);
        if (x == 0.0)
        {
          num1 = 1.0;
        }
        else
        {
          double num3 = 1.39 * Math.Sqrt(num2 - 0.92) - 0.36 * num2 - 0.101;
          double d = (0.62 - 0.23 * num2) * x + (0.066 / (num2 - 0.86) - 0.037) * Math.Pow(x, 2.0) + 0.32 * Math.Pow(10.0, -9.0 * num2 + 9.0) * Math.Pow(x, 6.0);
          double num4 = 0.132 - 0.32 * Math.Log(num2) / Math.Log(10.0);
          double y = Math.Pow(10.0, 0.3106 - 0.49 * num2 + 114.0 / 625.0 * Math.Pow(num2, 2.0));
          double num5 = num3 + (1.0 - num3) / Math.Exp(d) + num4 * Math.Pow(x, y);
          if (num5 <= 0.0)
            num5 = 0.1;
          if (num5 > 3.0)
            num5 = 3.0;
          num1 = num5;
        }
      }
      else
        num1 = 1.0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      num1 = 1.0;
      ProjectData.ClearProjectError();
    }
    return num1;
  }

  public static double FctZ_HY(double Pr, double Tr, double Ppc, double Tpc)
  {
    double num1 = clsPVTGas.FctTpr(Tr, Tpc);
    double num2 = clsPVTGas.FctPpr(Pr, Ppc);
    double num3;
    if (!(num1 == 0.0 | num2 == 0.0))
    {
      if (num1 < 1.0)
        num1 = 1.0;
      if (!(num1 < 0.92 | Math.Abs(num1 - 0.86) <= 1E-11))
      {
        double num4 = -49.0 / 800.0 / num1 * Math.Exp(-1.2 * Math.Pow(1.0 - 1.0 / num1, 2.0)) * num2;
        double num5 = 14.76 / num1 - 9.76 * Math.Pow(1.0 / num1, 2.0) + 4.58 * Math.Pow(1.0 / num1, 3.0);
        double num6 = 90.7 / num1 - 242.2 * Math.Pow(1.0 / num1, 2.0) + 42.4 * Math.Pow(1.0 / num1, 3.0);
        double y = 2.18 + 2.82 * (1.0 / num1);
        int num7 = 1;
        double x = 0.001;
        while (num7 < 16)
        {
          double num8 = (x + Math.Pow(x, 2.0) + Math.Pow(x, 3.0) - Math.Pow(x, 4.0)) / Math.Pow(1.0 - x, 3.0) - num5 * Math.Pow(x, 2.0) + num4 + num6 * Math.Pow(x, y);
          double num9 = ((1.0 + 2.0 * x + 3.0 * Math.Pow(x, 2.0) - 4.0 * Math.Pow(x, 3.0)) * (1.0 - x) + 3.0 * (x + Math.Pow(x, 2.0) + Math.Pow(x, 3.0) - Math.Pow(x, 4.0))) / Math.Pow(1.0 - x, 4.0) - 2.0 * num5 * x + num6 * y * Math.Pow(x, y - 1.0);
          if (Math.Abs(num9) > 1E-11)
          {
            double num10 = x - num8 / num9;
            if (Math.Abs(num10 - x) > 1E-05)
            {
              checked { ++num7; }
              x = num10;
            }
            else
              break;
          }
          else
            break;
        }
        double num11 = -num4 / x;
        if (num11 <= 0.0)
          num11 = 0.1;
        if (num11 > 3.0)
          num11 = 3.0;
        num3 = num11;
        goto label_15;
      }
    }
    num3 = 1.0;
label_15:
    return num3;
  }

  public static double FctVisG(double Tr, double Pr, double GamaG)
  {
    double num1 = clsPVTGas.FctTpr(Tr, clsPVTGas.FctTpc(GamaG));
    double num2 = clsPVTGas.FctPpr(Pr, clsPVTGas.FctPpc(GamaG));
    double num3;
    try
    {
      if (num1 > 0.0 && num2 > 0.0 && GamaG > 0.0)
      {
        double num4 = Tr * 1.8 + 32.0;
        double num5 = num2 * (2.970547 + num2 * (0.00805420522 * num2 - 0.286264054)) - 2.4621182;
        double num6 = 2.80860949 + num2 * (num2 * (0.3603732 - 0.01044324 * num2) - 3.49803305);
        double num7 = num2 * (1.39643306 + num2 * (0.00441015512 * num2 - 0.149144925)) - 0.793385684;
        double num8 = 0.0839387178 + num2 * (num2 * (0.02033677881 - 0.000609579263 * num2) - 0.186408848);
        double num9 = num1 * Math.Exp(num5 + num1 * (num6 + num1 * (num7 + num8 * num1)));
        num3 = num9 == 0.0 ? 0.0 : ((1.709E-05 - 2.062E-06 * GamaG) * num4 + (0.008178 - 0.00615 * Math.Log(GamaG) / Math.Log(10.0))) / num9;
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

  public static double FctVisGcor(
    double Tr,
    double Pr,
    double GamaG,
    double Ppc,
    double Tpc,
    double N2cor,
    double CO2cor,
    double H2Scor)
  {
    double num1 = clsPVTGas.FctTpr(Tr, Tpc);
    double num2 = clsPVTGas.FctPpr(Pr, Ppc);
    double num3;
    try
    {
      if (num1 > 0.0 && num2 > 0.0 && GamaG > 0.0)
      {
        double num4 = Tr * 1.8 + 32.0;
        double num5 = (1.709E-05 - 2.062E-06 * GamaG) * num4 + (0.008178 - 0.00615 * Math.Log(GamaG) / Math.Log(10.0)) + N2cor + CO2cor + H2Scor;
        double num6 = num2 * (2.970547 + num2 * (0.00805420522 * num2 - 0.286264054)) - 2.4621182;
        double num7 = 2.80860949 + num2 * (num2 * (0.3603732 - 0.01044324 * num2) - 3.49803305);
        double num8 = num2 * (1.39643306 + num2 * (0.00441015512 * num2 - 0.149144925)) - 0.793385684;
        double num9 = 0.0839387178 + num2 * (num2 * (0.02033677881 - 0.000609579263 * num2) - 0.186408848);
        double num10 = num1 * Math.Exp(num6 + num1 * (num7 + num1 * (num8 + num9 * num1)));
        num3 = num10 == 0.0 ? 0.0 : num5 / num10;
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

  public static double FctBg(double Tr, double Pr, double Z)
  {
    double num1 = (Tr + 273.16) * 1.8;
    double num2 = Pr * 14.5038;
    return num2 <= 0.0 || num1 <= 0.0 || Z <= 0.0 ? 0.0 : 0.005035 * num1 * Z / num2;
  }

  public static double fctDenG(double Tr, double Pr, double Z, double GamaG)
  {
    double num = Tr + 273.16;
    return num <= 0.0 || Pr <= 0.0 || Z <= 0.0 ? 0.0 : 348.4815 * Pr * GamaG / (Z * num);
  }

  public static double FctPpc(double GamaG) => GamaG <= 0.0 ? 0.0 : 46.677 + GamaG * (1.0342 - 2.5855 * GamaG);

  public static double FctTpc(double GamaG) => GamaG <= 0.0 ? 0.0 : 93.3333333 + GamaG * (180.555 - 6.944 * GamaG) - 273.16;

  public static double FctPpr(double Pr, double Ppc) => Pr <= 0.0 || Ppc <= 0.0 ? 0.0 : Pr / Ppc;

  public static double FctTpr(double Tr, double Tpc)
  {
    double num1 = Tr + 273.16;
    double num2 = Tpc + 273.16;
    return num1 <= 0.0 || num2 <= 0.0 ? 0.0 : num1 / num2;
  }

  public static double FctMwtG(double GamaG) => GamaG <= 0.0 ? 0.0 : GamaG * 28.966;

  public static double FctMwtC(double GamaC) => GamaC <= 0.0 || GamaC >= 1.03 ? 0.0 : 44.29 * GamaC / (1.03 - GamaC);
}
