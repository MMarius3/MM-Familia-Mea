using Familia_2._0.DAL;
using Familia_2._0.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Familia_2._0.Controllers
{
    [Authorize]
    public class SubscriptionsController : Controller
    {
        private ProjectContext db = new ProjectContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OneMonth()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("one-month")]
        public ActionResult OneMonth([Bind(Include = "Payment,Address")] Subscription subscription)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string userId = null;

                    var claimsIdentity = (ClaimsIdentity)User.Identity;

                    var userIdClaim = claimsIdentity.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
                    if (userIdClaim != null)
                    {
                        userId = userIdClaim.Value;
                    }
                    subscription.OwnerID = userId;//Membership.GetUser(User.Identity.Name).;
                    subscription.Type = SubscriptionType.one;
                    db.Subscriptions.Add(subscription);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(subscription);
        }

        public ActionResult HalfYear()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("half-year")]
        public ActionResult HalfYear([Bind(Include = "Payment,Address")] Subscription subscription)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string userId = null;

                    var claimsIdentity = (ClaimsIdentity)User.Identity;

                    var userIdClaim = claimsIdentity.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
                    if (userIdClaim != null)
                    {
                        userId = userIdClaim.Value;
                    }
                    subscription.OwnerID = userId;//Membership.GetUser(User.Identity.Name).;
                    subscription.Type = SubscriptionType.six;
                    db.Subscriptions.Add(subscription);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(subscription);
        }

        public ActionResult OneYear()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("one-year")]
        public ActionResult OneYear([Bind(Include = "Payment,Address")] Subscription subscription)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string userId = null;

                    var claimsIdentity = (ClaimsIdentity)User.Identity;

                    var userIdClaim = claimsIdentity.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
                    if (userIdClaim != null)
                    {
                        userId = userIdClaim.Value;
                    }
                    subscription.OwnerID = userId;//Membership.GetUser(User.Identity.Name).;
                    subscription.Type = SubscriptionType.twelve;
                    db.Subscriptions.Add(subscription);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(subscription);
        }
    }
}