// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.RecommendationRequest
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.Fares
{
  [DataContract]
  public class RecommendationRequest : IValidatableObject
  {
    [DataMember]
    public RecommendationPeriod Period { get; set; }

    [DataMember]
    public bool Peak { get; set; }

    [DataMember]
    public string Zones { get; set; }

    [DataMember]
    public bool BusOnly { get; set; }

    [DataMember]
    public AgeGroup AgeGroup { get; set; }

    [DataMember]
    public DiscountType DiscountCard { get; set; }

    [DataMember]
    public string Railcard { get; set; }

    [DataMember]
    public bool Photocard { get; set; }

    [DataMember]
    public bool? Freebus { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      IEnumerable<string> periods = RecommendationRequest.ValidEnumList(typeof (RecommendationPeriod));
      if (this.Period == RecommendationPeriod.NotSet)
        yield return new ValidationResult("Travel period must be one of '" + (object) periods + "'.", (IEnumerable<string>) new string[1]{ "period" });
      if (this.Zones == null || this.Zones.ToLowerInvariant() != "all" && "123456789".IndexOf(this.Zones, StringComparison.Ordinal) == -1)
        yield return new ValidationResult("Zones must be 'all' or range from 1 to 9.", (IEnumerable<string>) new string[1]{ "zones" });
      IEnumerable<string> ages = RecommendationRequest.ValidEnumList(typeof (AgeGroup));
      if (this.AgeGroup == AgeGroup.NotSet)
        yield return new ValidationResult("AgeGroup must be one of '" + (object) ages + "'.", (IEnumerable<string>) new string[1]{ "ageGroup" });
      IEnumerable<string> discountCards = RecommendationRequest.ValidEnumList(typeof (DiscountType));
      if (this.DiscountCard == DiscountType.NotSet)
      {
        string discountCardsList = string.Join("','", discountCards);
        yield return new ValidationResult("DiscountCard must be one of '" + discountCardsList + "'.", (IEnumerable<string>) new string[1]
        {
          "discountCard"
        });
      }
      if (string.IsNullOrEmpty(this.Railcard))
        yield return new ValidationResult("Please select a railcard", (IEnumerable<string>) new string[1]{ "railcard" });
    }

    private static IEnumerable<string> ValidEnumList(Type enumType)
    {
      return ((IEnumerable<string>) Enum.GetNames(enumType)).Except<string>((IEnumerable<string>) new string[1]
      {
        Enum.ToObject(enumType, 0).ToString()
      });
    }
  }
}
