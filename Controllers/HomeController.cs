using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController:Controller
    {
        // localhost
        //localhost/home
        public IActionResult Index()
        {

            int saat = DateTime.Now.Hour;

            //ViewBag.Selamlama = saat>12 ? "İyi Günler":"Günaydın";
            //ViewBag.UserName ="Betül";

            ViewData["Selamlama"] = saat>12 ? "İyi Günler":"Günaydın";
            int UserCount = Repository.Users.Where(info=> info.WillAttend == true).Count();
            //ViewData["UserName"] = "Betül";

            var meetingInfo = new Meetinginfo(){
                Id=1,
                Location="İstanbul,Abc Kongre Merkezi",
                Date =new DateTime(2024 ,01,20,20,0,0),
                NumberofPeople = UserCount
            };

            return View(meetingInfo); 
        }
        
    }

}