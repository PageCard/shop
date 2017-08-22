using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FineUIMvc.EmptyProject.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnHello_Click()
        {
            Alert.Show("你妹 FineUI！", MessageBoxIcon.Warning);

            return UIHelper.Result();
        }



        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnLogin_Click(string tbxUserName, string tbxPassword)
        {
            if (tbxUserName == "admin" && tbxPassword == "admin")
            {
                ShowNotify("成功登录！", MessageBoxIcon.Success);
            }
            else
            {
                ShowNotify("用户名或密码错误！", MessageBoxIcon.Error);
            }

            return UIHelper.Result();
        }


        // GET: Themes
        public ActionResult Themes()
        {
            return View();
        }
    }
}