// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.PredictionStats
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract]
  public class PredictionStats
  {
    [DataMember]
    public string DatabaseName { get; set; }

    [DataMember]
    public string CollectionName { get; set; }

    [DataMember]
    public double AvgObjectSize { get; set; }

    [DataMember]
    public long DataSize { get; set; }

    [DataMember]
    public Dictionary<string, long> IndexSizes { get; set; }

    [DataMember]
    public Dictionary<string, long> ObjectCounts { get; set; }

    [DataMember]
    public long ObjectCount { get; set; }

    [DataMember]
    public bool IsOk { get; set; }

    [DataMember]
    public long StorageSize { get; set; }

    [DataMember]
    public long TotalIndexSize { get; set; }

    [DataMember]
    public long ActiveCount { get; set; }

    public PredictionStats(string databaseName, string collectionName, bool isOk)
    {
      this.DatabaseName = databaseName;
      this.CollectionName = collectionName;
      this.IsOk = isOk;
    }

    public PredictionStats(string databaseName, string collectionName, double avgObjectSize, long dataSize, Dictionary<string, long> indexSizes, Dictionary<string, long> objectCounts, long objectCount, bool isOk, long storageSize, long totalIndexSize, long activeCount)
    {
      this.DatabaseName = databaseName;
      this.CollectionName = collectionName;
      this.AvgObjectSize = avgObjectSize;
      this.DataSize = dataSize;
      this.IndexSizes = indexSizes;
      this.ObjectCount = objectCount;
      this.IsOk = isOk;
      this.ActiveCount = activeCount;
      this.StorageSize = storageSize;
      this.TotalIndexSize = totalIndexSize;
      this.ObjectCounts = objectCounts;
    }
  }
}
