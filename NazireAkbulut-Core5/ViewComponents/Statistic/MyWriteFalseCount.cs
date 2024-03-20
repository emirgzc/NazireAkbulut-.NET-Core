﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Statistic
{
    public class MyWriteFalseCount : ViewComponent
    {
        private readonly IMyWriteService _myWriteService;

        public MyWriteFalseCount(IMyWriteService myWriteService)
        {
            _myWriteService = myWriteService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _myWriteService.MyWriteFalseCount();
            ViewBag.count = values;
            return View(values);
        }
    }
}
