﻿// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.NotificationEventDetail
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

namespace Tfl.Api.Presentation.Entities
{
  public class NotificationEventDetail
  {
    public string EventName { get; set; }

    public string uri { get; set; }

    public NotificationEventDetail(string eventName, string payload)
    {
      this.EventName = eventName;
      this.uri = payload;
    }
  }
}
