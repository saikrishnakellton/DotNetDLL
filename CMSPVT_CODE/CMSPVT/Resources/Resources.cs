// Decompiled with JetBrains decompiler
// Type: My.Resources.Resources
// Assembly: CMSPVT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 201CCC60-7B31-408F-B41C-5D93C51866A1
// Assembly location: C:\Users\Sai Krishna\Downloads\CMSPVT.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace My.Resources
{
  [StandardModule]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [HideModuleName]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) My.Resources.Resources.resourceMan, (object) null))
          My.Resources.Resources.resourceMan = new ResourceManager(nameof (Resources), typeof (My.Resources.Resources).Assembly);
        return My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => My.Resources.Resources.resourceCulture;
      set => My.Resources.Resources.resourceCulture = value;
    }
  }
}
