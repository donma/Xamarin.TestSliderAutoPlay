using Intersoft.Crosslight.ViewModels;
using ViewSliderSamples.Infrastructure;
using ViewSliderSamples.Models;
using ViewSliderSamples.ModelServices;
using System.Linq;

namespace ViewSliderSamples.ViewModels
{
    public class SlideDirectionViewModel : AdSliderViewModel
    {
        public SlideDirectionViewModel()
        {
            this.SelectedItem = this.Items.LastOrDefault();
        }
    }
}
