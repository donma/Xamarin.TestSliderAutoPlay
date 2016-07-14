
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
    [ImportBinding(typeof(DetailItemSliderBindingProvider))]
    public partial class DetailItemSliderViewController : UIViewController<DetailItemSliderViewModel>
    {
        public UICarouselView CarouselView { get; set; }

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.Title = "Item Slider";
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.View.BackgroundColor = UIColor.White;
            this.EdgesForExtendedLayout = UIRectEdge.None;

            this.CarouselView = new UICarouselView(new CGRect(0, 0, this.View.Bounds.Width, this.View.Bounds.Height))
            {
                AutoresizingMask = UIViewAutoresizing.FlexibleDimensions,
                CellTemplate = new UIViewTemplate(ItemSliderCellView.Nib)
            };
            this.View.AddSubview(this.CarouselView);

            this.RegisterViewIdentifier("ViewSlider", this.CarouselView);
        }
    }
}

