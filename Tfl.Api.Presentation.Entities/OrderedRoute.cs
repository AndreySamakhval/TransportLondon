﻿// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.OrderedRoute
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities
{
  public class OrderedRoute
  {
    public string Name { get; set; }

    public IEnumerable<string> NaptanIds { get; set; }

    public string ServiceType { get; set; }
  }
}
