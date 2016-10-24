// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.SearchMatch
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [KnownType(typeof (ContentSearchMatch))]
  [KnownType(typeof (PlaceSearchMatch))]
  [KnownType(typeof (MatchedStop))]
  [KnownType(typeof (RouteSearchMatch))]
  [KnownType(typeof (AddressMatch))]
  [DataContract]
  public class SearchMatch
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string Url { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public double? Lat { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public double? Lon { get; set; }
  }
}
