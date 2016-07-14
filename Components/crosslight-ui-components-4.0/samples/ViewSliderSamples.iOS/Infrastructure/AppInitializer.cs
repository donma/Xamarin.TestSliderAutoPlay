using ViewSliderSamples.Infrastructure;
using Intersoft.Crosslight;

namespace ViewSliderSamples.iOS.Infrastructure
{
    public sealed class AppInitializer : IApplicationInitializer
    {
        #region IApplicationInitializer Members

        public IApplicationService GetApplicationService(IApplicationContext context)
        {
            return new CrosslightAppAppService(context);
        }

        public void InitializeApplication(IApplicationHost appHost)
        {
        }

        public void InitializeComponents(IApplicationHost appHost)
        {
        }

        public void InitializeServices(IApplicationHost appHost)
        {
        }

        #endregion
    }
}