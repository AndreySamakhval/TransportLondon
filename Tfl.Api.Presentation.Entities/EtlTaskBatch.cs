﻿// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.EtlTaskBatch
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities
{
  public class EtlTaskBatch
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime? LastRun { get; set; }

    public DateTime Created { get; set; }

    public ICollection<Tfl.Api.Presentation.Entities.EtlTaskBatchItem> EtlTaskBatchItem { get; set; }

    public EtlTaskBatch()
    {
      this.EtlTaskBatchItem = (ICollection<Tfl.Api.Presentation.Entities.EtlTaskBatchItem>) new HashSet<Tfl.Api.Presentation.Entities.EtlTaskBatchItem>();
    }
  }
}
