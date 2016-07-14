
using System;
using CoreGraphics;

using Foundation;
using UIKit;
using ViewSliderSamples.ViewModels;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight;
using ViewSliderSamples.BindingProviders;

namespace ViewSliderSamples.iOS
{
    [ImportBinding(typeof(AdSliderBindingProvider))]
    public partial class AutoSlideViewController : UIViewController<AutoSlideViewModel>
    {
        public UICarouselView CarouselView { get; set; }

        public AutoSlideViewController()
        {
        }

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.Title = "Slide Show";
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.EdgesForExtendedLayout = UIRectEdge.None;

            this.CarouselView = new UICarouselView(
                new CGRect(0, 0, this.View.Bounds.Width, this.View.Bounds.Height))
            {
                EnableSlideShow = true,
                ShowPageIndicator = false,
                ImageContentMode = UIViewContentMode.ScaleAspectFill,
                AutoresizingMask = UIViewAutoresizing.FlexibleDimensions
            };

            this.View.AddSubview(this.CarouselView);
            this.RegisterViewIdentifier("ViewSlider", this.CarouselView);
        }
    }
}

