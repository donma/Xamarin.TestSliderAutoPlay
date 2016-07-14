
using System;
using CoreGraphics;

using Foundation;
using UIKit;
using ViewSliderSamples.ViewModels;
using Intersoft.Crosslight.iOS;
using ViewSliderSamples.BindingProviders;
using Intersoft.Crosslight;

namespace ViewSliderSamples.iOS
{
    [ImportBinding(typeof(ImageSliderBindingProvider))]
    public partial class ImageSliderViewController : UIViewController<ImageSliderViewModel>
    {
        public UICarouselView CarouselView { get; set; }

        public ImageSliderViewController()
        {
        }

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.Title = "Image Slider";
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.EdgesForExtendedLayout = UIRectEdge.None;

            this.CarouselView = new UICarouselView(new CGRect(0, 0, this.View.Bounds.Width, this.View.Bounds.Height))
            {
                CurrentPageIndicatorColor = UIColor.DarkGray,
                PageIndicatorColor = UIColor.LightGray,
                AutoresizingMask = UIViewAutoresizing.FlexibleDimensions
            };
            this.View.AddSubview(this.CarouselView);

            this.RegisterViewIdentifier("ViewSlider", this.CarouselView);
        }
    }
}

