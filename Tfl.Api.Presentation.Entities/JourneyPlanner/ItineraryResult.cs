﻿// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.ItineraryResult
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  [DataContract]
  public class ItineraryResult : JourneyResult
  {
    [DataMember]
    public List<Journey> Journeys { get; set; }

    [DataMember]
    public List<Line> Lines { get; set; }

    [DataMember]
    public JourneyPlannerCycleHireDockingStationData CycleHireDockingStationData { get; set; }

    [DataMember]
    public List<string> StopMessages { get; set; }
  }
}
