// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.StatusSeverity
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  public class StatusSeverity
  {
    [DataMember]
    public string ModeName { get; set; }

    [DataMember]
    public int SeverityLevel { get; set; }

    [DataMember]
    public string Description { get; set; }
  }
}
