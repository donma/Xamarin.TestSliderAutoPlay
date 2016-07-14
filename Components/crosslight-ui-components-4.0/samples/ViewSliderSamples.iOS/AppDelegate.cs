using Foundation;
using UIKit;
using IntersoftCore = Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.iOS;

namespace ViewSliderSamples.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : IntersoftCore.UIApplicationDelegate
    {
        protected override UIViewController WrapRootViewController(UIViewController contentViewController)
        {
            if (contentViewController is UISplitViewController ||
                contentViewController is UITabBarController ||
                contentViewController is IDrawerNavigationController)
                return contentViewController;

            return new UINavigationController(contentViewController);
        }
    }
}