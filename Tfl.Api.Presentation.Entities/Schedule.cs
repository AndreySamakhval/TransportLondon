// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Schedule
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class Schedule
  {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public List<KnownJourney> KnownJourneys { get; set; }

    [DataMember]
    public KnownJourney FirstJourney { get; set; }

    [DataMember]
    public KnownJourney LastJourney { get; set; }

    [DataMember]
    public List<Period> Periods { get; set; }

    public Schedule()
    {
      this.Periods = new List<Period>();
      this.KnownJourneys = new List<KnownJourney>();
      this.FirstJourney = new KnownJourney();
      this.LastJourney = new KnownJourney();
    }
  }
}
