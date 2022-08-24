using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Events;
using IHostingEnvironment = Umbraco.Cms.Core.Hosting.IHostingEnvironment;
using Umbraco.Cms.Core.Notifications;
//using WebEssentials.AspNetCore.OutputCaching;

namespace UmbracoLoadBalancingTraining.Web.NotificationHandlers
{
    public class OutputCachePublishedHandler : INotificationHandler<ContentPublishedNotification>
    {
        //private readonly IOutputCachingService _outputCachingService;
        private readonly ILogger<OutputCachePublishedHandler> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;

        public OutputCachePublishedHandler(//IOutputCachingService outputCachingService,
                                           ILogger<OutputCachePublishedHandler> logger, IHostingEnvironment hostingEnvironment)
        {
            //_outputCachingService = outputCachingService;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }


        public void Handle(ContentPublishedNotification notification)
        {
            //_outputCachingService.Clear();

            _logger.LogInformation("Output Cache Cleared (Publish) for {SiteName}", _hostingEnvironment.SiteName);

            notification.Messages.Add(new EventMessage("Output Cache",
                "Cleared",
                EventMessageType.Success));
        }
    }
}
