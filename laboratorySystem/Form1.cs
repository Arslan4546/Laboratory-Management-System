using BussinessLayer;
using ModelLayer;
using MySql.Data.MySqlClient;
using System.Text;

namespace laboratorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void eqStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void eqID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            laboratoryClass laboratory = new laboratoryClass()
            {

                eqID = eqID.Text,
                eqName = eqName.Text,
                eqQuantity = eqQuantity.Text,
                eqCatagory = eqCatagory.Text,
                eqPrice = eqPrice.Text,
                eqSupplier = eqSupplier.Text,
                eqStatus = eqStatus.Text,
                eqSize = eqSize.Text,
                eqUse = eqUse.Text,
                eqCondition = eqCondition.Text,


            };
            laboratoryBussiness.AddLaboratoryBussiness(laboratory);
            MessageBox.Show("Data Insert Sucessfully");
        }

        private void eqName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string equipmentId = eqID.Text;

            if (string.IsNullOrEmpty(equipmentId))
            {
                MessageBox.Show("Please enter an Equipment ID.");
                return;
            }

            try
            {
                laboratoryBussiness.DeleteLaboratoryBussiness(equipmentId);
                MessageBox.Show("Record deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string equipmentId = eqID.Text;

            if (string.IsNullOrEmpty(equipmentId))
            {
                MessageBox.Show("Please enter an Equipment ID.");
                return;
            }

            laboratoryClass labDetails = new laboratoryClass()
            {
                eqID = equipmentId,
                eqName = string.IsNullOrEmpty(eqName.Text) ? null : eqName.Text,
                eqQuantity = string.IsNullOrEmpty(eqQuantity.Text) ? null : eqQuantity.Text,
                eqCatagory = string.IsNullOrEmpty(eqCatagory.Text) ? null : eqCatagory.Text,
                eqPrice = string.IsNullOrEmpty(eqPrice.Text) ? null : eqPrice.Text,
                eqSupplier = string.IsNullOrEmpty(eqSupplier.Text) ? null : eqSupplier.Text,
                eqStatus = string.IsNullOrEmpty(eqStatus.Text) ? null : eqStatus.Text,
                eqSize = string.IsNullOrEmpty(eqSize.Text) ? null : eqSize.Text,
                eqUse = string.IsNullOrEmpty(eqUse.Text) ? null : eqUse.Text,
                eqCondition = string.IsNullOrEmpty(eqCondition.Text) ? null : eqCondition.Text
            };

            try
            {
                laboratoryBussiness.UpdateLaboratoryBussiness(labDetails);
                MessageBox.Show("Record updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string equipmentId = eqID.Text;

            if (string.IsNullOrEmpty(equipmentId))
            {
                MessageBox.Show("Please enter an Equipment ID.");
                return;
            }

            try
            {
                laboratoryClass labDetails = laboratoryBussiness.GetLaboratoryDetails(equipmentId);

                if (labDetails != null)
                {
                    StringBuilder details = new StringBuilder();
                    details.AppendLine("Equipment ID: " + labDetails.eqID);
                    details.AppendLine("Name: " + labDetails.eqName);
                    details.AppendLine("Quantity: " + labDetails.eqQuantity);
                    details.AppendLine("Category: " + labDetails.eqCatagory);
                    details.AppendLine("Price: " + labDetails.eqPrice);
                    details.AppendLine("Supplier: " + labDetails.eqSupplier);
                    details.AppendLine("Status: " + labDetails.eqStatus);
                    details.AppendLine("Size: " + labDetails.eqSize);
                    details.AppendLine("Use: " + labDetails.eqUse);
                    details.AppendLine("Condition: " + labDetails.eqCondition);

                    MessageBox.Show(details.ToString(), "Equipment Details");
                }
                else
                {
                    MessageBox.Show("No record found for the provided Equipment ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving record: " + ex.Message);
            }
        }

        private void eqCondition_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 

 



   

