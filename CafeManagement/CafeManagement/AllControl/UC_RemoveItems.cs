using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.AllControl
{
    public partial class UC_RemoveItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_RemoveItems()
        {
            InitializeComponent();
        }

        private void UC_RemoveItems_Load(object sender, EventArgs e)
        {
            delLabel.Text = "Delete";
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.GetData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearch.Text + "%'";
            DataSet ds = fn.GetData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item?", "important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id=int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query="delete from items where iid="+id+"";
                fn.setData(query);
                loadData();
            }
        }

        private void delLabel_Click(object sender, EventArgs e)
        {
            delLabel.ForeColor = Color.Red;
            delLabel.Text = "*Click on the Item.";
        }
    }
}
