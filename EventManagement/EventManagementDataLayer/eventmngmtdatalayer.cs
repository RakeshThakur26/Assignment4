using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementDataLayer
{
    public class eventmngmtdatalayer
    {
        // DATA LAYER

        #region Objects
        // Creating object of entity model to start database
        EventManagementEntities eventmanagemententities = new EventManagementEntities();

        //creating object of UserTable entity (Table)
        UsersTable userobj = new UsersTable();

        // creating object of BookingStatus entity (Table)
        BookingStatu statusobj = new BookingStatu();
        #endregion


        #region Entity Framework Operation 
        // Inserting User data into UserTable After sign up
        public string InsertUser(UsersTable usersdata)
        {
            eventmanagemententities.UsersTables.Add(usersdata);
            eventmanagemententities.SaveChanges();
            return "User inerted";
        }

        // Inserting data into Events table for a perticular registered user
        public string InsertEvent(EventsTable eventdata)
        {
            eventmanagemententities.EventsTables.Add(eventdata);
            eventmanagemententities.SaveChanges();
            return "booking successfull";
        }

        // Inserting data into Flowers table booked by perticular registered user
        public string InsertFlowers(FlowerOrder flowerdata)
        {
            eventmanagemententities.FlowerOrders.Add(flowerdata);
            eventmanagemententities.SaveChanges();
            return "flower order inserted";
        }

        // Inserting data into FoodOrder table booked by perticular registered user
        public string InsertFood(FoodOrder fooddata)
        {
            eventmanagemententities.FoodOrders.Add(fooddata);
            eventmanagemententities.SaveChanges();
            return "food order inserted";
        }

        #endregion


        #region ADO.Net operation

        // ADO.net connection to Database
        public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = EventManagement; Integrated Security = True");
            return conn;
        }

        // Retreiving the booking status of a user by its id
        public DataTable getBookingstatusBYID(int id)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select booking_id,book_date,status from EventsTable as E INNER JOIN BookingStatus as B on B.user_id = E.user_id where B.user_id =" + id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader datareader = sqlCommand.ExecuteReader();
            DataTable dtbooking = new DataTable();
            dtbooking.Load(datareader);
            sqlConnection.Close();
            return dtbooking;
        }

        // Validating user using email and password
        public string ValidationUserLogin(string ui_email, string ui_password)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from UsersTable where email = '" + ui_email + "' and password ='" + ui_password + "'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            if (sdr.Read())
            {
                sqlConnection.Close();
                return "Success";
            }
            else
            {
                sqlConnection.Close();
                return "Fail";
            }
        }

        // Inserting Data into Booking status by verifying previous records
        public string ConfirmBooking(int user_id, int event_id)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select COUNT(*) from FoodOrder where user_id=" + user_id + "and event_id=" + event_id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            sqlConnection.Close();
            SqlCommand sqlCommand1 = new SqlCommand("select COUNT(*) from FlowerOrder where user_id=" + user_id + "and event_id=" + event_id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr1 = sqlCommand.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(sdr1);
            sqlConnection.Close();

            int foodcount = Convert.ToInt32(dt.Rows[0][0]);
            int flowercount = Convert.ToInt32(dt1.Rows[0][0]);
            string qry = "";

            if (foodcount > 1 && flowercount > 1)
                return "False";

            else if (foodcount == 1 && flowercount == 1)
                qry = "insert into BookingStatus values(" + 1 + "," + 1 + "," + user_id + ",'pending')";

            else if (foodcount == 2 && flowercount == 1)
                qry = "insert into BookingStatus values(" + 0 + "," + 1 + "," + user_id + ",'pending')";

            else
                qry = "insert into BookingStatus values(" + 1 + "," + 0 + "," + user_id + ",'pending')";

            SqlCommand cmd = new SqlCommand(qry, sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "True";
        }

        // Admin Validation
        public string ValidationAdminLogin(string ui_username, string ui_password)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = EventManagement; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from Admin where admin_id = '" + ui_username + "' and password ='" + ui_password + "'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            if (sdr.Read())
            {
                sqlConnection.Close();
                return "Success";
            }
            else
            {
                sqlConnection.Close();
                return "Fail";
            }
        }

        // Counting the notifications from the database
        public int notificationcount()
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select COUNT(*) from BookingStatus where status= 'pending' or status='Pending'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            DataTable dtcount = new DataTable();
            dtcount.Load(sdr);
            sqlConnection.Close();
            return Convert.ToInt32(dtcount.Rows[0][0]);
        }

        // Get all users details 
        public DataTable GetUsers()
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from UsersTable", sqlConnection);
            sqlConnection.Open();
            SqlDataReader druser = sqlCommand.ExecuteReader();
            DataTable dtUsers = new DataTable();
            dtUsers.Load(druser);
            sqlConnection.Close();
            return dtUsers;
        }

        // Get Events registered by all users
        public DataTable GetEvents()
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from EventsTable", sqlConnection);
            sqlConnection.Open();
            SqlDataReader drevents = sqlCommand.ExecuteReader();
            DataTable dtEvents = new DataTable();
            dtEvents.Load(drevents);
            sqlConnection.Close();
            return dtEvents;
        }

        //Retrieving Envents by ID
        public DataTable GetEventsByID(int id)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from EventsTable where user_id=" + id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dtUserEvent = new DataTable();
            dtUserEvent.Load(dr);
            sqlConnection.Close();
            return dtUserEvent;
        }

        // Get the information of userId by email
        public int GetUserID(string email)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select user_id from UsersTable where email= '" + email + "'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dtUser = new DataTable();
            dtUser.Load(dr);
            sqlConnection.Close();
            return Convert.ToInt32(dtUser.Rows[0][0]);
        }

        //Get User information by Id
        public DataTable GetUsersByID(int id)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from UsersTable where user_id=" + id, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        #endregion
    }
}
