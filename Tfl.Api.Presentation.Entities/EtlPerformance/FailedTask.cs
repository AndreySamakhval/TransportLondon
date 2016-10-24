// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.EtlPerformance.FailedTask
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;

namespace Tfl.Api.Presentation.Entities.EtlPerformance
{
  public class FailedTask
  {
    public string Name { get; set; }

    public DateTime LastRun { get; set; }

    public string ResultText { get; set; }

    public int RequestId { get; set; }

    public long SsisExecutionId { get; set; }

    public bool SucceededSinceFailure { get; set; }

    public int TaskId { get; set; }
  }
}
