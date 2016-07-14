using System;
using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ViewSliderSamples.ViewModels;

namespace ViewSliderSamples.Android
{
    [ImportBinding(typeof(NavigationBindingProvider))]
    public class NavigationFragment : ListFragment<NavigationViewModel>
    {
        #region Properties

        protected override int GroupItemLayoutId
        {
            get { return Resource.Layout.listgroupsectionheaderlayout; }
        }

        public override ListViewInteraction InteractionMode
        {
            get { return ListViewInteraction.Navigation; }
        }

        #endregion

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }

        #endregion
    }
}

