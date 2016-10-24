// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.WaterwayDetail
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class WaterwayDetail
  {
    [DataMember(EmitDefaultValue = false)]
    public IEnumerable<Place> Places { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public int Id { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string WaterwayName { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public IEnumerable<string> Types { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public IEnumerable<WaterwayLineString> LineStrings { get; set; }
  }
}
