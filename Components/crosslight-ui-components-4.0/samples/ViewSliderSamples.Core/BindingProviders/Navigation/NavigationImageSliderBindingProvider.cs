using Intersoft.Crosslight;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.BindingProviders
{
    public class NavigationImageSliderBindingProvider : BindingProvider
    {
        #region Constructors

        public NavigationImageSliderBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription()
            {
                DisplayMemberPath = "Name",
                DetailMemberPath = "Location",
                ImageMemberPath = "LargeImage"
            };

            this.AddBinding("ViewSlider", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("ViewSlider", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
            this.AddBinding("ViewSlider", BindableProperties.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
            this.AddBinding("ViewSlider", BindableProperties.DetailNavigationTargetProperty, new NavigationTarget(typeof(DetailItemSliderViewModel)), true);
        }

        #endregion
    }
}