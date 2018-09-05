using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ClassLibrary2.DataConnection;
using ClassLibrary2.Entity.Customer;


namespace CodeFirst3.Controller
{
    public class CustomerController : System.Web.Mvc.Controller
    {
        private DataContext db = new DataContext();

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customer_PersonalDetail.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_PersonalDetail customer_PersonalDetail = db.Customer_PersonalDetail.Find(id);
            if (customer_PersonalDetail == null)
            {
                return HttpNotFound();
            }
            return View(customer_PersonalDetail);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Password,ConfirmPassword,City,ContactPerson,Phone,Email,Notes")] Customer_PersonalDetail customer_PersonalDetail)
        {
            if (ModelState.IsValid)
            {
                db.Customer_PersonalDetail.Add(customer_PersonalDetail);


                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(customer_PersonalDetail);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_PersonalDetail customer_PersonalDetail = db.Customer_PersonalDetail.Find(id);
            if (customer_PersonalDetail == null)
            {
                return HttpNotFound();
            }
            return View(customer_PersonalDetail);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Password,ConfirmPassword,City,ContactPerson,Phone,Role,Email,Notes")] Customer_PersonalDetail customer_PersonalDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer_PersonalDetail).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer_PersonalDetail);
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_PersonalDetail customer_PersonalDetail = db.Customer_PersonalDetail.Find(id);
            if (customer_PersonalDetail == null)
            {
                return HttpNotFound();
            }
            return View(customer_PersonalDetail);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Customer_PersonalDetail customer_PersonalDetail = db.Customer_PersonalDetail.Find(id);
            db.Customer_PersonalDetail.Remove(customer_PersonalDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }




        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(Customer_PersonalDetail Customer_PersonalDetail)
        {
            if (Customer_PersonalDetail.Email!=null && Customer_PersonalDetail.Password!=null)
            {
                using (DataContext dbContext = new DataContext())
                {
                    var obj = dbContext.Customer_PersonalDetail.Where(u => u.Email.Equals(Customer_PersonalDetail.Email)&& u.Password.Equals(Customer_PersonalDetail.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["Email"] = obj.Email.ToString();
                        Session["Password"] = obj.Password.ToString();
                        return RedirectToAction("LoggedIn");
                    }
                }
            }

            return View(Customer_PersonalDetail);

        }

        public ActionResult LoggedIn()
        {
            if (Session["Email"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LogIn");
            }
        }
  
}


 
}
