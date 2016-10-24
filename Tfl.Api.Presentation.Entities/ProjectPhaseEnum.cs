// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.ProjectPhaseEnum
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.ComponentModel;

namespace Tfl.Api.Presentation.Entities
{
  public enum ProjectPhaseEnum
  {
    [Description("Unscoped")] Unscoped = 0,
    [Description("In Concept")] Concept = 1,
    [Description("Consultation Ended")] ConsultationEnded = 2,
    [Description("In Consultation")] Consultation = 3,
    [Description("In Construction")] Construction = 4,
    [Description("Completed")] Complete = 8,
  }
}
