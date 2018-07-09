using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDB
{
    class StudentDB
    {
        private static void DeleteStudent(int id)
        {
            // USING STATEMENTS 
            // generates a try/finally block
            // inside the finally, dispose() is called 
            using (SqlConnection con_2 = new SqlConnection())
            {   // created new con2 object
                con_2.Open();
                // other db code here...

                // if exception occurs, we can handle this in the forms
            }   // Dispose() is automatically called at the 

        } // end delete student

        // alternate method to delete student
        public static void DeleteStudent2( int id)
        {
          // add using by ctrl+.lightbulb select using System.Data.SqlClient
            SqlConnection con = new SqlConnection(" con string here... ");
            SqlCommand delCmd = new SqlCommand();
            delCmd.Connection = con;                    // Point to con object
            delCmd.CommandText = "DELETE QUERY";

            try
            {
                con.Open();
                int rows = delCmd.ExecuteNonQuery();
            }
            catch
            {       // empty catch not good idea - catch spectific exceptions only

            }
            finally
            {
                con.Dispose(); // calls close() internally
            }

            // REMOVE UNUSED CATCH
            try
            {
                con.Open();
                // continue code here
            }   // do not have to have a catch if you have finally
            finally
            {
                con.Dispose();
            }


        } // end delete student 2

    } // end student class
}
