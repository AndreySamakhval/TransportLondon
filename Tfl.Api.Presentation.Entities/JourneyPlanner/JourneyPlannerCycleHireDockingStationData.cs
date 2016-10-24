// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.JourneyPlannerCycleHireDockingStationData
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class JourneyPlannerCycleHireDockingStationData
  {
    public int OriginNumberOfBikes { get; set; }

    public int DestinationNumberOfBikes { get; set; }

    public int OriginNumberOfEmptySlots { get; set; }

    public int DestinationNumberOfEmptySlots { get; set; }

    public string OriginId { get; set; }

    public string DestinationId { get; set; }
  }
}
