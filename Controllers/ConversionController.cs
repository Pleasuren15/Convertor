using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Convertor.Data;
using Convertor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Convertor.Controllers
{
    public class ConversionController : Controller
    {
        public IRepositoryWrapper repositoryWrapper { get; }

        public ConversionController(IRepositoryWrapper repositoryWrapper)
        {
            this.repositoryWrapper = repositoryWrapper;
        }

        // GET: /<controller>/
        public IActionResult Temperature()
        {
            return View(repositoryWrapper._categories.FindByCategoryWithConversions("Temperature"));
        }
        public IActionResult Angle()
        {
            return View(repositoryWrapper._categories.FindByCategoryWithConversions("Angle"));
        }
        public IActionResult Area()
        {
            return View(repositoryWrapper._categories.FindByCategoryWithConversions("Area"));
        }
        public IActionResult Length()
        {
            return View(repositoryWrapper._categories.FindByCategoryWithConversions("Length"));
        }
        public IActionResult Speed()
        {
            return View(repositoryWrapper._categories.FindByCategoryWithConversions("Speed"));
        }
        public IActionResult Time()
        {
            return View(repositoryWrapper._categories.FindByCategoryWithConversions("Time"));
        }
        public IActionResult Volume()
        {
            return View(repositoryWrapper._categories.FindByCategoryWithConversions("Volume"));
        }
        public IActionResult Weight()
        {
            return View(repositoryWrapper._categories.FindByCategoryWithConversions("Weight"));
        }

        public IActionResult Search(string searchBy)
        {
            ViewData["SearchBy"] = searchBy;
            return View(repositoryWrapper._conversions.FindByCondition(e => e.ConversionName.Contains(searchBy)));
        }

        public IActionResult Convert(string conversionId, double _valueFrom = 0, double _valueTo = 0, int _decimalPlaces = 2)
        {
            Conversion conversion = repositoryWrapper._conversions.FindByConversionWithCategory(conversionId);
            conversion.ConversionFromValue = _valueFrom;
            conversion.ConversionToValue = (double)Math.Round(_valueTo, _decimalPlaces);
            return View(conversion);
        }

        [HttpGet]
        public IActionResult Swap(string conversionId)
        {
            string SwappedId = conversionId.Substring(5, 3) + conversionId.Substring(3, 2) + conversionId.Substring(0, 3);

            return RedirectToAction("Convert", "Conversion", repositoryWrapper._conversions.FindByConversionWithCategory(SwappedId));
        }

        public IActionResult Calculate(Conversion conversion)
        {
            double _From = conversion.ConversionFromValue;
            conversion = repositoryWrapper._conversions.FindByConversionWithCategory(conversion.ConversionId);
            conversion.ConversionFromValue = _From;
            conversion.ConversionToValue = CCalculateFactoryPattern.PerfomConversion(conversion.ConversionId, conversion.ConversionFromValue);

            return RedirectToAction("Convert", "Conversion", new { conversionId = conversion.ConversionId, _valueFrom = _From, _valueTo = conversion.ConversionToValue });
        }
    }
}
