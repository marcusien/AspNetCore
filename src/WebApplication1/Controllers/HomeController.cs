using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var viewModel = new ViewModelBase();
            viewModel.Load();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult IndexPostWithoutIEnumerable(ViewModelBase viewModel)
        {
            // IsValid return true when the MyDate property is correctly filled
            if (this.ModelState.IsValid)
            {
                this.ModelState.Clear();
            }

            return View("Index", viewModel);
        }

        [HttpPost]
        public IActionResult IndexPostWithIEnumerable(IEnumerableViewModel viewModel)
        {
            // No matter how MyDate is filled, IsValid returns false
            // The modelstate does not have any error and the only Key/Value is MyDate.
            // The modelstatenode stays Unvalidated !
            if (this.ModelState.IsValid)
            {
                this.ModelState.Clear();
            }

            return View("Index", viewModel);
        }

    }
}
