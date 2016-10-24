// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Comparers.LineStationParameterComparer
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;

namespace Tfl.Api.Presentation.Entities.Comparers
{
  public class LineStationParameterComparer : IEqualityComparer<LineStationParameter>
  {
    public int GetHashCode(LineStationParameter line)
    {
      return (line.LineId + "|" + line.NaptanId).GetHashCode();
    }

    public bool Equals(LineStationParameter l1, LineStationParameter l2)
    {
      return l1.LineId == l2.LineId && l1.NaptanId == l2.NaptanId;
    }
  }
}
