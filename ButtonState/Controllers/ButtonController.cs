using ButtonState.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ButtonState.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();
        Random ran = new Random();

        // GET: Button
        public ActionResult Index()
        {
            for(int i=0; i<25; i++)
            {
                if (ran.Next(10) > 5)
                    buttons.Add(new ButtonModel(1));
                else if (ran.Next(10) > 5)
                {
                    buttons.Add(new ButtonModel(2));
                }
                else
                {
                    buttons.Add(new ButtonModel(3));
                }
                   
            }
            return View("Index", buttons);
        }

        public ActionResult HandleButtonClick(string mine)
        {
            int buttonNumber = Int32.Parse(mine);
            if (buttons[buttonNumber].State == 1)
            {
                buttons[buttonNumber].State = 2;
            }
            else if (buttons[buttonNumber].State == 2)
            {
                buttons[buttonNumber].State = 3;
            }
            else
            {
                buttons[buttonNumber].State = 1;
            }

            return View("Index", buttons);
        }
    }
}