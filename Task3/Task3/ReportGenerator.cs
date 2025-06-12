namespace Task3
{
    internal class ReportGenerator
    {
        private readonly DatabaseService _db = new DatabaseService();
        private readonly FileLogger _logger = new FileLogger();

        public void Generate()
        {
            var data = _db.GetData();
            _logger.Log("Report created.");
        }
    }
}
