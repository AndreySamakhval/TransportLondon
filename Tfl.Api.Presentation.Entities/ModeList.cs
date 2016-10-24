// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.ModeList
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [CollectionDataContract(ItemName = "Mode")]
  public class ModeList : List<string>
  {
  }
}
