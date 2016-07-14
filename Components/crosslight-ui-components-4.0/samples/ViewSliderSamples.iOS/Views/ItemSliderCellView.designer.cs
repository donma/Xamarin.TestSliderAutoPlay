// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ViewSliderSamples.iOS
{
	[Register ("ItemSliderCellView")]
	partial class ItemSliderCellView
	{
		[Outlet]
		UIKit.UILabel DescriptionLabel { get; set; }

		[Outlet]
		UIKit.UIImageView ImageView { get; set; }

		[Outlet]
		UIKit.UILabel NameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DescriptionLabel != null) {
				DescriptionLabel.Dispose ();
				DescriptionLabel = null;
			}

			if (ImageView != null) {
				ImageView.Dispose ();
				ImageView = null;
			}

			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}
		}
	}
}
