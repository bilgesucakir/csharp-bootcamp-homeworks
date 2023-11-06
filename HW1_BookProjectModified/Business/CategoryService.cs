using HW1_BookProjectModified.Data;

namespace HW1_BookProjectModified.Business;

public class CategoryService : ICategoryService
{

    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void GetList()
    {
        _categoryRepository
            .GetAll()
            .ForEach(c => Console.WriteLine(c));
    }
}
