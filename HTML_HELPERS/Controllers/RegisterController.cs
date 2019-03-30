﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTML_HELPERS.Models;


namespace HTML_HELPERS.Controllers
{
    public class RegisterController : Controller
    {
        

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Form()
        {
            Models.Register modelo = new Models.Register();
            ViewData["register"] = modelo.getDatos();
            return View();
        }
    
        public ActionResult DatosObtenidos()
        {
            if (ModelState.IsValid)
            {
                Register datos = new Register();


                //datos.Cedula = int.Parse(Request.Form["Edad"].ToString());///Cambiar el tipo a la cedula y a las que faltan
                //datos.Nombre = Request.Form["Nombre"].ToString();
                //datos.Apellido = Request.Form["Apellido"].ToString();
                //datos.Edad = int.Parse(Request.Form["Edad"].ToString());
                //datos.Telefono = Request.Form["Telefono"].ToString();
                //datos.Correo = Request.Form["Correo"].ToString();
                //datos.Genero = Request.Form["Genero"].ToString();
                //datos.Estado = Request.Form["Estado"].ToString();
                //datos.Hobbys = Request.Form["Hobbys"].ToString();

                return View(datos);
            }
            else
            {
                return View();
            }
        }
    }
}