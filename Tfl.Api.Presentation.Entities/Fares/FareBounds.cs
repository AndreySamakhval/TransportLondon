// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.FareBounds
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.Fares
{
  [DataContract]
  public class FareBounds
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string From { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string To { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Via { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string RouteCode { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Operator { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public int? DisplayOrder { get; set; }

    [DataMember]
    public bool IsPopularFare { get; set; }

    [DataMember]
    public bool IsPopularTravelCard { get; set; }

    [DataMember]
    public bool IsTour { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public ICollection<Message> Messages { get; set; }
  }
}
