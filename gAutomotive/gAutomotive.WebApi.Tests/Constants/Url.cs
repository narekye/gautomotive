namespace gAutomotive.WebApi.Tests.Constants
{
    public class Url
    {
        private static ProjectType _type;

        public const string BaseUrlLocal = "http://localhost:38540/";
        public const string BaseUrlLive = "http://gautomotive.azurewebsites.net/";

        private const string AllCustomersUrl = "api/customer/getallcustomers";
        public static string GetAllCustomersUrl
        {
            get
            {
                var result = _type == ProjectType.Live ? BaseUrlLive + AllCustomersUrl : BaseUrlLocal + AllCustomersUrl;
                return result;
            }
        }

        public static void Set(ProjectType type)
        {
            _type = type;
        }
    }
}
