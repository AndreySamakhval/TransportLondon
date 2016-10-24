// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.WebCAT.PtalResult
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;

namespace Tfl.Api.Presentation.Entities.WebCAT
{
  public class PtalResult
  {
    public string Value { get; set; }

    public DateTime LastRefreshed { get; set; }

    public PtalScenario Scenario { get; set; }

    public int GridId { get; set; }

    public PtalResult()
    {
      this.Scenario = new PtalScenario();
    }
  }
}
