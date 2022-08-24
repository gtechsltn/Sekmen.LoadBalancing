using Microsoft.Extensions.Configuration;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Sync;

namespace UmbracoAzureTraining.Web
{
    public class LoadBalancingTrainingServerRoleAccessor : IServerRoleAccessor
    {
        private readonly IConfiguration _configuration;

        public LoadBalancingTrainingServerRoleAccessor(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ServerRole CurrentServerRole
        {
            get
            {
                var serverRoleKey = Constants.Configuration.ConfigPrefix + "ServerRole";
                var serverRoleConfig = _configuration[serverRoleKey];

                var serverRole = ServerRole.Subscriber;

                if (serverRoleConfig != null)
                {
                    if (Enum<ServerRole>.TryParse(serverRoleConfig, out var configServerRole))
                    {
                        serverRole = configServerRole;
                    }
                }

                return serverRole;
            }
        }
    }
}
