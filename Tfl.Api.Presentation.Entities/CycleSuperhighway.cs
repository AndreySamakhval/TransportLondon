// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.CycleSuperhighway
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using Newtonsoft.Json;
using System;
using System.Data.Spatial;
using System.Runtime.Serialization;
using System.Web;
//using Tfl.Api.Common;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(IsReference = true)]
  public class CycleSuperhighway : IGeoData, IIdentifiable
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string Label { get; set; }

    [DataMember]
    public string LabelShort { get; set; }

   // [JsonConverter(typeof (DbGeographyGeoJsonConverter))]
    [DataMember(EmitDefaultValue = false)]
    public DbGeography Geography { get; set; }

    [DataMember]
    public bool Segmented { get; set; }

    [DataMember]
    public DateTime? Modified { get; set; }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id,
        Name = this.LabelShort + ":" + this.Label,
        Type = typeof (CycleSuperhighway).Name,
        Uri = string.Format("/CycleSuperhighway/{0}", (object) HttpUtility.UrlEncode(this.Id))
      };
    }
  }
}
