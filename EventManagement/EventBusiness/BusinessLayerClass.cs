using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementDataLayer;

namespace EventBusiness
{
    public class BusinessLayerClass
    {
        //  BUSINESS LAYER

        // Creating the object of Data layer class
        eventmngmtdatalayer datalayerobj = new eventmngmtdatalayer();

        // calling InsertUser function of datalayer class
        public string InsertUser(UsersTable usersdata)
        {
            string msg = datalayerobj.InsertUser(usersdata);
            return msg;
        }

        // calling InsertEvents function of datalayer class
        public string InsertEvents(EventsTable eventdata)
        {
            string msg = datalayerobj.InsertEvent(eventdata);
            return msg;
        }

        // calling InsertFlower function of datalayer class
        public string InsertFlowers(FlowerOrder flowerdata)
        {
            string msg = datalayerobj.InsertFlowers(flowerdata);
            return msg;
        }

        // calling InsertFood function of datalayer class
        public string InsertFood(FoodOrder fooddata)
        {
            string msg = datalayerobj.InsertFood(fooddata);
            return msg;
        }

        // calling function to get booking status of a particular user
        public DataTable getBookingstatusBYID(int id)
        {
            return datalayerobj.getBookingstatusBYID(id);
        }

        // validating user for booking events
        public string ValidationUserLogin(string email, string password)
        {

            return datalayerobj.ValidationUserLogin(email, password);
        }

        // calling function confirm booking
        public string ConfirmBooking(int user_id, int event_id)
        {
            return datalayerobj.ConfirmBooking(user_id, event_id);
        }

        // Validating Admin to access
        public string ValidationAdminLogin(string ui_username, string ui_password)
        {

            return datalayerobj.ValidationAdminLogin(ui_username, ui_password);
        }

        // calling notification function to return the count
        public int notificationcount()
        {
            return datalayerobj.notificationcount();
        }

        // returning the all the booking details
        public DataTable GetBookings()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = EventManagement; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from BookingStatus where status='Pending' or status='pending'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;

        }
       
        // Function is called to return the all user details to Admin page
        public DataTable GetUsers()
        {
            return datalayerobj.GetUsers();
        }

        // Function is called to return the all Events details to Admin page
        public DataTable GetEvents()
        {
            return datalayerobj.GetEvents();
        }

        // Function is called to return the event details of particular user to profile page
        public DataTable GetEventsByID(int id)
        {
            return datalayerobj.GetEventsByID(id);
        }

        // retrieving user id by email for state management
        public int GetUserID(string email)
        {
            return datalayerobj.GetUserID(email);
        }

        // retrieving particular user details to display on profile
        public DataTable GetUsersByID(int id)
        {
            return datalayerobj.GetUsersByID(id);
        }
    }
}
