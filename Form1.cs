using System;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Inventory_manager
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Connected to SQLite DB successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message);
            }

        }
    }
}
