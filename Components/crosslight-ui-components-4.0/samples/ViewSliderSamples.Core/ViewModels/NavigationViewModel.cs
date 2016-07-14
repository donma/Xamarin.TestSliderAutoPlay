using System.Collections.Generic;
using System.Linq;
using Intersoft.Crosslight;

namespace ViewSliderSamples.ViewModels
{
    public class NavigationViewModel : SampleListViewModelBase<NavigationItem>
    {
        #region Properties

        public string AboutText
        {
            get { return _aboutText; }
            set
            {
                if (_aboutText != value)
                {
                    _aboutText = value;
                    OnPropertyChanged("AboutText");
                }
            }
        }


        private string _aboutText { get; set; }

        #endregion

        #region Constructors

        public NavigationViewModel()
        {
            IApplicationContext context = this.GetService<IApplicationService>().GetContext();
            OSKind operatingSystem = context.Platform.OperatingSystem;

            List<NavigationItem> items = new List<NavigationItem>();

			if (operatingSystem == OSKind.iOS)
			{
				items.Add (new NavigationItem ("Image Slider", "Feature", typeof(ImageSliderViewModel)));
				items.Add (new NavigationItem ("Custom Template", "Feature", typeof(ItemSliderViewModel)));
				items.Add (new NavigationItem ("Item List", "Feature", typeof(ItemListViewModel)));
				items.Add (new NavigationItem ("Slide Show", "Feature", typeof(AutoSlideViewModel)));
				items.Add (new NavigationItem ("Page Indicator", "Feature", typeof(BulletIndicatorViewModel)));
			}
			else if (operatingSystem == OSKind.Android) 
			{
				items.Add (new NavigationItem ("Image Slider", "Feature", typeof(ImageSliderViewModel)));
				items.Add (new NavigationItem ("Circular Image Slider", "Feature", typeof(CircularImageSliderViewModel)));
				items.Add (new NavigationItem ("Custom Template", "Feature", typeof(ItemSliderViewModel)));
				items.Add (new NavigationItem ("Item List", "Feature", typeof(ItemListViewModel)));
				items.Add (new NavigationItem ("Slide Show", "Feature", typeof(AutoSlideViewModel)));
				items.Add (new NavigationItem ("Slide Direction", "Feature", typeof(SlideDirectionViewModel)));
                items.Add (new NavigationItem ("Navigation", "Feature", typeof(NavigationImageSliderViewModel)));

				items.Add (new NavigationItem ("Bullet Indicator", "Slider Indicator", typeof(BulletIndicatorViewModel)));
				items.Add (new NavigationItem ("Strip Indicator", "Slider Indicator", typeof(StripIndicatorViewModel)));
			}

            this.SourceItems = items;
            this.RefreshGroupItems();
        }

        #endregion

        #region Methods

        public override void RefreshGroupItems()
        {
            if (this.Items != null)
                this.GroupItems = this.Items.GroupBy(o => o.Group).Select(o => new GroupItem<NavigationItem>(o)).ToList();
        }

        #endregion
    }
}