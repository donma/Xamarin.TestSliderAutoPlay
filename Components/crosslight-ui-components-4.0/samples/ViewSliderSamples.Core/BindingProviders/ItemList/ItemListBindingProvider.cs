using Intersoft.Crosslight;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.BindingProviders
{
    public class ItemListBindingProvider : BindingProvider
    {
        #region Constructors

        public ItemListBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription()
            {
                DisplayMemberPath = "Name",
                DetailMemberPath = "Location",
                ImageMemberPath = "ThumbnailImage",
                ImagePlaceholder = "item_placeholder.png"
            };

            this.AddBinding("TableView", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("TableView", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
			this.AddBinding("TableView", BindableProperties.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
            this.AddBinding("TableView", BindableProperties.DetailNavigationTargetProperty, new NavigationTarget(typeof(DetailItemSliderViewModel)), true);
        }

        #endregion
    }
}