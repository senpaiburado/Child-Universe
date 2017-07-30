using Child_Universe.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace Child_Universe.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        Context Context = new Context();

        public ActionResult Sign()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }

        public ActionResult Logout()
        {
            if (User.Identity.IsAuthenticated)
                FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public object Login(LogRegModel model)
        {
            User user = Context.Users.SingleOrDefault(x => x.Login.ToLower() == model.LoginModel.Login.ToLower());
            if (user == null)
                user = Context.Users.SingleOrDefault(x => x.EmailAdress.ToLower() == model.LoginModel.Login.ToLower());
            if (user == null)
                return "Користувача з заданим логіном не знайдено.";
            if (user.Password == model.LoginModel.Password)
            {
                FormsAuthentication.SetAuthCookie(user.Login, true);
                return RedirectToAction("Index", "Home");
            }
            else
                return "Пароль не вірний.";
        }

        [HttpPost]
        public object Register(LogRegModel model)
        {
            if (model.RegisterModel.PhoneNumber == null)
                model.RegisterModel.PhoneNumber = "";
            if (Context.Users.SingleOrDefault(x => x.Login.ToLower() == model.RegisterModel.Login.ToLower()) != null)
                return "Користувач з заданим логіном вже зареєстрований.";
            if (Context.Users.SingleOrDefault(x => x.EmailAdress.ToLower() == model.RegisterModel.EmailAdress.ToLower()) != null)
                return "Користувач з заданою електронною поштою вже зареєстрований.";
            User user = new User();
            user.Login = model.RegisterModel.Login;
            user.Password = model.RegisterModel.Password;
            user.Firstname = model.RegisterModel.Firstname;
            user.Lastname = model.RegisterModel.Lastname;
            user.EmailAdress = model.RegisterModel.EmailAdress;
            user.PhoneNumber = model.RegisterModel.PhoneNumber;
            Context.Users.Add(user);
            Context.SaveChanges();
            FormsAuthentication.SetAuthCookie(user.Login, true);
            return RedirectToAction("Index", "Home");
        }
    }
}