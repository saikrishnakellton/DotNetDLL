// Decompiled with JetBrains decompiler
// Type: My.MySettingsProperty
// Assembly: CMSPVT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 201CCC60-7B31-408F-B41C-5D93C51866A1
// Assembly location: C:\Users\Sai Krishna\Downloads\CMSPVT.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace My
{
  [StandardModule]
  [HideModuleName]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings => MySettings.Default;
  }
}
