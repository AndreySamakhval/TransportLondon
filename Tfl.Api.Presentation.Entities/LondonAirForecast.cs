// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.LondonAirForecast
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(IsReference = true, Name = "LondonAirForecast", Namespace = "")]
  public class LondonAirForecast
  {
    [DataMember]
    [XmlElement]
    public string UpdatePeriod { get; set; }

    [XmlElement]
    [DataMember]
    public string UpdateFrequency { get; set; }

    [XmlElement]
    [DataMember]
    public string ForecastURL { get; set; }

    [XmlElement]
    [DataMember]
    public string DisclaimerText { get; set; }

    [XmlElement]
    [DataMember]
    public List<Tfl.Api.Presentation.Entities.CurrentForecast> CurrentForecast { get; set; }
  }
}
