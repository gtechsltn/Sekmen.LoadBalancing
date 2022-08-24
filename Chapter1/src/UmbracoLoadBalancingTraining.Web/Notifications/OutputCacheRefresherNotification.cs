using Umbraco.Cms.Core.Notifications;
using Umbraco.Cms.Core.Sync;

namespace UmbracoLoadBalancingTraining.Web.Notifications
{
    public class OutputCacheRefresherNotification : CacheRefresherNotification
    {
        public OutputCacheRefresherNotification(object messageObject, MessageType messageType) : base(messageObject, messageType)
        {
        }
    }
}
