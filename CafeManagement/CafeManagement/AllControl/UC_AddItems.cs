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
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (itemname,category,price) values ('"+fieldItemName.Text+"', '"+fieldCategory.Text+"', "+fieldItemPrice.Text+")";
            fn.setData(query);
            clearAll();
        }

        public void clearAll()
        {
            fieldCategory.SelectedIndex = -1;
            fieldItemName.Clear();
            fieldItemPrice.Clear();
        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
