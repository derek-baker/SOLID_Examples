/// <summary>
/// The interfaces below are not bloated with unecessary methods or properties.
/// </summary>
namespace SOLID._4_InterfaceSegregation
{
    public interface IRelationalDatabase
    {
        public IDatabaseConnection Db { get; }
        public IDatabaseTable GetDbTable();
    }

    public interface IDocumentDatabase
    {
        public IDatabaseConnection Db { get; }
        public IDatabaseCollection GetDbCollection();        
    }
}
