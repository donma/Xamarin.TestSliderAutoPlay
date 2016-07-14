using System;
using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.BindingProviders;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
    [Fragment(Label = "Slide Direction")]
    [ImportBinding(typeof(AdSliderBindingProvider))]
    public class SlideDirectionFragment : ViewSliderFragment<SlideDirectionViewModel>
    {
        protected override bool AutoSlide
        {
            get { return true; }
        }

        protected override bool IsCircular
        {
            get { return true; }
        }

        protected override SlideDirection AutoSlideDirection
        {
            get { return SlideDirection.Right; }
        }
    }
}