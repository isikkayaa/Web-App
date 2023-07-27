using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    //[Authorize(Roles ="admin,manager")]
    ///*login olan girebilir sadece, controller seviyesinde authorize attributeü eklersek içindeki tüm actionları giriste kontrol eder login mi değil mi diye*/
    [Authorize(Roles = "admin")]  /*admin rolündeki adam bu actionları calıstırabilsin*/
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
