﻿// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.ApiHealth.ServiceStatus
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;

namespace Tfl.Api.Presentation.Entities.ApiHealth
{
  public class ServiceStatus
  {
    public Guid ServiceId { get; set; }

    public string ServiceName { get; set; }

    public bool IsRunning { get; set; }
  }
}
