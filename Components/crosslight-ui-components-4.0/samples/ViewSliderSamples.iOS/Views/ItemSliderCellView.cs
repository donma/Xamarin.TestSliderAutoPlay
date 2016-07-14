
using System;
using CoreGraphics;

using Foundation;
using UIKit;

namespace ViewSliderSamples.iOS
{
	public partial class ItemSliderCellView : UICollectionViewCell
	{
		public static readonly NSString Key = new NSString ("ItemSliderCellView");
		public static readonly UINib Nib;

		static ItemSliderCellView ()
		{
			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone)
				Nib = UINib.FromName ("ItemSliderCellView_iPhone", NSBundle.MainBundle);
			else
				Nib = UINib.FromName ("ItemSliderCellView_iPad", NSBundle.MainBundle);
		}

		public ItemSliderCellView (IntPtr handle) : base (handle)
		{

		}

		public static ItemSliderCellView Create ()
		{
			return (ItemSliderCellView)Nib.Instantiate (null, null) [0];
		}
			
		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			this.DescriptionLabel.Frame = new CGRect (this.DescriptionLabel.Frame.X, this.DescriptionLabel.Frame.Y, this.DescriptionLabel.Bounds.Width, 1);
			this.DescriptionLabel.SizeToFit ();
		}
	}
}

