using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }



        [WebMethod]
        public static List<Save_Customer_DetailsResult> Save_Customer_Details(string Create_Date, string Mobile_Number, string Delivery_date)
        {
            try
            {
                DataClasses1DataContext d = new DataClasses1DataContext();
                List<Save_Customer_DetailsResult> response = d.Save_Customer_Details((Create_Date == "" ? DateTime.Now : Convert.ToDateTime(Create_Date)), Mobile_Number, Convert.ToDateTime(Delivery_date)).ToList();
                return response;
            }
            catch (Exception e)
            {
                return new List<Save_Customer_DetailsResult>();
            }
        }




        [WebMethod]
        public static List<get_customerResult> get_customer()
        {
            try
            {
                DataClasses1DataContext d = new DataClasses1DataContext();
                List<get_customerResult> respone = d.get_customer().ToList();
                return respone;
            }
            catch (Exception e)
            {
                return new List<get_customerResult>();
            }
        }

        //Save_item
        [WebMethod]
        public static List<Save_itemResult> Save_item(string customer_id, string item_Name, string Number_of_item,string item_price,string total_Amount,string Bill_id)
        {
            try
            {
                DataClasses1DataContext d = new DataClasses1DataContext();
                List<Save_itemResult> response = d.Save_item(Convert.ToInt32(customer_id), item_Name, Convert.ToInt32(Number_of_item), Convert.ToDouble(item_price), Convert.ToDouble(total_Amount), Bill_id).ToList();
                return response;
            }
            catch (Exception e)
            {
                return new List<Save_itemResult>();
            }
        }

        //Delete_item
        [WebMethod]
        public static List<Delete_itemResult> item_delete(string id)
        {
            try
            {
                DataClasses1DataContext d = new DataClasses1DataContext();
                List<Delete_itemResult> response = d.Delete_item(Convert.ToInt32(id)).ToList();
                return response;
            }
            catch (Exception e)
            {
                return new List<Delete_itemResult>();
            }
        }
    }
}