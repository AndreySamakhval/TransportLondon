// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Place
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Web;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  [KnownType(typeof (StopPoint))]
  public class Place : Point, IIdentifiable
  {
    [DataMember(EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Url { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string CommonName { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public double Distance { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string PlaceType { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<Tfl.Api.Presentation.Entities.AdditionalProperties> AdditionalProperties { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public List<Place> Children { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public UrlList ChildrenUrls { get; set; }

    public Place()
    {
    }

    public Place(string commonName, double lat, double lon)
      : base(lat, lon)
    {
      this.CommonName = commonName;
    }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id,
        Name = this.CommonName,
        Type = typeof (Place).Name,
        Uri = string.Format("/Place/{0}", (object) HttpUtility.UrlEncode(this.Id))
      };
    }
  }
}
