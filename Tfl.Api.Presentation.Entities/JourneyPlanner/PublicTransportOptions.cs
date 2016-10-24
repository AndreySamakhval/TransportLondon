// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.PublicTransportOptions
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

//using Tfl.Api.Common;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class PublicTransportOptions
  {
    public int MaxChanges { get; set; }

    //public RouteType RouteType { get; set; }

    public PublicTransportOptions()
    {
      this.MaxChanges = 9;
    }
  }
}
