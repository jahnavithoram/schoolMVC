using Microsoft.AspNetCore.Authorization;
using schoolMVC.Data;
using schoolMVC.Models;

namespace MVCBasics.Controllers
{
    [Authorize]
    public class ClassesController : BaseController<Class>
    {
        
        public ClassesController(IBaseRepositry<Class> repo) : base(repo)
        {
        }

    }
}
