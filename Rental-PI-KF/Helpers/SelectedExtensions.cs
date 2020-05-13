using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental_PI_KF.Helpers
{
    public static class SelectedExtensions
    {
        public static string IsActive(this IHtmlHelper htmlHelper, string controllers, string actions = null, string cssClass = "show show-force")
        {

            string currentController = htmlHelper.ViewContext.RouteData.Values["controller"] as string;
            IEnumerable<string> acceptedControllers = (controllers ?? currentController).Split(',');

            if (actions == null)
            {
                return acceptedControllers.Contains(currentController) ? cssClass : String.Empty;
            }

            string currentAction = htmlHelper.ViewContext.RouteData.Values["action"] as string;
            IEnumerable<string> acceptedActions = (actions ?? currentAction).Split(',');

            return acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ?
                cssClass : String.Empty;
        }
    }
}
