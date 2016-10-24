// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.AccidentStats.AccidentDetail
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.AccidentStats
{
  [DataContract]
  public class AccidentDetail
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public double Lat { get; set; }

    [DataMember]
    public double Lon { get; set; }

    [DataMember]
    public string Location { get; set; }

    [DataMember]
    public DateTime Date { get; set; }

    [DataMember]
    public string Severity { get; set; }

    [DataMember]
    public string Borough { get; set; }

    [DataMember]
    public List<Casualty> Casualties { get; set; }

    [DataMember]
    public List<Vehicle> Vehicles { get; set; }
  }
}
