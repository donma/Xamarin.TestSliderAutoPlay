using System;
using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.BindingProviders;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
	[Fragment(Label = "Custom Template")]
    [ImportBinding(typeof(ItemSliderBindingProvider))]
    public class ItemSliderFragment : ViewSliderFragment<ItemSliderViewModel>
    {
        protected override int ViewSliderItemLayoutId
        {
            get
            {
                return Resource.Layout.ItemLayout;
            }
        }
    }
}