// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.AccidentStats.AccidentStatsOrderedSummary
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.AccidentStats
{
  [DataContract]
  public class AccidentStatsOrderedSummary
  {
    [DataMember]
    public int Year { get; set; }

    [DataMember]
    public string Borough { get; set; }

    [DataMember]
    public int Accidents { get; set; }
  }
}
