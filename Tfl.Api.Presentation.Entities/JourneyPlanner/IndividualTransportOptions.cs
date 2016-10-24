// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.IndividualTransportOptions
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class IndividualTransportOptions
  {
    public string WalkingSpeed { get; set; }

  //  public Tfl.Api.Common.CycleType? CycleType { get; set; }

    public bool? Wheelchair { get; set; }

    public MeansOfTransport ArrivalMeansOfTransport { get; set; }

    public int ArrivalMeansOfTransportMaximumTime { get; set; }

    public MeansOfTransport DepartureMeansOfTransport { get; set; }

    public int DepartureMeansOfTransportMaximumTime { get; set; }

    public MeansOfTransport MeansOfTransport { get; set; }

    public int MeansOfTransportMaximumTime { get; set; }

    public IndividualTransportOptions()
    {
      this.WalkingSpeed = "normal";
    }
  }
}
