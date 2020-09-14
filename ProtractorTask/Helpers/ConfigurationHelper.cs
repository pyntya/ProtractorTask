using System.Configuration;

namespace ProtractorTests.Helpers
{
    public static class ConfigurationHelper
    {
        private static string _baseUrl;
        public static string BaseUrl
        {
            get => _baseUrl = _baseUrl ?? ConfigurationManager.AppSettings["BaseUrl"];

        }
    }
}
