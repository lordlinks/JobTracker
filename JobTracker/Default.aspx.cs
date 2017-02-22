using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobTracker
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JobTrackerEntities db = new JobTrackerEntities();
            var MethodList = from meth in db.Contacts select meth;
            List<Contact> Methods = MethodList.ToList();
            methodDD.DataSource = Methods;
            methodDD.DataValueField = "contact_id";
            methodDD.DataTextField = "find";
            methodDD.Items.Insert(0, new ListItem("Discovery Method", "0"));
            methodDD.DataBind();

            var CompanyList = from bis in db.Businesses select bis;
            List<Business> Businesses = CompanyList.ToList();
            bisDD.DataSource = Businesses;
            bisDD.DataValueField = "business_id";
            bisDD.DataValueField = "name";
            bisDD.Items.Insert(0, new ListItem("Select Business", "0"));
            bisDD.DataBind();
        }

        protected void add_new(object sender, EventArgs e)
        {
            JobTrackerEntities db = new JobTrackerEntities();
            Business objBiz = new Business();
            objBiz.name = Bname.Value;
            objBiz.contact_no = Tel.Value;
            db.Businesses.Add(objBiz);
            db.SaveChanges();
        }

        protected void Method1(object sender, EventArgs e)
        {

        }
    }
}