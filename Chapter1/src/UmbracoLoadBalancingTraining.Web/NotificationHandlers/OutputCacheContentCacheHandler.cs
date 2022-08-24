using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;
using IHostingEnvironment = Umbraco.Cms.Core.Hosting.IHostingEnvironment;

//using WebEssentials.AspNetCore.OutputCaching;

namespace UmbracoLoadBalancingTraining.Web.NotificationHandlers
{
    public class OutputCacheContentCacheHandler : INotificationHandler<ContentCacheRefresherNotification>, INotificationHandler<MediaCacheRefresherNotification>, INotificationHandler<DictionaryCacheRefresherNotification>
    {
        //private readonly IOutputCachingService _outputCachingService;
        private readonly ILogger<OutputCacheContentCacheHandler> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;

        public OutputCacheContentCacheHandler(//IOutputCachingService outputCachingService,
                                              ILogger<OutputCacheContentCacheHandler> logger, IHostingEnvironment hostingEnvironment)
        {
            //_outputCachingService = outputCachingService;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }


        public void Handle(ContentCacheRefresherNotification notification)
        {
            //_outputCachingService.Clear();

            _logger.LogInformation("Output Cache Cleared (Content) for {SiteName}", _hostingEnvironment.SiteName);

        }

        public void Handle(MediaCacheRefresherNotification notification)
        {
            //_outputCachingService.Clear();

            _logger.LogInformation("Output Cache Cleared (Media) for {SiteName}", _hostingEnvironment.SiteName);

        }

        public void Handle(DictionaryCacheRefresherNotification notification)
        {
            //_outputCachingService.Clear();

            _logger.LogInformation("Output Cache Cleared (Dictionary) for {SiteName}", _hostingEnvironment.SiteName);

        }
    }
}
