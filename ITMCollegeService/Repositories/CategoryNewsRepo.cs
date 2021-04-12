using ITMCollegeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Context;

namespace ITMCollegeService.Repositories
{
    public interface ICategoryNewsRepo
    {

    }
    public class CategoryNewsRepo : RepositoryBase<CategoryNews>, ICategoryNewsRepo
    {
        public CategoryNewsRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
    }
}
