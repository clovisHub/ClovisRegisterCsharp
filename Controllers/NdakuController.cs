using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CocoWebApi.Models;

namespace CocoWebApi.Controllers
{
    public class NdakuController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult gotoServer(FormCollection form)
        {
            bool added = false;
            
            //Ichild child = (Ichild) Cleaner.getMutu();
            Table_Coco_People child = new Table_Coco_People();
            string prenom = form["field1"].ToString();
            string nom = form["field2"].ToString();
            string postnom = form["field3"].ToString();
            string address = form["field4"].ToString();
            string city = form["field5"].ToString();
            string zip = form["field6"].ToString();
            string telephone = form["field7"].ToString();

            if ("bad" == Cleaner.removeSqlCommands(prenom))
            {
               // return Redirect();
            }
            else if ("bad" == Cleaner.removeSqlCommands(nom))
            {
                // return Redirect();
            }
            else if ("bad" == Cleaner.removeSqlCommands(postnom))
            {
                // return Redirect();
            }
            else if ("bad" == Cleaner.removeSqlCommands(address))
            {
                // return Redirect();
            }
            else if ("bad" == Cleaner.removeSqlCommands(city))
            {
                // return Redirect();
            }
            else if ("bad" == Cleaner.removeSqlCommands(zip))
            {
                // return Redirect();
            }
            else if ("bad" == Cleaner.removeSqlCommands(telephone))
            {
                // return Redirect();
            }
            else
            {
                
                if (!zip.Contains("03") || !zip.Contains("04"))
                {
                  // return Redirect();
                }

                child.first_name = prenom;
                child.last_name = nom;
                child.middle_name = postnom;
                child.addresse = address;
                child.city = city;
                child.code_postal = Convert.ToInt32(zip);
                child.telephone = Convert.ToInt32(telephone);
            }

            IProvider provider = new CongoSanduku();
            added = provider.bankisaMutu(child);

            return View();
        }

        public ActionResult Info()
        {
            return View();
        }


    }
}