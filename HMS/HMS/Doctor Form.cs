using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HMS
{
    public partial class Doctor_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Doctor_Form()
        {
            InitializeComponent();
        }
        void populate()
        {


        }

        private void Doctor_Form_Load(object sender, EventArgs e)
        {
            populate();

            con.Open();
            string query = "select * from DoctorTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                con.Open();
                string query = "insert into DoctorTb1 values(" + DocId.Text + ",'" + DocName.Text + "'," + DocExp.Text + ", '" + DocPass.Text + "‘)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                con.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void DocName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
                MessageBox.Show("Enter The Doctor Id");
            else
            {
                con.Open();
                string query = "delet from DoctorTb1 where DocId= " + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                MessageBox.Show("Doctor Successfully Deleted");
                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update doctorTb1 set DocName = '" + DocName.Text + "',DocExp = '" + DocExp.Text + "',DocPass='" + DocPass.Text + "' where DocId=" + DocId.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Successfully updated");
            con.Close();
            populate();
        }
    }
}
