// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.RecommendationPeriod
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.ComponentModel;

namespace Tfl.Api.Presentation.Entities.Fares
{
  public enum RecommendationPeriod
  {
    [Description("Not set")] NotSet = 0,
    [Description("1 day")] OneDay = 1,
    [Description("2 days")] TwoDays = 2,
    [Description("3 days")] ThreeDays = 3,
    [Description("4 days")] FourDays = 4,
    [Description("5 days")] FiveDays = 5,
    [Description("6 days")] SixDays = 6,
    [Description("7 days")] SevenDays = 7,
    [Description("1 month")] OneMonth = 30,
    [Description("1 year")] OneYear = 365,
  }
}
