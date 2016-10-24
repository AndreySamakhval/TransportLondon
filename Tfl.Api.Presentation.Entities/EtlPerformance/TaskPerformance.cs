// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.EtlPerformance.TaskPerformance
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;

namespace Tfl.Api.Presentation.Entities.EtlPerformance
{
  public class TaskPerformance
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public int Frequency { get; set; }

    public TimeSpan LastRunTime { get; set; }

    public TimeSpan AverageRunTime { get; set; }

    public bool ScheduleActive { get; set; }

    public string Status { get; set; }
  }
}
