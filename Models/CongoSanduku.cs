using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocoWebApi.Models
{
   
    public sealed class CongoSanduku:IProvider
    {
        CongoDataEntities  batu = new CongoDataEntities();

        public List<Table_Coco_People> zuabango()
        {
           
            return batu.Table_Coco_Peoples.ToList();
        }

        public bool bankisaMutu(Table_Coco_People mutu)
        {
            batu.Table_Coco_Peoples.Add(mutu);
            batu.SaveChanges();
            return true;
        }

        public bool bongisaMutu(Table_Coco_People mutu)
        {
            bool aChanger = false;
            try {
                Table_Coco_People yaya;
                //if (mutu.id_member != null)
                
                    yaya = batu.Table_Coco_Peoples.SingleOrDefault(m => m.id_member == mutu.id_member);
                

                if (yaya != null)
                {
                    if (mutu.last_name != null && !mutu.last_name.Equals("")) {

                        yaya.last_name = mutu.last_name;
                    }
                    if (mutu.middle_name != null && !mutu.middle_name.Equals("")) {

                        yaya.middle_name = mutu.middle_name;
                    }
                    if (mutu.first_name != null && !mutu.first_name.Equals(""))
                    {
                        yaya.first_name = mutu.first_name;
                    }

                    if (mutu.city != null && !mutu.city.Equals(""))
                    {
                        yaya.city = mutu.city;
                    }

                    if (mutu.code_postal != null && !mutu.code_postal.Equals(""))
                    {
                        yaya.code_postal = mutu.code_postal;
                    }

                    if (mutu.addresse != null && !mutu.addresse.Equals(""))
                    {
                        yaya.addresse = mutu.addresse;
                    }

                    if (mutu.telephone != null)
                    {
                        yaya.telephone = mutu.telephone;
                    }
                    
                    aChanger = true;
                    batu.SaveChanges();
                }
            }
            catch (Exception message) {

                Console.WriteLine(message.ToString());
            }
           
            return aChanger;
        }

        public bool longolaMutu(Table_Coco_People mutu)
        {
            Table_Coco_People yaya = batu.Table_Coco_Peoples.SingleOrDefault(m => m.id_member == mutu.id_member);
            if (yaya != null)
            {
                batu.Table_Coco_Peoples.Remove(yaya);
                batu.SaveChanges();
                return true;
            }

            return false;
        }
    }
}