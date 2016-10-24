// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Identifier
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(Name = "Identifier")]
  public class Identifier
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Uri { get; set; }

    [DataMember]
    public string FullName { get; set; }

    [DataMember]
    public string Type { get; set; }
  }
}
