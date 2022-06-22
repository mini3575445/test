﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _02View.Models;

namespace _02View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() //action把list傳到View
        {
            string[] id = { "A01", "A02", "A03", "A04", "A05", "A06", "A07" };
            string[] name = { "瑞豐夜市", "新堀江商圈", "六合夜市", "青年夜市", "花園夜市", "大東夜市", "武聖夜市" };
            string[] address = { "813高雄市左營區裕誠路", "800高雄市新興區玉衡里", "800台灣高雄市新興區六合二路",
                "80652高雄市前鎮區凱旋四路758號", "台南市北區海安路三段533號", "台南市東區林森路一段276號",
                "台南市中西區武聖路69巷42號" };

            


            //宣告List
            //類別            名稱  
            List<NightMarket> list = new List<NightMarket>();   //List物件:泛型(用NightMarket做一個泛型
            //<>裡面放型別

            NightMarket nm; //一個變數空間

            for (int i = 0; i < id.Length; i++)
            {
                //每次創造新記憶體加入ID.Name.Address後再丟入list

                nm = new NightMarket(); //多個值的空間
                nm.Id = id[i];
                nm.Name = name[i];
                nm.Address = address[i];
                list.Add(nm);
            }
            nm = new NightMarket();
            nm.Id = "B01";
            nm.Name = "大大大夜市";
            nm.Address = "高雄市前鎮區";
            list.Add(nm);

            nm = new NightMarket();
            nm.Id = "B02";
            nm.Name = "小小小夜市";
            nm.Address = "高雄市三民區";
            list.Add(nm);

            return View(list);
            
        }

        public ActionResult Details(string id)  //基本上都是傳PK
        {
            ViewBag.ID = id;
            //select * from NightMarket where Id = 'A01'
            return View();
        }
        //http://Your.DomainName.
        //若參數名稱是id的話，參數可以不使用?id=xxx

        public ActionResult Razor(string id)  
        {     
            return View();
        }

    }
}