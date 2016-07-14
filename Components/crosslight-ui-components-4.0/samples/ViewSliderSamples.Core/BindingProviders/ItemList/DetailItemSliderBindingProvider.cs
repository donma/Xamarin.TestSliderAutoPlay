using Intersoft.Crosslight;

namespace ViewSliderSamples.BindingProviders
{
    public class DetailItemSliderBindingProvider : BindingProvider
    {
        #region Constructors

        public DetailItemSliderBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription();

            itemBinding.AddBinding("NameLabel", BindableProperties.TextProperty, "Name");
            itemBinding.AddBinding("ImageView", BindableProperties.ImageProperty, "LargeImage");
            itemBinding.AddBinding("DescriptionLabel", BindableProperties.TextProperty, "Description");
            itemBinding.AddBinding("CategoryLabel", BindableProperties.TextProperty, "Category.Name");
            itemBinding.AddBinding("PurchaseDateLabel", BindableProperties.TextProperty, new BindingDescription("PurchaseDate") { StringFormat = "{0:d}" });
            itemBinding.AddBinding("LocationLabel", BindableProperties.TextProperty, "Location");
            itemBinding.AddBinding("QuantityLabel", BindableProperties.TextProperty, "Quantity");
            itemBinding.AddBinding("PriceLabel", BindableProperties.TextProperty, "Price");
            itemBinding.AddBinding("SerialNumberLabel", BindableProperties.TextProperty, "SerialNumber");
            itemBinding.AddBinding("NotesLabel", BindableProperties.TextProperty, "Notes");

            this.AddBinding("ViewSlider", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("ViewSlider", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
			this.AddBinding("ViewSlider", BindableProperties.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
        }

        #endregion
    }
}