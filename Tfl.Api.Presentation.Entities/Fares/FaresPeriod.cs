// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.FaresPeriod
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.Fares
{
  [DataContract(IsReference = true)]
  public class FaresPeriod
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public DateTime StartDate { get; set; }

    [DataMember]
    public DateTime ViewableDate { get; set; }

    [DataMember]
    public DateTime EndDate { get; set; }

    [DataMember]
    public bool IsFuture { get; set; }
  }
}
