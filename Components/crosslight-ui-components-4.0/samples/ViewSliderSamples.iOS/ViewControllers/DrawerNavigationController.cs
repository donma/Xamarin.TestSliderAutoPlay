using System;
using Intersoft.Crosslight.iOS;
using Foundation;
using ViewSliderSamples.ViewModels;
using UIKit;

namespace ViewSliderSamples.iOS
{
    [Register("DrawerNavigationController")]
    public class DrawerNavigationController : UIDrawerNavigationController<DrawerViewModel>
    {
        public DrawerNavigationController()
        {
            // Set drawer-related settings through the provided DrawerSettings property
            this.DrawerSettings.StatusBarTransitionMode = StatusBarTransitionMode.TranslucentBlur;
            this.DrawerSettings.LeftStatusBarColor = UIColor.Clear;
        }

        protected override void OnViewCreated()
        {
            base.OnViewCreated();

            // set the title once during creation
            // the subsequent navigation will automatically synchronize the navigation title
            this.VisibleViewController.NavigationItem.Title = "Simple List";
        }
    }
}

