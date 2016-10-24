// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.TimetableRoute
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  public class TimetableRoute
  {
    [DataMember]
    public List<StationInterval> StationIntervals { get; set; }

    [DataMember]
    public List<Schedule> Schedules { get; set; }

    public TimetableRoute()
    {
      this.StationIntervals = new List<StationInterval>();
      this.Schedules = new List<Schedule>();
    }
  }
}
