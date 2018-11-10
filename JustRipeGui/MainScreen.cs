using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeGui
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            btnShopWholesale.Text = "Shop / " + Environment.NewLine + "Wholesale";

            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();

            panel1.Width = 852;
            panel1.Height = 386;
            panel1.Location = new Point(2, 134);

            panel2.Width = 852;
            panel2.Height = 386;
            panel2.Location = new Point(2, 134);

            panel3.Width = 852;
            panel3.Height = 386;
            panel3.Location = new Point(2, 134);

            panel4.Width = 852;
            panel4.Height = 386;
            panel4.Location = new Point(2, 134);

            panel5.Width = 852;
            panel5.Height = 386;
            panel5.Location = new Point(2, 134);

            panel6.Width = 852;
            panel6.Height = 386;
            panel6.Location = new Point(2, 134);
        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFarm_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel1.Hide();
            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void btnLabourer_Click(object sender, EventArgs e)
        {

            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
            panel5.Hide();
            panel6.Hide();
        }

        private void btnMachines_Click(object sender, EventArgs e)
        {

            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Show();
            panel6.Hide();
        }

        private void btnShopWholesale_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Show();
        }

        private void btnTestAdd_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            Labourer labr = new Labourer();
            labr.Name = "Adam";
            labr.Age = 30;
            labr.Gender = "male";
            
            LabourerHandler labHnd = new LabourerHandler();
            int recordCnt = labHnd.addNewLabourer(dbConn.getConn(), labr);
            MessageBox.Show(recordCnt + " record has been inserted !!");
        }


    }
}
