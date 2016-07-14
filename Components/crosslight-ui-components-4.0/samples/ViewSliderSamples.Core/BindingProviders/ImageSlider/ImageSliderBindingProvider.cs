using Intersoft.Crosslight;

namespace ViewSliderSamples.BindingProviders
{
    public class ImageSliderBindingProvider : BindingProvider
    {
        #region Constructors

        public ImageSliderBindingProvider()
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
        }

        #endregion
    }
}