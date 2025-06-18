using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class ClientController : Controller
    {

        public ActionResult Index()
        {
            var Clients = ClientRepository.ClientList();
            return View(Clients);
        }


        public ActionResult Client()
        {
            return View("ClientForm", new Client());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Client client)
        {
            if (ModelState.IsValid)
            {

                ClientRepository.Add(client);


                return RedirectToAction("Index");

            }
            return View("ClientForm", client);


        }


        public ActionResult Edit(int id)
        {
            var Client = ClientRepository.GetById(id);
            if (Client == null)
                return HttpNotFound();
            return View("ClientForm", Client);
        }

        [HttpPost]
        public ActionResult Edit(Client Client)
        {
            if (ModelState.IsValid)
            {
                ClientRepository.Update(Client);
                return RedirectToAction("Index");

            }

            return View("ClientForm", Client);
        }


        public ActionResult Delete(int id)
        {
            var Client = ClientRepository.GetById(id);
            if (Client == null)
                return HttpNotFound();
            return View(Client);

        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ClientRepository.Remove(id);
            return RedirectToAction("Index");
        }

    }
}