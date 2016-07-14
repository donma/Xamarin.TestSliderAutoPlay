using Intersoft.Crosslight.ViewModels;
using ViewSliderSamples.Infrastructure;
using ViewSliderSamples.Models;
using ViewSliderSamples.ModelServices;

namespace ViewSliderSamples.ViewModels
{
    public class AdSliderViewModel : ListViewModelBase<Ad>
    {
        #region Properties

        public IAdRepository Repository
        {
            get
            {
                if (Container.Current.CanResolve<IAdRepository>())
                    return Container.Current.Resolve<IAdRepository>();
                else
                    return new AdRepository();
            }
        }
        
        #endregion
        
        #region Constructors

        public AdSliderViewModel()
        {
            this.Items = this.Repository.GetAll();
        }

        #endregion
    }
}
