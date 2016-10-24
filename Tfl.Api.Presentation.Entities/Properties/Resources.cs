// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Properties.Resources
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Tfl.Api.Presentation.Entities.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Tfl.Api.Presentation.Entities.Properties.Resources.resourceMan, (object) null))
          Tfl.Api.Presentation.Entities.Properties.Resources.resourceMan = new ResourceManager("Tfl.Api.Presentation.Entities.Properties.Resources", typeof (Tfl.Api.Presentation.Entities.Properties.Resources).Assembly);
        return Tfl.Api.Presentation.Entities.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Tfl.Api.Presentation.Entities.Properties.Resources.resourceCulture;
      }
      set
      {
        Tfl.Api.Presentation.Entities.Properties.Resources.resourceCulture = value;
      }
    }

    internal static string stopBlocking
    {
      get
      {
        return Tfl.Api.Presentation.Entities.Properties.Resources.ResourceManager.GetString("stopBlocking", Tfl.Api.Presentation.Entities.Properties.Resources.resourceCulture);
      }
    }

    internal static string stopInfo
    {
      get
      {
        return Tfl.Api.Presentation.Entities.Properties.Resources.ResourceManager.GetString("stopInfo", Tfl.Api.Presentation.Entities.Properties.Resources.resourceCulture);
      }
    }

    internal Resources()
    {
    }
  }
}
