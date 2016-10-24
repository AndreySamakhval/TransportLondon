// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.Location
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class Location
  {
    public string Name { get; set; }

    public string Region { get; set; }

    public bool? DeleteAssignedStops { get; set; }

    public string PlaceDefaultText { get; set; }
  }
}
