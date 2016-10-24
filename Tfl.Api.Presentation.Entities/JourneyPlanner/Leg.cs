// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.Leg
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class Leg
  {
    public int Duration { get; set; }

    public string Speed { get; set; }

    public Instruction Instruction { get; set; }

    public IEnumerable<Obstacle> Obstacles { get; set; }

    public DateTime DepartureTime { get; set; }

    public DateTime ArrivalTime { get; set; }

    public Tfl.Api.Presentation.Entities.Point DeparturePoint { get; set; }

    public Tfl.Api.Presentation.Entities.Point ArrivalPoint { get; set; }

    public Path Path { get; set; }

    public IEnumerable<RouteOption> RouteOptions { get; set; }

    public Identifier Mode { get; set; }

    public IEnumerable<Disruption> Disruptions { get; set; }

    public IEnumerable<PlannedWork> PlannedWorks { get; set; }

    public double? Distance { get; set; }

    public bool IsDisrupted
    {
      get
      {
        if (this.Disruptions != null)
          return this.Disruptions.Any<Disruption>();
        return false;
      }
    }

    public bool HasFixedLocations
    {
      get
      {
        if (this.DeparturePoint is StopPoint)
          return this.ArrivalPoint is StopPoint;
        return false;
      }
    }
  }
}
