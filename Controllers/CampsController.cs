using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileBackend.Controllers
{
    public class CampsController : Controller
    {
        [HttpGet("api/camps")]
        public IActionResult Get()
        {
            return Ok(new { name = "Shawn of the Dead", FavoriteColor = "Plum" });
        }
    }
}
