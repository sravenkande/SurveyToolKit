using System.Web;
using System.Web.Mvc;

namespace SurveyToolKit
{
    // Test Commits for Git.
    // Second Commit test for the Git.
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}