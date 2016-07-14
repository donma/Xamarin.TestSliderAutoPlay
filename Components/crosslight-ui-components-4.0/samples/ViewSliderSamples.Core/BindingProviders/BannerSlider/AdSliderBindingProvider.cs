using Intersoft.Crosslight;

namespace ViewSliderSamples.BindingProviders
{
    public class AdSliderBindingProvider : BindingProvider
    {
        #region Constructors

        public AdSliderBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription()
            {
                ImageMemberPath = "Image",
                ImagePlaceholder = "transparent.png"
            };

            this.AddBinding("ViewSlider", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("ViewSlider", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
			this.AddBinding("ViewSlider", BindableProperties.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
        }

        #endregion
    }
}