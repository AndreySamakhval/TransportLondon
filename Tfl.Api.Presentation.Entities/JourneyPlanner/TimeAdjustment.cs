// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.TimeAdjustment
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  [DataContract]
  public class TimeAdjustment
  {
    [DataMember]
    public string Date { get; set; }

    [DataMember]
    public string Time { get; set; }

    [DataMember]
    public string TimeIs { get; set; }

    [DataMember]
    public string Uri { get; set; }
  }
}
