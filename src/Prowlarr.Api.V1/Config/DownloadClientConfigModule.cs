using NzbDrone.Core.Configuration;

namespace Prowlarr.Api.V1.Config
{
    public class DownloadClientConfigModule : ProwlarrConfigModule<DownloadClientConfigResource>
    {
        public DownloadClientConfigModule(IConfigService configService)
            : base(configService)
        {
        }

        protected override DownloadClientConfigResource ToResource(IConfigService model)
        {
            return DownloadClientConfigResourceMapper.ToResource(model);
        }
    }
}
