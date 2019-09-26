using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Process
    {
        private Product product;

        public void Save(Product product, DataGridView dataGridView)
        {
            DataGridViewRow rows = new DataGridViewRow();
            rows.CreateCells(dataGridView);
            rows.Cells[0].Value = product.ID;
            rows.Cells[1].Value = product.Name;
            rows.Cells[2].Value = product.Details;
            rows.Cells[3].Value = product.Cost;
            rows.Cells[4].Value = product.Price;
            rows.Cells[5].Value = product.CreationDate;
            rows.Cells[6].Value = product.DueDate;
            rows.Cells[7].Value = product.Category;
            rows.Cells[8].Value = product.Status;
            dataGridView.Rows.Add(rows);
        }

        public void Delete(DataGridView dataGridView)
        {
            dataGridView.Rows.Remove(dataGridView.CurrentRow);
        }
    }
}
