// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.NotificationEvent
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities
{
  public class NotificationEvent
  {
    public string EventName { get; set; }

    public ICollection<string> NotificationParameters { get; set; }

    public NotificationEvent()
    {
      this.NotificationParameters = (ICollection<string>) new List<string>();
    }
  }
}
