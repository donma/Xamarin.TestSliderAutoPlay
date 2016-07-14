using System;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.ViewModels;
using Android.Graphics;
using Android.App;

namespace ViewSliderSamples.Android
{
    [Activity(Label = "My Activity")]
    public class DrawerNavigationActivity : DrawerActivity<DrawerViewModel>
    {
        protected override DrawerSettings DrawerSettings
        {
            get
            {
                return new DrawerSettings
                {
                    LeftDrawerBackgroundColor = new Color(255, 255, 255),
                    RightDrawerBackgroundColor = new Color(255, 255, 255),
                };
            }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.DrawerLayout.SetBackgroundColor(Color.White);
        }
    }
}

