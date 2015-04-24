using CompressionTester.Helpers;
using CompressionTester.Models;
using System.Web.Mvc;

namespace CompressionTester.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Compress()
        {
            return View(new CompressModel());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Compress(CompressModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                model.Output = CompressionHelper.Compress(model.Input);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Decompress()
        {
            return View(new CompressModel());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Decompress(CompressModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                model.Output = CompressionHelper.Decompress(model.Input);
            }

            return View(model);
        }
    }
}