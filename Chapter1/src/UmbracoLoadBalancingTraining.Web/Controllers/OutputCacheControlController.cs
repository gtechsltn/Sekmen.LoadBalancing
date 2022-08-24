using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Web.BackOffice.Controllers;
using UmbracoLoadBalancingTraining.Web.NotificationHandlers;

namespace UmbracoLoadBalancingTraining.Web.Controllers
{
    public class OutputCacheControlController : UmbracoAuthorizedApiController
    {
        private readonly DistributedCache _distributedCache;

        public OutputCacheControlController(DistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        // /umbraco/api/outputcachecontrol/clearcache
        [HttpGet]
        public bool ClearCache()
        {
            _distributedCache.RefreshAll(OutputCacheNotificationHandler.UniqueId);
            return true;
        }
    }
}
