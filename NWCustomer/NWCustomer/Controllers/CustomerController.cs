using NWCustomer.DAL;
using NWCustomer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NWCustomer.Controllers
{
    public class CustomerController : Controller
    {
        private PotentialsContext db = new PotentialsContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult WorkOrders()
        {
            return View();
        }

        public ActionResult NewOrder()
        {
            return View();
        }

        public ActionResult Summary()
        {
            return View();
        }

        public ActionResult Details(string type)
        {
            ViewBag.Type = type;
            return View();
        }
        public ActionResult OrderEntry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrderEntry(FormCollection form)
        {
            string compound = form["Compound"].ToString();
            List<string> assayTests = new List<string>();
            List<string> otherTests = new List<string>();
            if (form["option1"].ToString() == "true,false")
            {
                assayTests.Add("Biochemical Pharmacology");
            }
            if (form["option2"].ToString() == "true,false")
            {
                assayTests.Add("DiscoveryScreen");
            }
            if (form["option3"].ToString() == "true,false")
            {
                assayTests.Add("ImmunoScreen");
            }
            if (form["option4"].ToString() == "true,false")
            {
                assayTests.Add("ProfilingScreen");
            }
            if (form["option5"].ToString() == "true,false")
            {
                assayTests.Add("PharmaScreen");
            }
            if (form["option5"].ToString() == "true,false")
            {
                assayTests.Add("CustomScreen");
            }
            if (form["option6"].ToString() == "true,false")
            {
                otherTests.Add("Spot Analysis");
            }
            if (form["option7"].ToString() == "true,false")
            {
                otherTests.Add("Salicylate Testing");
            }
            if (form["option8"].ToString() == "true,false")
            {
                otherTests.Add("Permanganate Index");
            }
            WorkOrders workOrder = new WorkOrders();
            Compounds compounds = new Compounds();
            Invoices invoice = new Invoices();
            invoice.accID = 5;
            compounds.LTNum = 553645;
            compounds.compoundFinID = 2;
            if (ModelState.IsValid)
            {
                db.WorkOrders.Add(workOrder);
                db.SaveChanges();
                compounds.workOrderID = workOrder.workOrderID;
                db.Compounds.Add(compounds);
                db.SaveChanges();
                invoice.workOrderID = workOrder.workOrderID;
                db.Invoices.Add(invoice);
                db.SaveChanges();
            }
            foreach (string item in assayTests)
            { 
                Samples sample = new Samples();
                sample.assayID = db.Database.SqlQuery<int>("SELECT assayID FROM Assays WHERE Assays.name = @p0", "Biochemical Pharmacology").FirstOrDefault();
                sample.LTNum = compounds.LTNum;
                if (ModelState.IsValid)
                {
                    db.Samples.Add(sample);
                    db.SaveChanges();
                }
                IEnumerable<Tests> tests = db.Database.SqlQuery<Tests>("SELECT Tests.testID FROM Tests INNER JOIN Assay_Tests on Assay_Tests.testID = Tests.testID INNER JOIN Assays on Assays.assayID = Assay_Tests.assayID WHERE Assays.assayID = @p0", sample.assayID).ToList();
                foreach (var item2 in tests)
                {
                    testTube testTube = new testTube();
                    Serialized_Tests serializedTest = new Serialized_Tests();
                    testTube.sampleID = sample.sampleID;
                    serializedTest.testID = item2.testID;
                    serializedTest.testName = "Prototype test";
                    if (ModelState.IsValid)
                    {
                        db.Serialized_Tests.Add(serializedTest);
                        db.SaveChanges();
                        testTube.serialID = serializedTest.SerialTestID;
                        db.testTube.Add(testTube);
                        db.SaveChanges();
                    }
                }
                foreach (var item3 in otherTests)
                {
                    testTube testTube = new testTube();
                    testTube.sampleID = sample.sampleID;
                    Serialized_Tests serializedTest = new Serialized_Tests();
                    serializedTest.testID = db.Database.SqlQuery<int>("SELECT Tests.testID FROM Tests WHERE Tests.testName = @p0", item3).FirstOrDefault();
                    serializedTest.testName = "Prototype test";
                    if (ModelState.IsValid)
                    {
                        db.Serialized_Tests.Add(serializedTest);
                        db.SaveChanges();
                        testTube.serialID = serializedTest.SerialTestID;
                        db.testTube.Add(testTube);
                        db.SaveChanges();
                    }
                }
            }
            return View();
        }
    }
}