﻿// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.ApiHealth.ApiHealth
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities.ApiHealth
{
  public class ApiHealth
  {
    public string Id { get; set; }

    public string ApiName { get; set; }

    public GlobalApiHealthStatus GlobalApiHealthStatus { get; set; }

    public IEnumerable<ServiceStatus> ChildServices { get; set; }
  }
}
