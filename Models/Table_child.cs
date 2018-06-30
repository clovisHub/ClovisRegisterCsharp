using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CocoWebApi.Models;

namespace CocoWebApi.Models
{
    public class Table_child:Table_Coco_People, Ichild
    {
        private Table_child() { }

        public Table_child getCHild()
        {
            if (this != null)
            {
                return this;
            }

           return new Table_child();
        }
    }
}