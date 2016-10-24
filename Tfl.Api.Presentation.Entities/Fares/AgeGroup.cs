// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.AgeGroup
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.ComponentModel;

namespace Tfl.Api.Presentation.Entities.Fares
{
  public enum AgeGroup
  {
    [Description("Not set")] NotSet,
    [Description("Adult")] Adult,
    [Description("16-18 year old")] Age16To18,
    [Description("Child 11-15")] Age11To15,
    [Description("Child 5-10")] Age5To10,
    [Description("Child 0-4")] ChildUnder4,
  }
}
