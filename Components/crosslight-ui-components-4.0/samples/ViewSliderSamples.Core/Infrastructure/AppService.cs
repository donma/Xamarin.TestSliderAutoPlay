using Intersoft.Crosslight;
using Intersoft.Crosslight.Containers;
using Intersoft.Crosslight.Services;
using ViewSliderSamples.ModelServices;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Infrastructure
{
    public sealed class CrosslightAppAppService : ApplicationServiceBase
    {
        #region Constructors

        public CrosslightAppAppService(IApplicationContext context)
            : base(context)
        {
            Container.Current.Register<IItemRepository>((c) => new ItemRepository()).WithLifetimeManager(new ContainerLifetime());
            Container.Current.Register<ICategoryRepository>((c) => new CategoryRepository()).WithLifetimeManager(new ContainerLifetime());

            ServiceProvider.AddService<IResourceLoaderService, ResourceLoaderService>();
            ServiceProvider.AddService<IResourceCacheService, ResourceCacheService>();
            ServiceProvider.AddService<IImageLoaderService, ImageLoaderService>();
        }

        #endregion

        #region Methods

        protected override void OnStart(StartParameter parameter)
        {
            base.OnStart(parameter);

            // Set the root ViewModel to be displayed at startup
            this.SetRootViewModel<DrawerViewModel>();
        }

        #endregion
    }
}