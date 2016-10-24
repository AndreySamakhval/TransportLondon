// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.DisambiguationOption
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class DisambiguationOption
  {
    public string ParameterValue { get; set; }

    public string Uri { get; set; }

    public Place Place { get; set; }

    public int MatchQuality { get; set; }
  }
}
