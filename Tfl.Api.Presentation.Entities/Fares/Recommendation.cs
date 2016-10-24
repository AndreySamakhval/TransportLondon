// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.Recommendation
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.Fares
{
  [DataContract]
  public class Recommendation
  {
    public const string PricePerPerson = "PerPerson";
    public const string PriceDailyCap = "DailyCap";
    public const string PriceWeeklyCap = "WeeklyCap";

    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public int Rule { get; set; }

    [DataMember]
    public int Rank { get; set; }

    [DataMember]
    public string FareType { get; set; }

    [DataMember]
    public string Product { get; set; }

    [DataMember]
    public string TicketType { get; set; }

    [DataMember]
    public string TicketTime { get; set; }

    [DataMember]
    public string ProductType { get; set; }

    [DataMember]
    public string DiscountCard { get; set; }

    [DataMember]
    public string Zones { get; set; }

    [DataMember]
    public string Cost { get; set; }

    [DataMember]
    public string PriceDescription { get; set; }

    [DataMember]
    public string PriceComparison { get; set; }

    [DataMember]
    public string RecommendedTopUp { get; set; }

    [DataMember]
    public ICollection<Message> Notes { get; set; }

    [DataMember]
    public ICollection<Message> KeyFeatures { get; set; }

    [DataMember]
    public ICollection<Message> GettingYourTicket { get; set; }

    [DataMember]
    public Decimal SingleFare { get; set; }
  }
}
