using Microsoft.AspNetCore.Authorization;
using schoolMVC.Data;
using schoolMVC.Models;

namespace MVCBasics.Controllers
{
    [Authorize]
    public class SubjectController : BaseController<SubjectModel>
    {

        public SubjectController(IBaseRepositry<SubjectModel> repo) : base(repo)
        {
        }

    }
}
