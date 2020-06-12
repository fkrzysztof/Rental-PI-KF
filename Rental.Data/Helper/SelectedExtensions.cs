using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rental.Data.Helper
{
    public static class SelectedExtensions
    {
        public static string IsActiveController(this IHtmlHelper htmlHelper, params string[] name)
        {
            string controller = htmlHelper.ViewContext.RouteData.Values["controller"] as string;
            if (name == null || name.Length == 0)
                return "";
            else
            {
                if (name.Contains(controller) == true)
                {
                    return "show";
                }
                else
                {
                    return "";
                }
            }
        }
        public static string IsActiveAction(this IHtmlHelper htmlHelper, string actionName, string controllerName)
        {
            string action = htmlHelper.ViewContext.RouteData.Values["action"] as string;
            string controller = htmlHelper.ViewContext.RouteData.Values["controller"] as string;
            if (action == null || controller == null)
                return "";
            else
            {
                if (action == actionName && controller == controllerName)
                {
                    return "active";
                }
                else
                {
                    return "";
                }
            }
        }
    }
}