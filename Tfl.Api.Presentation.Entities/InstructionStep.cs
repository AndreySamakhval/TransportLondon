// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.InstructionStep
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

//using Tfl.Api.Common.JourneyPlanner;

namespace Tfl.Api.Presentation.Entities
{
  public class InstructionStep
  {
    public string Description { get; set; }

    public string TurnDirection { get; set; }

    public string StreetName { get; set; }

    public int Distance { get; set; }

    public int CumulativeDistance { get; set; }

    public int SkyDirection { get; set; }

   // public CompassDirection SkyDirectionDescription { get; set; }

    public int CumulativeTravelTime { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public PathAttribute PathAttribute { get; set; }

    public string DescriptionHeading { get; set; }

  //  public JpSpecialTrackType TrackType { get; set; }

    public InstructionStep()
    {
      this.PathAttribute = new PathAttribute();
    }
  }
}
