// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.Point
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class Point
  {
    public string Name { get; set; }

    public string ShortName { get; set; }

    public string StopId { get; set; }

    public string Type { get; set; }

    public string Usage { get; set; }

    public DateTime AssociatedTime { get; set; }

    public bool HasStaticInfo { get; set; }

    public IEnumerable<MapItem> Maps { get; set; }

    public IEnumerable<Mode> Modes { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public string Area { get; set; }

    public int MatchQuality { get; set; }

    public string FullName { get; set; }
  }
}
