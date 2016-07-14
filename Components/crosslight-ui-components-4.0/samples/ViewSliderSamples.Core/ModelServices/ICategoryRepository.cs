using ViewSliderSamples.Models;

namespace ViewSliderSamples.ModelServices
{
    public interface ICategoryRepository : IDataRepository<Category, int>
    {
        #region Methods

        Category GetByName(string name);

        #endregion
    }
}