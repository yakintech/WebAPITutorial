using Microsoft.AspNetCore.Mvc;
using WebAPITutorial.Models.Dto;
using WebAPITutorial.Models.ORM;

namespace WebAPITutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebUserController : Controller
    {
        AlohaCRMContext context;
        public WebUserController()
        {
            context = new AlohaCRMContext();
        }

        [HttpGet]
        public List<WebUser> GetAll()
        {
            return context.WebUsers.ToList();
        }

        [HttpGet("{id}")]
        public WebUser Get(int id)
        {
            return context.WebUsers.Find(id);
        }

        [HttpPost]
        public WebUser Post(WebUserPostRequestDto model)
        {
            WebUser webUser = new WebUser();
            webUser.Surname = model.Surname.Trim();
            webUser.Name = model.Name.Trim();
            webUser.Email = model.EMail.Trim().ToLower();
            webUser.AddDate = DateTime.Now;



            context.WebUsers.Add(webUser);
            context.SaveChanges();

            return webUser;
        }

        [HttpDelete]
        public WebUser Delete(int id)
        {
            WebUser webUser = context.WebUsers.Find(id);
            context.WebUsers.Remove(webUser);
            context.SaveChanges();
            return webUser;
        }
    }
}
