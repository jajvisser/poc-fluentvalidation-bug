using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ClientSideValidationTest.Models;
using ClientSideValidationTest.Models.Validators;
using FluentValidation.Internal;
using FluentValidation.Mvc;
using FluentValidation.Validators;
using ModelValidator = System.Web.Mvc.ModelValidator;

namespace ClientSideValidationTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            FluentValidationModelValidatorProvider.Configure(x =>
            {
                x.Add(typeof(PostcodeValidator), Factory);
            });
        }

        private ModelValidator Factory(ModelMetadata metadata, ControllerContext context, PropertyRule rule, IPropertyValidator validator)
        {
            return new PostcodeFieldClientFieldValidator(metadata, context, rule, validator);
        }
    }
}
