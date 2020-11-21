using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace CafeManagement.AllControl
{
    public partial class UC_Order : UserControl
    {
        function fn = new function();
        string query;
        public UC_Order()
        {
            InitializeComponent();
        }

        private void UC_Order_Load(object sender, EventArgs e)
        {

        }

        private void chooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = chooseCategory.Text;
            query = "select name from items where category = '" + category + "'";
            showItemList(query);
        }

        private void fieldSearch_TextChanged(object sender, EventArgs e)
        {
            string category = chooseCategory.Text;
            query = "select name from items where category = '" + category + "' and name like '"+fieldSearch.Text+"%'";
            showItemList(query);
        }

        private void showItemList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.GetData(query);
            int i;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fieldQuantityUpDown.ResetText();
            fieldTotal.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItems);
            txtItemName.Text = text;
            query="select price from items where name ='"+text+"'";
            DataSet ds = fn.GetData(query);

            try { 
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
         }

        private void fieldQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(fieldQuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            fieldTotal.Text = (quan * price).ToString();
        }


        protected int n, total = 0;

        int amount;
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.Rows.RemoveAt(this.gunaDataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            totalBillLabel.Text = "LE. " + total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Amount : " + totalBillLabel.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(gunaDataGridView1);

            total = 0;
            gunaDataGridView1.Rows.Clear();
            totalBillLabel.Text = "LE. " + total;
        }

        private void btnAddtoBill_Click(object sender, EventArgs e)
        {
            if(fieldTotal.Text != "0" && fieldTotal.Text !="") { 
                n = gunaDataGridView1.Rows.Add();
                gunaDataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                gunaDataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                gunaDataGridView1.Rows[n].Cells[2].Value = fieldQuantityUpDown.Value;
                gunaDataGridView1.Rows[n].Cells[3].Value = fieldTotal.Text;

                total = total + int.Parse(fieldTotal.Text);
                totalBillLabel.Text = "LE. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Qunatity is 1", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
