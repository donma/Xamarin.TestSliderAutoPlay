using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.BindingProviders;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
    [Fragment(Label = "Item List")]
    [ImportBinding(typeof(ItemListBindingProvider))]
    public class ItemListFragment : ListFragment<ItemListViewModel>
    {
        #region Properties

        protected override int ListItemLayoutId
        {
            get { return Resource.Layout.ItemListLayout; }
        }

        public override ListViewInteraction InteractionMode
        {
            get { return ListViewInteraction.Navigation; }
        }

        #endregion

        #region Constructors

        public ItemListFragment()
        {
        }

        #endregion

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }

        #endregion
    }
}