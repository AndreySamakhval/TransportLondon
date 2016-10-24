// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Mode
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class Mode : IIdentifiable
  {
    [DataMember]
    public bool IsTflService { get; set; }

    [DataMember]
    public bool IsFarePaying { get; set; }

    [DataMember]
    public bool IsScheduledService { get; set; }

    [DataMember]
    public string ModeName { get; set; }

    public Mode()
    {
    }

    public Mode(string modeName, bool isTflService, bool isFarePaying, bool isScheduledService)
    {
      this.ModeName = modeName;
      this.IsTflService = isTflService;
      this.IsFarePaying = isFarePaying;
      this.IsScheduledService = isScheduledService;
    }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.ModeName.ToString((IFormatProvider) CultureInfo.InvariantCulture),
        Name = this.ModeName,
        Type = typeof (Mode).Name
      };
    }
  }
}
