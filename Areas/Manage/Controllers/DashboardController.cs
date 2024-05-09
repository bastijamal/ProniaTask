using System;
using Microsoft.AspNetCore.Mvc;

namespace ProniaTask.Areas.Views.Dashboard
{
    [Area("Manage")]


    public class DashboardController:Controller
	{

		public IActionResult Index()
		{
            return View();
		}
	}
}

