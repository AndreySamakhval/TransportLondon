// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.EtlTask
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;

namespace Tfl.Api.Presentation.Entities
{
  public class EtlTask
  {
    public int Id { get; set; }

    public string TaskName { get; set; }

    public string Description { get; set; }

    public bool Enabled { get; set; }

    public bool ScheduleActive { get; set; }

    public int Frequency { get; set; }

    public DateTime? FirstRun { get; set; }

    public DateTime LastRun { get; set; }

    public int LastRunStatus { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsPriority { get; set; }
  }
}
