using MetalCast.Context;
using MetalCast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalCast.Controllers
{
    public class CuentaUsuarioController : Controller
    {
        private MetalCastContext bd = new MetalCastContext();

        // GET: CuentaUsuario
        public ActionResult Index()
        {
            using (MetalCastContext db = new MetalCastContext())
            {
                return View();
            }                
        }

        /*public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Usuario cuenta)
        {
            if (ModelState.IsValid)
            {
                using (MetalCastContext db = new MetalCastContext())
                {
                    db.Usuario.Add(cuenta);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = cuenta.usurioNombre + " " + cuenta.email + " Registracion exitosa!";
            }
            return View();
        }*/

        //Inicio de secion 
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario sesion)
        {
            using (MetalCastContext db = new MetalCastContext())
            {
                var usuario = bd.Usuario.Single(u=>u.usurioNombre == sesion.usurioNombre && u.usuarioPassword == sesion.usuarioPassword);
                if (usuario != null)
                {
                    Session["UsuarioID"] = usuario.ID.ToString();
                    Session["UsuarioNombre"] = usuario.usurioNombre.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "El nombre o la contraseña son erroneos");
                }          
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UsuarioID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}