// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.Journey
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class Journey
  {
    public DateTime StartDateTime { get; set; }

    public int Duration { get; set; }

    public DateTime ArrivalDateTime { get; set; }

    public List<Leg> Legs { get; set; }
  }
}
