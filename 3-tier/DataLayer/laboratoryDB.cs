using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types;
using System.Xml.Linq;
using ModelLayer;
using System.Data;
using System.Windows.Forms;

namespace DataLayer
{
    public class laboratoryDB
    {
        static MySqlConnection conn = new MySqlConnection("server = localhost;port = 3306;username = root;password = '';  database=laboratorydatabase");

        public static void AddLaboratoryDB(laboratoryClass lb)
        {

            try
            {
                using (conn)
                {

                    conn.Open();
                    String queury = "INSERT INTO laboratorytable(equipment_id,equipment_name,equipment_quantity,equipment_price,equipment_category,equipment_supplier,equipment_status,equipment_size,equipment_use,equipment_condition) VALUES(@equipment_id,@equipment_name,@equipment_quantity,@equipment_price,@equipment_category,@equipment_supplier,@equipment_status,@equipment_size,@equipment_use,@equipment_condition)";


                    MySqlCommand cmd = new MySqlCommand(queury, conn);
            
                    cmd.Parameters.AddWithValue("@equipment_id", lb.eqID);
                    cmd.Parameters.AddWithValue("@equipment_name", lb.eqName);
                    cmd.Parameters.AddWithValue("@equipment_quantity", lb.eqQuantity);
                    cmd.Parameters.AddWithValue("@equipment_category", lb.eqPrice);
                    cmd.Parameters.AddWithValue("@equipment_price", lb.eqCatagory);
                    cmd.Parameters.AddWithValue("@equipment_supplier", lb.eqSupplier);
                    cmd.Parameters.AddWithValue("@equipment_status", lb.eqStatus);
                    cmd.Parameters.AddWithValue("@equipment_size", lb.eqSize);
                    cmd.Parameters.AddWithValue("@equipment_use", lb.eqSize);
                    cmd.Parameters.AddWithValue("@equipment_condition", lb.eqCondition);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error,", ex.Message);
            }

        }

        public static void DeleteLaboratoryDB(string equipmentId)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "DELETE FROM laboratorytable WHERE equipment_id = @equipment_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@equipment_id", equipmentId);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error,", ex.Message);
            }
        }


        public static laboratoryClass GetLaboratoryDetailsDB(string equipmentId)
        {
            laboratoryClass labDetails = null;

            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM laboratorytable WHERE equipment_id = @equipment_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@equipment_id", equipmentId);
                    cmd.Prepare();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labDetails = new laboratoryClass
                            {
                                eqID = reader["equipment_id"].ToString(),
                                eqName = reader["equipment_name"].ToString(),
                                eqQuantity = reader["equipment_quantity"].ToString(),
                                eqCatagory = reader["equipment_category"].ToString(),
                                eqPrice = reader["equipment_price"].ToString(),
                                eqSupplier = reader["equipment_supplier"].ToString(),
                                eqStatus = reader["equipment_status"].ToString(),
                                eqSize = reader["equipment_size"].ToString(),
                                eqUse = reader["equipment_use"].ToString(),
                                eqCondition = reader["equipment_condition"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return labDetails;
        }



        public static void UpdateLaboratoryDB(laboratoryClass lb)
        {
            try
            {
                using (conn)
                {
                    conn.Open();

                    // Retrieve the current data
                    string selectQuery = "SELECT * FROM laboratorytable WHERE equipment_id = @equipment_id";
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
                    selectCmd.Parameters.AddWithValue("@equipment_id", lb.eqID);
                    selectCmd.Prepare();

                    laboratoryClass currentLabDetails = null;
                    using (MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentLabDetails = new laboratoryClass
                            {
                                eqID = reader["equipment_id"].ToString(),
                                eqName = reader["equipment_name"].ToString(),
                                eqQuantity = reader["equipment_quantity"].ToString(),
                                eqCatagory = reader["equipment_category"].ToString(),
                                eqPrice = reader["equipment_price"].ToString(),
                                eqSupplier = reader["equipment_supplier"].ToString(),
                                eqStatus = reader["equipment_status"].ToString(),
                                eqSize = reader["equipment_size"].ToString(),
                                eqUse = reader["equipment_use"].ToString(),
                                eqCondition = reader["equipment_condition"].ToString()
                            };
                        }
                        else
                        {
                            throw new Exception("No record found with the provided Equipment ID.");
                        }
                    }

                    // Update only the fields that are provided
                    string query = "UPDATE laboratorytable SET equipment_name = @equipment_name, equipment_quantity = @equipment_quantity, equipment_price = @equipment_price, equipment_category = @equipment_category, equipment_supplier = @equipment_supplier, equipment_status = @equipment_status, equipment_size = @equipment_size, equipment_use = @equipment_use, equipment_condition = @equipment_condition WHERE equipment_id = @equipment_id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@equipment_id", lb.eqID);
                    cmd.Parameters.AddWithValue("@equipment_name", string.IsNullOrEmpty(lb.eqName) ? currentLabDetails.eqName : lb.eqName);
                    cmd.Parameters.AddWithValue("@equipment_quantity", string.IsNullOrEmpty(lb.eqQuantity) ? currentLabDetails.eqQuantity : lb.eqQuantity);
                    cmd.Parameters.AddWithValue("@equipment_price", string.IsNullOrEmpty(lb.eqPrice) ? currentLabDetails.eqPrice : lb.eqPrice);
                    cmd.Parameters.AddWithValue("@equipment_category", string.IsNullOrEmpty(lb.eqCatagory) ? currentLabDetails.eqCatagory : lb.eqCatagory);
                    cmd.Parameters.AddWithValue("@equipment_supplier", string.IsNullOrEmpty(lb.eqSupplier) ? currentLabDetails.eqSupplier : lb.eqSupplier);
                    cmd.Parameters.AddWithValue("@equipment_status", string.IsNullOrEmpty(lb.eqStatus) ? currentLabDetails.eqStatus : lb.eqStatus);
                    cmd.Parameters.AddWithValue("@equipment_size", string.IsNullOrEmpty(lb.eqSize) ? currentLabDetails.eqSize : lb.eqSize);
                    cmd.Parameters.AddWithValue("@equipment_use", string.IsNullOrEmpty(lb.eqUse) ? currentLabDetails.eqUse : lb.eqUse);
                    cmd.Parameters.AddWithValue("@equipment_condition", string.IsNullOrEmpty(lb.eqCondition) ? currentLabDetails.eqCondition : lb.eqCondition);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}
