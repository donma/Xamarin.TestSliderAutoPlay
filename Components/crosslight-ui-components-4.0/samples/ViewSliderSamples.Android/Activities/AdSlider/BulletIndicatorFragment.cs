using System;
using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.BindingProviders;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
    [Fragment(Label = "Bullet Indicator")]
    [ImportBinding(typeof(AdSliderBindingProvider))]
    public class BulletIndicatorFragment : ViewSliderFragment<BulletIndicatorViewModel>
    {
        protected override bool AutoSlide
        {
            get { return true; }
        }

        protected override bool IsCircular
        {
            get { return true; }
        }

        protected override SliderIndicatorMode IndicatorMode
        {
            get { return SliderIndicatorMode.Bullet; }
        }
    }
}