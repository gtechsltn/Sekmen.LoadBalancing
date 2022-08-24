using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using WebEssentials.AspNetCore.OutputCaching;

namespace UmbracoLoadBalancingTraining.Web.Controllers
{
    public class DefaultController : RenderController
    {
        public DefaultController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
        }

        public override IActionResult Index()
        {
            HttpContext.EnableOutputCaching(TimeSpan.FromMinutes(60));
            return CurrentTemplate(CurrentPage);
        }
    }
}
