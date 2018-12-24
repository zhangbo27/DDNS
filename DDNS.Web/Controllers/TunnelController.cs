﻿using Microsoft.AspNetCore.Mvc;

namespace DDNS.Web.Controllers
{
    public class TunnelController : Controller
    {
        /// <summary>
        /// 隧道列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Index(int? userId)
        {
            if (userId == null)
            {
                return NotFound();
            }

            return View();
        }

        /// <summary>
        /// 申请开通隧道
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 审核申请隧道
        /// </summary>
        /// <returns></returns>
        public IActionResult Audit()
        {
            return View();
        }
    }
}