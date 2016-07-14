
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
    [ImportBinding(typeof(ItemListBindingProvider))]
    public partial class ItemListViewController : UITableViewController<ItemListViewModel>
    {
        public ItemListViewController()
        {
        }

        public override TableViewCellStyle CellStyle
        {
            get
            {
                return TableViewCellStyle.Subtitle;
            }
        }

        public override TableViewInteraction InteractionMode
        {
            get
            {
                return TableViewInteraction.Navigation;
            }
        }

        public override ImageSettings CellImageSettings
        {
            get
            {
                return new ImageSettings(){ ImageSize = new CGSize(36, 36) };
            }
        }
    }
}

