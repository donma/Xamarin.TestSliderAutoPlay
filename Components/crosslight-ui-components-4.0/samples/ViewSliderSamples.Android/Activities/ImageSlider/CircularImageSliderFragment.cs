using System;
using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.BindingProviders;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
    [Fragment(Label = "Circular Image Slider")]
    [ImportBinding(typeof(ImageSliderBindingProvider))]
    public class CircularImageSliderFragment : ViewSliderFragment<CircularImageSliderViewModel>
    {
        protected override bool IsCircular
        {
            get { return true; }
        }
    }
}