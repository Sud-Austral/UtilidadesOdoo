﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class TURNERController : Controller
    {
        // GET: TURNER
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EleccionesCHL()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();
        }


        public ActionResult EleccionesAlcalde()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();
        }

        public ActionResult EleccionesConsejal()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();
        }

        public ActionResult EleccionesConstituyente()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();
        }

        public ActionResult EleccionesConstituyentePubloI()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();
        }

        public ActionResult EleccionesGobernador()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();
        }

        public ActionResult Carga()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();

        }
        public ActionResult Carga2()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();

        }

        public ActionResult Carga3()
        {
            ViewBag.tiktok = "https://www.tiktok.com/@dataintelligencechile?";
            return View();

        }



    }
}