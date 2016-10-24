// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.DisruptionOverride
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

namespace Tfl.Api.Presentation.Entities
{
  public class DisruptionOverride
  {
    public long Id { get; set; }

    public string LineId { get; set; }

    public int? StatusSeverityId { get; set; }

    public string Description { get; set; }

    public string LineName { get; set; }

    public string ModeName { get; set; }
  }
}
