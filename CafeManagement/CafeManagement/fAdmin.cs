using CafeManagement.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeManagement
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadAccountList()
        {
           

            string query = "SELECT * FROM account";

           DataProvider provider = new DataProvider();
            dgvAccount.DataSource = provider.ExecuteQuery(query);
        }
    }
}
