// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.PartialRoute
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class PartialRoute
  {
    public Point Origin { get; set; }

    public Point Destination { get; set; }

    public MeansOfTransport MeansOfTransport { get; set; }

    public IEnumerable<Disruption> Disruptions { get; set; }

    public IEnumerable<PlannedWork> PlannedWorks { get; set; }

    public IEnumerable<Point> StopSequence { get; set; }

    public string Type { get; set; }

    public IEnumerable<Tfl.Api.Presentation.Entities.JourneyPlanner.FootPathElement> FootPathElement { get; set; }

    public IEnumerable<MeansOfTransport> MeansOfTransportOptions { get; set; }
  }
}
