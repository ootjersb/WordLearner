using System;
using System.Web;
using System.Web.Mvc;

namespace WordLearnerMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            var errorHandler = new HandleErrorAttribute();
            filters.Add(errorHandler);
        }

        private static void onException(ExceptionContext obj)
        {
            throw new NotImplementedException();
        }
    }
}
