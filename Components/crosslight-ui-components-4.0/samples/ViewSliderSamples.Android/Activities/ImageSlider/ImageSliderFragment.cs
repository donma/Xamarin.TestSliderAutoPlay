using System;
using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.BindingProviders;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
    [Fragment(Label = "Image Slider")]
    [ImportBinding(typeof(ImageSliderBindingProvider))]
    public class ImageSliderFragment : ViewSliderFragment<ImageSliderViewModel>
    {

    }
}