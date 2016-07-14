using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using ViewSliderSamples.Models;

namespace ViewSliderSamples.ModelServices
{
    public class AdRepository : IAdRepository
    {
        #region Fields

        private IEnumerable<Ad> _items = null;

        #endregion

        #region Methods

        private Ad CreateAd(XElement x)
        {
            Ad banner = new Ad()
            {
                Id = int.Parse(x.Element("Id").Value),
                Image = string.Format("assembly://{0}/Assets/Images/Ad/{1}", "ViewSliderSamples.Core", x.Element("Image").Value)
            };

            return banner;
        }

        #endregion

        #region ICategoryRepository Members

        public virtual Ad Get(int id)
        {
            return this.GetAll().FirstOrDefault(o => o.Id == id);
        }
        
        public IEnumerable<Ad> GetAll()
        {
            if (_items == null)
            {
                XDocument doc = XDocument.Load(typeof(AdRepository).Assembly.GetManifestResourceStream("ViewSliderSamples.Core.Assets.Data.Ads.xml"));

                var query = from x in doc.Descendants("Ad")
                            select CreateAd(x);

                _items = query.ToList();
            }

            return _items;
        }

        #endregion
    }
}