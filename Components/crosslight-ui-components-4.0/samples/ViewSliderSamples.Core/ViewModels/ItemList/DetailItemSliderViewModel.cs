using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;
using ViewSliderSamples.Infrastructure;
using ViewSliderSamples.Models;
using ViewSliderSamples.ModelServices;

namespace ViewSliderSamples.ViewModels
{
    public class DetailItemSliderViewModel : ListViewModelBase<Item>
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

        public DetailItemSliderViewModel()
        {
            this.Items = this.Repository.GetAll();
        }

        #endregion

        #region Methods

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            this.SelectedItem = parameter.Data as Item;
        }

        #endregion
    }
}
