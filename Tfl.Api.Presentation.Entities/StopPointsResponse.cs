// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.StopPointsResponse
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  public class StopPointsResponse
  {
    public List<double> CentrePoint { get; set; }

    public IEnumerable<StopPoint> StopPoints { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public int PageSize { get; set; }

    [DataMember]
    public int Total { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public int Page { get; set; }
  }
}
