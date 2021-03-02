using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingmallCore.Controllers
{
    public class HotboomController : Controller
    {
        //代购订单
        public IActionResult daigoudingdan()
        {
            return View();
        }
        //转运订单
        public IActionResult zhuanyundingdan()
        {
            return View();
        }

        //转运详情
        public IActionResult zhuanyundingdanXQ(int id)
        { 
            return View();
        }

        //首页
        public IActionResult ShouYe()
        {
            return View();
        }

        //个人信息
        public IActionResult gerenxinxi()
        {
            return View();
        }

        //申请发货
        public IActionResult shenqingchuku()
        {
            return View();
        }

        //填写地址
        public IActionResult tianxiedizhi()
        {
            return View();
        }
    }
}
