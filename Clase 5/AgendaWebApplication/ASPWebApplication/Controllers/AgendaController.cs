using ASPWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPWebApplication.Controllers
{
    public class AgendaController : Controller
    {
        static List<Contacto> contactos = new List<Contacto>();

        // GET: Agenda
        public ActionResult AgendaWEB()
        {
            return View();
            //return View("~/Views/Agenda/Agenda.cshtml");
        }

        public ActionResult Contactos()
        {
            contactos = (List<Contacto>)Session["listaContactos"];

            if (contactos == null)
            {
                contactos = new List<Contacto>();
            }

            return View(contactos);
            //return View("~/Views/Agenda/Agenda.cshtml");
        }

        // POST: Agenda/Create
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            try
            {
                contactos = (List<Contacto>)Session["listaContactos"];

                var contacto = new Contacto();
                contacto.Nombre = form["nombre"];
                contacto.Telefono = form["telefono"];


                if (contactos == null)
                {
                    contactos = new List<Contacto>();
                }

                contactos.Add(contacto);

                Session["listaContactos"] = contactos;

                return View("AgendaWEB");
            }
            catch
            {
                return View();
            }
        }
    }
}
