using Intersoft.Crosslight;

namespace ViewSliderSamples.Models
{
    [Serializable]
    public partial class Ad : ModelBase
    {
        #region Fields

        private int _id;
        private string _image;

        #endregion

        #region Methods

        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string Image
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    OnPropertyChanged("Image");
                }
            }
        }

        #endregion
    }
}
