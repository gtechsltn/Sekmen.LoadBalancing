using System;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Events;
using IHostingEnvironment = Umbraco.Cms.Core.Hosting.IHostingEnvironment;
using UmbracoLoadBalancingTraining.Web.Notifications;
//using WebEssentials.AspNetCore.OutputCaching;

namespace UmbracoLoadBalancingTraining.Web.NotificationHandlers
{
    public class OutputCacheNotificationHandler : CacheRefresherBase<OutputCacheRefresherNotification>
    {
        //private readonly IOutputCachingService _outputCachingService;
        private readonly ILogger<OutputCacheNotificationHandler> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;

        public OutputCacheNotificationHandler(AppCaches appCaches, IEventAggregator eventAggregator, ICacheRefresherNotificationFactory factory, //IOutputCachingService outputCachingService,
            ILogger<OutputCacheNotificationHandler> logger, IHostingEnvironment hostingEnvironment) : base(appCaches, eventAggregator, factory)
        {
            //_outputCachingService = outputCachingService;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        public static readonly Guid UniqueId = Guid.Parse("85D9E97E-5FC3-427F-8BD6-B7E97972B259");

        public override Guid RefresherUniqueId => UniqueId;

        public override string Name => "Output Cache Refresher";

        public override void RefreshAll()
        {
            //_outputCachingService.Clear();

            _logger.LogInformation("Output Cache Cleared (Custom) for {SiteName}", _hostingEnvironment.SiteName);
        }
    }
}
