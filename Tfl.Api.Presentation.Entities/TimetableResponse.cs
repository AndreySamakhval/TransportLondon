// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.TimetableResponse
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;
using Tfl.Api.Presentation.Entities.Timetables;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class TimetableResponse
  {
    [DataMember]
    public string LineId { get; set; }

    [DataMember]
    public string LineName { get; set; }

    [DataMember]
    public string Direction { get; set; }

    [DataMember]
    public string PdfUrl { get; set; }

    [DataMember]
    public List<MatchedStop> Stations { get; set; }

    [DataMember]
    public List<MatchedStop> Stops { get; set; }

    [DataMember]
    public Timetable Timetable { get; set; }

    [DataMember]
    public Disambiguation Disambiguation { get; set; }

    [DataMember]
    public string StatusErrorMessage { get; set; }
  }
}
