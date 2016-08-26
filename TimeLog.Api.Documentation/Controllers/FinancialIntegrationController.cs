﻿namespace TimeLog.Api.Documentation.Controllers
{
    using System.Web.Mvc;

    public class FinancialIntegrationController : Controller
    {
        // GET: FinancialIntegration
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult DynamicsNav()
        {
            return this.View("DynamicsNav");
        }

        public ActionResult DynamicsAx()
        {
            return this.View("Index");
        }

        public ActionResult ExactOnline()
        {
            return this.View("ExactOnline");
        }

        public ActionResult VismaAdministration()
        {
            return this.View("Index");
        }

        public ActionResult Economic()
        {
            return this.View("e-conomic");
        }

        public ActionResult Flows()
        {
            return this.View("Index");
        }

        public ActionResult Tests()
        {
            return this.View("Index");
        }

        public ActionResult Install()
        {
            return this.View("Index");
        }
    }
}