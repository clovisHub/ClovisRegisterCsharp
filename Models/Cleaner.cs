using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocoWebApi.Models
{
    public sealed class Cleaner
    {
        public static Table_Coco_People getMutu()
        {
            return new Table_Coco_People();
        }

        public static string removeSqlCommands(string entry)
        {
            string bad = "good";

            if (entry.Contains("."))
            {
                bad = "bad";
            }
            else if (entry.Contains("*"))
            {
                bad = "bad";
            }
            else if (entry.Contains("select"))
            {
                bad = "bad";
            }
            else if (entry.Contains("delete"))
            {
                bad = "bad";
            }
            else if (entry.Contains("=>"))
            {
                bad = "bad";
            }
            else if (entry.Contains("("))
            {
                bad = "bad";
            }
            else if (entry.Contains(")"))
            {
                bad = "bad";
            }
            else if (entry.Contains("where"))
            {
                bad = "bad";
            }
            else if (entry.Contains("from"))
            {
                bad = "bad";
            }
            else
            {
                //nothing
            }
            return bad;
        }
    }
}