namespace SOLID._4_InterfaceSegregation.Bad
{
    /// <summary>
    /// This interface contains methods pertaining to both relational and non-relational interfaces.
    /// Many consumers of this interface will not often use both types of DB at the same time.
    /// </summary>    
    public interface IDatabase
    {
        public IDatabaseConnection Db { get; }
        public IDatabaseCollection GetDbCollection();

        public IDatabaseTable GetDbTable();
    }
}
