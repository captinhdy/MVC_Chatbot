using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetcoreMVC.Models;

namespace dotnetcoreMVC.Controllers
{
    public class BotController : Controller
    {
        [ActionContext]
        public ActionContext ActionContext { get; set; }

        [HttpGet]
        public IActionResult SubmitQuestion(string Question)
        {
           
            try
            {
                BotViewModel botViewModel = new BotViewModel();
                
                return Ok(botViewModel.Predict(Question));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}