// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.Path
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
//using Tfl.Api.Common.JourneyPlanner;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class Path
  {
    public string LineString { get; set; }

    public IEnumerable<Identifier> StopPoints { get; set; }

   // public List<JpElevation> Elevation { get; set; }

    public Path()
    {
      this.StopPoints = (IEnumerable<Identifier>) new List<Identifier>();
    }
  }
}
