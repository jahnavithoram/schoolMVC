using Microsoft.AspNetCore.Authorization;
using schoolMVC.Data;
using schoolMVC.Models;
using Xamarin.Essentials;

namespace MVCBasics.Controllers
{
    [Authorize]
    public class StudentController : BaseController<StudentModel>
    {

        public StudentController(IBaseRepositry<StudentModel> repo) : base(repo)
        {
        }

    }
}
