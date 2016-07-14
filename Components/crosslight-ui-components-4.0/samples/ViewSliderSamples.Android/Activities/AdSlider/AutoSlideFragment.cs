using System;
using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.BindingProviders;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
    [Fragment(Label = "Slide Show")]
    [ImportBinding(typeof(AdSliderBindingProvider))]
    public class AutoSliderFragment : ViewSliderFragment<AutoSlideViewModel>
    {
        protected override bool AutoSlide
        {
            get { return true; }
        }

        protected override bool IsCircular
        {
            get { return true; }
        }
    }
}