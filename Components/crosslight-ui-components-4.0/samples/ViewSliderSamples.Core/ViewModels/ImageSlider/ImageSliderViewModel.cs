using Intersoft.Crosslight.ViewModels;
using ViewSliderSamples.Infrastructure;
using ViewSliderSamples.Models;
using ViewSliderSamples.ModelServices;
using System.Linq;

namespace ViewSliderSamples.ViewModels
{
    public class ImageSliderViewModel : ListViewModelBase<Item>
    {
        #region Properties

        public IItemRepository Repository
        {
            get
            {
                if (Container.Current.CanResolve<IItemRepository>())
                    return Container.Current.Resolve<IItemRepository>();
                else
                    return new ItemRepository();
            }
        }
        
        #endregion
        
        #region Constructors

        public ImageSliderViewModel()
        {
            this.Items = this.Repository.GetAll().Skip(10).Take(10);
        }

        #endregion
    }
}
