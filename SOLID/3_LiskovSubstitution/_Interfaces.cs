using System.Collections.Generic;

/// <summary>
/// Normally, there would be one interface per file.
/// </summary>
namespace SOLID._3_LiskovSubstitution
{    
    public interface IStorageObject
    {
        // Some method here
    }

    public interface IStorageBucket
    {
        public List<IStorageObject> GetContents();
    }

    public interface ICloudStorage
    {
        public IStorageBucket GetBucket(string projectId, string bucketName);
    }    
}
