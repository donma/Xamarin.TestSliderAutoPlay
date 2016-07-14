using Intersoft.Crosslight.ViewModels;
using ViewSliderSamples.Infrastructure;
using ViewSliderSamples.Models;
using ViewSliderSamples.ModelServices;

namespace ViewSliderSamples.ViewModels
{
    public class ItemSliderViewModel : ListViewModelBase<Item>
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

        public ItemSliderViewModel()
        {
            this.Items = this.Repository.GetAll();
        }

        #endregion
    }
}
