using System.Linq;
using Convertor.Data;
using Convertor.Models;
using Convertor.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Convertor.Controllers
{
    public class RequestController : Controller
    {
        public IRepositoryWrapper _repositoryWrapper { get; }
        private const int PAGE_SIZE = 7;

        [TempData]
        public string Message { get; set; }

        public RequestController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        // GET: /<controller>/

        [HttpGet]
        public IActionResult Add()
        {
            PopulateCategoryDDL();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Conversion conversion)
        {
            if (ModelState.IsValid)
            {
                conversion.isConversionRequest = true;
                _repositoryWrapper._conversions.Create(conversion);
                Message = $"Conversion with Id: {conversion.ConversionId} was successfully added";
                return RedirectToAction("Index", "Request");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Index(string sortBy, int pageNumber = 1)
        {
            ViewData["KeySortParams"] = string.IsNullOrEmpty(sortBy) ? "ConversionId_Desc" : "";
            ViewData["NameSortParams"] = sortBy == "ConversionName_Desc" ? "ConversionName" : "ConversionName_Desc";
            ViewData["FromSortParams"] = sortBy == "ConversionFrom_Desc" ? "ConversionFrom" : "ConversionFrom_Desc";
            ViewData["ToSortParams"] = sortBy == "ConversionTo_Desc" ? "ConversionTo" : "ConversionTo_Desc";

            ViewData["PageNumber"] = pageNumber;
            ViewData["Message"] = Message;

            if (string.IsNullOrEmpty(sortBy))
                sortBy = "ConversionId";

            bool isDescending = false;
            if (sortBy.EndsWith("_Desc"))
            {
                sortBy = sortBy.Substring(0, sortBy.Length - 5);
                isDescending = true;
            }

            return isDescending ? View(new ConversionsViewModel()
            {
                conversions = _repositoryWrapper._conversions.GetAllConversionAsc(sortBy).Skip((pageNumber - 1) * PAGE_SIZE).Take(PAGE_SIZE),
                pagingInfo = new PagingInfo()
                {
                    CurrentPage = pageNumber,
                    ItemsPerPage = PAGE_SIZE,
                    TotalItems = _repositoryWrapper._conversions.FindByCondition(e => !e.isConversionRequest).Count()
                }

            }) : View(new ConversionsViewModel()
            {
                conversions = _repositoryWrapper._conversions.GetAllConversionDesc(sortBy).Skip((pageNumber - 1) * PAGE_SIZE).Take(PAGE_SIZE),
                pagingInfo = new PagingInfo()
                {
                    CurrentPage = pageNumber,
                    ItemsPerPage = PAGE_SIZE,
                    TotalItems = _repositoryWrapper._conversions.FindByCondition(e => !e.isConversionRequest).Count()
                }
            });
        }

        [HttpGet]
        public IActionResult Edit(string Id)
        {
            PopulateCategoryDDL(Id);
            return View(_repositoryWrapper._conversions.FindByCondition(e => e.ConversionId == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Edit(Conversion conversion)
        {
            if (ModelState.IsValid)
            {
                _repositoryWrapper._conversions.Update(conversion);
                return RedirectToAction("Index", "Request");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Delete(string Id)
        {
            return View(_repositoryWrapper._conversions.FindByCondition(e => e.ConversionId == Id).FirstOrDefault());
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConversion(Conversion conversion)
        {
            string Id = conversion.ConversionId;
            conversion = _repositoryWrapper._conversions.FindByCondition(e => e.ConversionId == Id).FirstOrDefault();
            if (conversion != null)
            {
                _repositoryWrapper._conversions.Delete(conversion);
                Message = $"Conversion with Id: {Id} was successfully deleted";
                return RedirectToAction("Index", "Request");
            }
            else
            {
                ViewData["ErrorMessage"] = "Unable To Delete, Try Again";
                return View(_repositoryWrapper._conversions.FindByCondition(e => e.ConversionId == Id).FirstOrDefault());
            }
        }

        private void PopulateCategoryDDL(object selectedObject = null)
        {
            ViewBag.Categories = new SelectList(_repositoryWrapper._categories.FindAll(), "CategoryId", "CategoryName", selectedObject);
        }
    }
}
