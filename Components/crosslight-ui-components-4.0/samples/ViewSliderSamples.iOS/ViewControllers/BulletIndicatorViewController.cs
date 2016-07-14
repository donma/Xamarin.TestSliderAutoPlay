
using System;
using CoreGraphics;

using Foundation;
using UIKit;
using Intersoft.Crosslight.iOS;
using ViewSliderSamples.ViewModels;
using Intersoft.Crosslight;
using ViewSliderSamples.BindingProviders;

namespace ViewSliderSamples.iOS
{
    [ImportBinding(typeof(AdSliderBindingProvider))]
    public partial class BulletIndicatorViewController : UIViewController<BulletIndicatorViewModel>
    {
        public UICarouselView CarouselView { get; set; }

        public BulletIndicatorViewController()
        {
        }

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.Title = "Page Indicator";
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.EdgesForExtendedLayout = UIRectEdge.None;

            this.CarouselView = new UICarouselView(new CGRect(0, 0, this.View.Bounds.Width, this.View.Bounds.Height))
            {
                EnableSlideShow = true,
                ShowPageIndicator = true,
                ImageContentMode = UIViewContentMode.ScaleAspectFill,
                CurrentPageIndicatorColor = UIColor.Blue,
                PageIndicatorColor = UIColor.Gray,
                AutoresizingMask = UIViewAutoresizing.FlexibleDimensions
            };

            this.View.AddSubview(this.CarouselView);
            this.RegisterViewIdentifier("ViewSlider", this.CarouselView);
        }
    }
}

