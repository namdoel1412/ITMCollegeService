using ITMCollegeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Context;

namespace ITMCollegeService.Repositories
{
    public interface IUserRoleRepo
    {

    }
    public class UserRoleRepo : RepositoryBase<UserRole>, IUserRoleRepo
    {
        public UserRoleRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
    }
}
