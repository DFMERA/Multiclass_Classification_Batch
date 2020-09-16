using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Multiclass_Classification_Batch.Models;
using System.Text.Json;
using System.IO;
using Multiclass_Classification_BatchML.Model;

namespace Multiclass_Classification_Batch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string pathPrediction = @"..\..\..\..\Data\Predict\";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<FileResult> Index(IFormFile formFile)
        {
            if (formFile != null && formFile.Length > 0)
            {
                string pathImgPredict = Path.Combine(pathPrediction, "hotel_bookings_batch.csv");
                pathImgPredict = ConsumeModel.GetAbsolutePath(pathImgPredict);
                pathImgPredict = Path.GetFullPath(pathImgPredict);

                using (var stream = System.IO.File.Create(pathImgPredict))
                {
                    await formFile.CopyToAsync(stream);
                }

                var predictionsFile = ConsumeModel.PredictBatch(pathImgPredict);

                var streamResult = await System.IO.File.ReadAllBytesAsync(predictionsFile);

                return File(streamResult, "application/csv;charset=utf-8", "Predictions.csv");
            }
            return null;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
