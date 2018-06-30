using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocoWebApi.Models
{
    interface IProvider
    {
        List<Table_Coco_People> zuabango();
        bool bankisaMutu(Table_Coco_People mutu);
        bool bongisaMutu(Table_Coco_People mutu);
    }
}
