using ViewSliderSamples.Models;

namespace ViewSliderSamples.ModelServices
{
    public interface IItemRepository : IEditableDataRepository<Item, string>
    {
        #region Methods

        CategoryGroup GetCategoryGroup(int group);

        #endregion
    }
}