using System.Collections.Generic;

/// <summary>
/// The two comments below highlight where Liskov Substitution comes into play.
/// Such substitutions allow us to "program to an interface".
/// </summary>
namespace SOLID._3_LiskovSubstitution
{
    public class StorageObject : IStorageObject 
    { 
        
    }

    public class StorageBucket : IStorageBucket 
    {
        public List<IStorageObject> GetContents() {
            // Since StorageObject implements IStorageObject, 
            // StorageObject is able to "stand in" for IStorageObject.
            return new List<IStorageObject>() { new StorageObject() }; 
        }
    }

    public class CloudStorage: ICloudStorage 
    {
        public IStorageBucket GetBucket(string projectId, string bucketName)
        {
            return new StorageBucket();
        }

        public void DeleteBucket(IStorageBucket bucket)
        {
            // Pretend that the needed code is here.            
        }

        private void showSubstitution(StorageBucket bucket)
        {
            // We're able to substitue a StorageBucket in place of an IStorageBucket 
            // for the parameter passed to the DeleteBucket invocation.
            DeleteBucket(bucket);
        }
    }
}
