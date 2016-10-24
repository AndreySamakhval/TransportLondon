// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.WebCAT.Ptai
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.WebCAT
{
  [DataContract(IsReference = true)]
  public class Ptai
  {
    [DataMember]
    public int PtalGridId { get; set; }

    [DataMember]
    public int X { get; set; }

    [DataMember]
    public int Y { get; set; }

    [DataMember]
    public int Node { get; set; }

    [DataMember]
    public string StopName { get; set; }

    [DataMember]
    public string Mode { get; set; }

    [DataMember]
    public string RouteCode { get; set; }

    [DataMember]
    public string Route { get; set; }

    [DataMember]
    public double Distm { get; set; }

    [DataMember]
    public double VehiclesPerHour { get; set; }

    [DataMember]
    public double Weight { get; set; }

    [DataMember]
    public double WalkTime { get; set; }

    [DataMember]
    public double Swt { get; set; }

    [DataMember]
    public double Tat { get; set; }

    [DataMember]
    public double Edf { get; set; }

    [DataMember]
    public double AI { get; set; }

    [DataMember]
    public string PtalValue { get; set; }
  }
}
