using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingmallCore.Controllers
{
    public class ShoppingwhjController : Controller
    {
        //预报
        public IActionResult Yubao()
        {
            return View();
        }
        //预报2
        public IActionResult HuowuYubao()
        {
            return View();
        }
        //钱包
        public IActionResult Qianbao()
        {
            return View();
        }
        //收藏
        public IActionResult Shouchang()
        {
            return View();
        }

        //我的地址
        public IActionResult Wodedizhi()
        {
            return View();
        }

        //我的地址 新增
        public IActionResult WodedizhiAdd()
        {
            return View();
        }

        //我的地址 修改
        public IActionResult WodedizhiUpdate(int id,int ids)
        {
            ViewBag.id = id;
            ViewBag.ids = ids;
            return View();
        }


        //仓库地址
        public IActionResult CangkuDizhi()
        {
            return View();
        }

    }
}
