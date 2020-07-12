using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID._4_InterfaceSegregation
{
    public interface IDatabaseConnection { }

    /// <summary>
    /// This interface represents a collection from a document database.
    /// </summary>
    public interface IDatabaseCollection
    {
        public IEnumerable<IDocument> GetDocuments(Func<IDocument, bool> predicate)
        {
            return new List<IDocument>().Where(predicate);
        }
    }

    /// <summary>
    /// This interface represents a record from a document database.
    /// </summary>
    public interface IDocument { }

    /// <summary>
    /// This interface represents a table from a Relational database.
    /// </summary>
    public interface IDatabaseTable
    {
        public IEnumerable<IRow> GetRows(Func<IRow, bool> predicate)
        {
            return new List<IRow>().Where(predicate);
        }
    }

    /// <summary>
    /// This interface represents a record from a Relational database.
    /// </summary>
    public interface IRow { }
}
