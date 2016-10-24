// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.CurrentForecast
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(IsReference = true, Name = "CurrentForecast", Namespace = "")]
  public class CurrentForecast
  {
    private string forecastText;

    [DataMember]
    [XmlAttribute]
    public string ForecastType { get; set; }

    [DataMember]
    [XmlAttribute]
    public string ForecastID { get; set; }

    [DataMember]
    [XmlIgnore]
    public DateTime? PublishedDate { get; set; }

    [IgnoreDataMember]
    [XmlAttribute]
    public string PublishedDateTime
    {
      get
      {
        if (this.PublishedDate.HasValue)
          return this.PublishedDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
      }
      set
      {
        DateTime result;
        this.PublishedDate = DateTime.TryParse(value, out result) ? new DateTime?(result.ToUniversalTime()) : new DateTime?();
      }
    }

    [XmlIgnore]
    [DataMember]
    public DateTime? FromDate { get; set; }

    [IgnoreDataMember]
    [XmlAttribute]
    public string ValidFrom
    {
      get
      {
        if (this.FromDate.HasValue)
          return this.FromDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
      }
      set
      {
        DateTime result;
        this.FromDate = DateTime.TryParse(value, out result) ? new DateTime?(result.ToUniversalTime()) : new DateTime?();
      }
    }

    [DataMember]
    [XmlIgnore]
    public DateTime? ToDate { get; set; }

    [IgnoreDataMember]
    [XmlAttribute]
    public string ValidTo
    {
      get
      {
        if (this.ToDate.HasValue)
          return this.ToDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
      }
      set
      {
        DateTime result;
        this.ToDate = DateTime.TryParse(value, out result) ? new DateTime?(result.ToUniversalTime()) : new DateTime?();
      }
    }

    [XmlAttribute]
    [DataMember]
    public string ForecastBand { get; set; }

    [DataMember]
    [XmlAttribute]
    public string ForecastSummary { get; set; }

    [DataMember]
    [XmlAttribute]
    public string NO2Band { get; set; }

    [XmlAttribute]
    [DataMember]
    public string O3Band { get; set; }

    [DataMember]
    [XmlAttribute]
    public string PM10Band { get; set; }

    [DataMember]
    [XmlAttribute]
    public string PM25Band { get; set; }

    [XmlAttribute]
    [DataMember]
    public string SO2Band { get; set; }

    [XmlAttribute]
    [DataMember]
    public string ForecastText
    {
      get
      {
        return HttpContext.Current.Server.HtmlEncode(this.forecastText);
      }
      set
      {
        this.forecastText = value;
      }
    }
  }
}
