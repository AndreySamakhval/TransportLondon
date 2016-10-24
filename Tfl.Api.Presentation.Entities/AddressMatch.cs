// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.AddressMatch
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class AddressMatch : SearchMatch
  {
    [DataMember(EmitDefaultValue = false)]
    public string AddressLineOne { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string AddressLineTwo { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string AddressLineThree { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Town { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string County { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string PostCode { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Country { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string BuildingNumber { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string SubBuildingNumber { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string BuildingName { get; set; }
  }
}
