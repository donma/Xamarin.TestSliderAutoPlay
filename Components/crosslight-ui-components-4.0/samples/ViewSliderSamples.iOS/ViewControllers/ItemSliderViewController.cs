
using System;
using CoreGraphics;

using Foundation;
using UIKit;
using ViewSliderSamples.ViewModels;
using Intersoft.Crosslight;
using ViewSliderSamples.BindingProviders;
using Intersoft.Crosslight.iOS;

namespace ViewSliderSamples.iOS
{
    [ImportBinding(typeof(ItemSliderBindingProvider))]
    public partial class ItemSliderViewController : UIViewController<ItemSliderViewModel>
    {
        public UICarouselView CarouselView { get; set; }

        public ItemSliderViewController()
        {
        }

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.Title = "Custom Template";
        }

        protected override void InitializeView()
        {
            base.InitializeView();

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

