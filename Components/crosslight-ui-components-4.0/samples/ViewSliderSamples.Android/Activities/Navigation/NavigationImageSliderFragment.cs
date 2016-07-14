using System;
using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.BindingProviders;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
    [Fragment(Label = "Navigation Circular Image Slider")]
    [ImportBinding(typeof(NavigationImageSliderBindingProvider))]
    public class NavigationImageSliderFragment : ViewSliderFragment<NavigationImageSliderViewModel>
    {
        protected override bool IsCircular
        {
            get { return false; }
        }
    }
}