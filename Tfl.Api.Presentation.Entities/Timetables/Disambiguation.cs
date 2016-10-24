// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Timetables.Disambiguation
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities.Timetables
{
  public class Disambiguation
  {
    public List<DisambiguationOption> DisambiguationOptions { get; set; }

    public Disambiguation()
    {
      this.DisambiguationOptions = new List<DisambiguationOption>();
    }
  }
}
