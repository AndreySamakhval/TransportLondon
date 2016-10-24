// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.WebCAT.Scenario
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities.WebCAT
{
  public class Scenario
  {
    public string Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public short Year { get; set; }

    public IEnumerable<ScenarioTimeOfDay> TimesOfDay { get; set; }

    public IEnumerable<ScenarioMode> Modes { get; set; }
  }
}
