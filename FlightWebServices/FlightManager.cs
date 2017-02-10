using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FlightWebServices
{
    public class FlightManager
    {
        public Response DoSale(int parRow, string parSeat, int parTravel, int parCustomer)
        {
            SqlConnection cnn = new SqlConnection();
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["DemoConnectionString"].ConnectionString;
            cnn.ConnectionString = cnnString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = cnn; cmd.CommandText = "Flight_AssignSale";
            cmd.Parameters.AddWithValue("@RowID", parRow);
            cmd.Parameters.AddWithValue("@SeatID", parSeat);
            cmd.Parameters.AddWithValue("@TravelID", parTravel);
            cmd.Parameters.AddWithValue("@CustomerID", parCustomer);
            //Parametro de output
            SqlParameter sqlParameterResultDescription = new SqlParameter();
            sqlParameterResultDescription.SqlDbType = System.Data.SqlDbType.NVarChar;
            sqlParameterResultDescription.Size = 50;
            sqlParameterResultDescription.Direction = System.Data.ParameterDirection.Output;
            sqlParameterResultDescription.ParameterName = "@ResultDescription";
            // Asignar el parámetro al comando
            cmd.Parameters.Add(sqlParameterResultDescription);

            int insertedRows = cmd.ExecuteNonQuery();

            cnn.Close();
            Response r = new Response();

            if (insertedRows == 1)
            {
                r.Result = true;
                r.ResultDescription = cmd.Parameters["@ResultDescription"].Value.ToString();
                return r;
            }
            else
            {
                r.Result = false;
                r.ResultDescription = cmd.Parameters["@ResultDescription"].Value.ToString();
                return r;
            }
        }
        public List<Customer> GetCustomer()
        {
            SqlConnection cnn = new SqlConnection();
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["DemoConnectionString"].ConnectionString;
            cnn.ConnectionString = cnnString;
            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = cnn; cmd.CommandText = "Flight_GetCustomers";

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();

            List<Customer> result = new List<Customer>();

            if(reader.HasRows)
            {
               while(reader.Read())
                {
                    Customer cust = new Customer();
                    cust.Code = reader.GetInt32(0);
                    cust.Name = reader.GetString(1);
                    SmartAdd(result, cust);
                }
            }

            return result;
        }
        protected void SmartAdd(List<Customer> list, Customer cust)
        {
            Customer detail = list.SingleOrDefault(d => d.Code == cust.Code && d.Name == cust.Name);

            if (detail == null)
            {
                list.Add(cust);
            }
        }
      }
}