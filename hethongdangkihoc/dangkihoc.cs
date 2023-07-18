using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace hethongdangkihoc
{
    public partial class dangkihoc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Quanlymonhoc;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string HOCKI,MAMON1,MAMON2, TENMON1,TENMON2, HESO1,HESO2,SOTC1,SOTC2;
        double hocphi = 4400000;
        public dangkihoc()
        {
            InitializeComponent();
            // Loadmonhoc();
            //Loadchitietmonhoc();
            txbdonviphi.Text = hocphi.ToString();
           
        }
        private void Loadmonhoc()
        {
            /*dbmonhocDataContext db = new dbmonhocDataContext();
            var query = from sp in db.Thongtinmonhocs
                        select sp;
            datamonhoc.DataSource = query;*/
            command = connection.CreateCommand();
            command.CommandText = "select * from Thongtinmonhoc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            datamonhoc.DataSource = table;

        }

        private void dangkihoc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Loadmonhoc();
        }

        private void boxkihoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bntdangki.Enabled = true;
            datadangki.Enabled = true;
            Loadchitietmonhoc();
        }

        private void bntxoa_Click(object sender, EventArgs e)
        {
            dbmonhocDataContext db = new dbmonhocDataContext();
            chi_tiet_mon_hoc t = new chi_tiet_mon_hoc();
            t.Hoc_ki = HOCKI;
            t.Ma_mon = MAMON2;
            /*command = connection.CreateCommand();
            command.CommandText = "delete from chi_tiet_mon_hoc where Hoc_ki='"+HOCKI+"'  Ma_mon='"+MAMON2+"'";
            command.ExecuteNonQuery();
            Loadchitietmonhoc();*/
            var deletechitietmonhoc = from i in db.chi_tiet_mon_hocs
                                      where i.Hoc_ki == HOCKI && i.Ma_mon == MAMON2
                                      select i;
          
            foreach (var i in deletechitietmonhoc)
            {
                db.chi_tiet_mon_hocs.DeleteOnSubmit(i);
              
            }
            db.SubmitChanges();
            Loadchitietmonhoc();
            Insertthongtinmonhoc();
            Loadmonhoc();
        }
        private void Insertthongtinmonhoc()
        {
            dbmonhocDataContext db = new dbmonhocDataContext();
            Thongtinmonhoc x = new Thongtinmonhoc();
            x.Mamon = MAMON2;
            x.Tenmon = TENMON2;
            x.Heso = Convert.ToDouble(HESO2);
            x.Sotinchi = Convert.ToInt16(SOTC2);
            try
            {
                db.Thongtinmonhocs.InsertOnSubmit(x);
                db.SubmitChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("ban chua chon mon hoc");
            }
        }
        private void datadangki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bntxoa.Enabled = true;
            int i;
            i = datadangki.CurrentRow.Index;
            HOCKI= datadangki.Rows[i].Cells[0].Value.ToString();
            MAMON2 = datadangki.Rows[i].Cells[1].Value.ToString();
            TENMON2= datadangki.Rows[i].Cells[2].Value.ToString();
            HESO2= datadangki.Rows[i].Cells[3].Value.ToString();
            SOTC2= datadangki.Rows[i].Cells[4].Value.ToString();
        }

        private void datamonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = datamonhoc.CurrentRow.Index;
            MAMON1 = datamonhoc.Rows[i].Cells[0].Value.ToString();
            TENMON1 = datamonhoc.Rows[i].Cells[1].Value.ToString();
            HESO1= datamonhoc.Rows[i].Cells[2].Value.ToString();
            SOTC1 = datamonhoc.Rows[i].Cells[3].Value.ToString();
        }

        private void Loadchitietmonhoc()
        {
            dbmonhocDataContext db = new dbmonhocDataContext();
            var query = from sp in db.chi_tiet_mon_hocs
                        where sp.Hoc_ki == boxkihoc.Text
                        select new
                        {
                            Hoc_ki = sp.Hoc_ki,
                            Ma_mon = sp.Ma_mon,
                            Ten_mon = sp.Ten_mon,
                            He_so = sp.He_so,
                            So_TC = sp.So_TC,
                            Hoc_phi = sp.Hoc_phi

                        };
            datadangki.DataSource = query;

        }

        
            private void bntdangki_Click(object sender, EventArgs e)
        {
            dbmonhocDataContext db = new dbmonhocDataContext();
            chi_tiet_mon_hoc t = new chi_tiet_mon_hoc();
            t.Hoc_ki = boxkihoc.Text;
            t.Ma_mon = MAMON1;
            t.Ten_mon = TENMON1;
            t.He_so = Convert.ToDouble(HESO1);
            t.So_TC = Convert.ToInt16(SOTC1) ;
            t.Hoc_phi = hocphi* Convert.ToDouble(SOTC1)* Convert.ToDouble(HESO1);
            try 
            { db.chi_tiet_mon_hocs.InsertOnSubmit(t);
                db.SubmitChanges();
                Loadchitietmonhoc();
            }
            catch(Exception )
            {
                if (t.Ma_mon == null)
                    MessageBox.Show("bạn chưa chọn môn học ");
                else
                    MessageBox.Show("bạn đã đăng kí môn này rồi");
            }

            Thongtinmonhoc x = new Thongtinmonhoc();
            x.Mamon = MAMON1;
            /*command = connection.CreateCommand();
            command.CommandText = "delete from chi_tiet_mon_hoc where Hoc_ki='"+HOCKI+"'  Ma_mon='"+MAMON2+"'";
            command.ExecuteNonQuery();
            Loadchitietmonhoc();*/
            var deletethongtinmonhoc = from i in db.Thongtinmonhocs
                                      where i.Mamon ==MAMON1
                                      select i;
            foreach (var i in deletethongtinmonhoc)
            {
                db.Thongtinmonhocs.DeleteOnSubmit(i);
                db.SubmitChanges();
            }
           
            Loadmonhoc();
        }
    }
}
