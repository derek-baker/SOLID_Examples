namespace SOLID._1_SingleResponsibility.Bad
{
    internal interface IReportData { }

    internal interface IDb { internal IReportData GetData(); }

    internal interface IReportingEngine { internal byte[] GenerateReport(IReportData data); }

    internal interface IReportGenerator { }

    /// <summary>
    /// This class could require modification due to changes in  
    /// how data is acquired, or by changes in how the report is generated.
    /// </summary>
    internal class ReportGenerator : IReportGenerator 
    {
        private readonly IDb _db;
        private readonly IReportingEngine _reportEngine;        

        internal ReportGenerator(IDb db, IReportingEngine reportEngine)
        {
            _db = db;
            _reportEngine = reportEngine;
        }

        internal IReportData GetReportData()
        {
            return _db.GetData();
        }

        internal byte[] GenerateReport(IReportData data)
        {
            return _reportEngine.GenerateReport(data);
        }
    }
}
