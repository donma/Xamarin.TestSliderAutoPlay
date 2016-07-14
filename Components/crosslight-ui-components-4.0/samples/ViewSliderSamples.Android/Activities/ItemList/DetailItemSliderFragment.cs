using System;
using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.BindingProviders;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
    [Fragment(Label = "Item Slider")]
    [ImportBinding(typeof(DetailItemSliderBindingProvider))]
    public class DetailItemSliderFragment : ViewSliderFragment<DetailItemSliderViewModel>
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