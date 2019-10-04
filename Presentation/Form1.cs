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
                txtExist.Text.Trim() != "" &&
                txtMarca.Text.Trim() != "" &&
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
                    int exis = Convert.ToInt32(txtExist.Text);
                    String marca = (txtMarca.Text);
                    string creationDate = mtxtCreationDate.Text;
                    string dueDate = mtxtDueDate.Text;
                    string category = txtCategory.Text;
                    string status = txtStatus.Text;

                    product = new Product(id, name, details, exis, marca, creationDate, dueDate, category, status);

                    process.Save(product, dataGridView1);

                    txtID.Clear();
                    txtName.Clear();
                    txtDetails.Clear();
                    txtExist.Clear();
                    txtMarca.Clear();
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
