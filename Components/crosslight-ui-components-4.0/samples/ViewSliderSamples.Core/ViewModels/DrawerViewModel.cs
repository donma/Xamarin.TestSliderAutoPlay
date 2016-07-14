using System;
using Intersoft.Crosslight.ViewModels;
using Intersoft.Crosslight;

namespace ViewSliderSamples.ViewModels
{
    public class DrawerViewModel : DrawerViewModelBase
    {
        #region Constructors

        public DrawerViewModel()
        {
            this.LeftViewModel = new NavigationViewModel();
            this.CenterViewModel = new ImageSliderViewModel();

            this.Open(DrawerSide.Left);
        }

        #endregion
    }
}

