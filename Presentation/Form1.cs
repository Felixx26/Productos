using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation
{
    public partial class Form1 : Form
    {

        private Product product;
        private Process process = new Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "" &&
                txtName.Text.Trim() != "" &&
                txtDetails.Text.Trim() != "" &&
                txtCost.Text.Trim() != "" &&
                txtPrice.Text.Trim() != "" &&
                mtxtCreationDate.Text.Trim() != "" &&
                mtxtDueDate.Text.Trim() != "" &&
                txtCategory.Text.Trim() != "" &&
                txtStatus.Text.Trim() != ""
                )
            {
                try
                {
                    string id = txtID.Text;
                    string name = txtName.Text;
                    string details = txtDetails.Text;
                    double cost = Convert.ToDouble(txtCost.Text);
                    double price = Convert.ToDouble(txtPrice.Text);
                    string creationDate = mtxtCreationDate.Text;
                    string dueDate = mtxtDueDate.Text;
                    string category = txtCategory.Text;
                    string status = txtStatus.Text;

                    product = new Product(id, name, details, cost, price, creationDate, dueDate, category, status);

                    process.Save(product, dataGridView1);

                    txtID.Clear();
                    txtName.Clear();
                    txtDetails.Clear();
                    txtCost.Clear();
                    txtPrice.Clear();
                    mtxtCreationDate.Clear();
                    mtxtDueDate.Clear();
                    txtCategory.Clear();
                    txtStatus.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show(this, "¿Seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    process.Delete(dataGridView1);
                }
            }
        }
    }
}
