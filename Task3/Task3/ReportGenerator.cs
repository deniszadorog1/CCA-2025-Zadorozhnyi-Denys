using Task3.Interfaces;

namespace Task3
{
    public class ReportGenerator
    {
        private readonly IDataProvider _dataProvider;
        private readonly ILogger _logger;

        public ReportGenerator(IDataProvider dataProvider, ILogger logger)
        {
            _dataProvider = dataProvider;
            _logger = logger;
        }

        public void Generate()
        {
            var data = _dataProvider.GetData();
            _logger.Log("Report generated");
        }
    }
}
