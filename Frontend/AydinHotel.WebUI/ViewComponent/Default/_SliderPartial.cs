﻿using Microsoft.AspNetCore.Mvc;

namespace AydinHotel.WebUI.ViewComponent.Default
{
    public class _SliderPartial : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
