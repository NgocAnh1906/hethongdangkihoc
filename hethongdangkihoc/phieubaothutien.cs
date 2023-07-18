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
using System.Linq;
namespace hethongdangkihoc
{
    public partial class phieubaothutien : Form
    {
        public phieubaothutien()
        {
            InitializeComponent();
            loadhocphi();
        }
        private void loadhocphi()
        {
            var i = 0;
            dbmonhocDataContext db = new dbmonhocDataContext();
            var query = from r in db.chi_tiet_mon_hocs
                        orderby r.Hoc_ki
                        group r by r.Hoc_ki into gr

                        select new
                        {

                            Hoc_ki = gr.Key,
                            So_mon = gr.Count().ToString(),
                            So_TC = gr.Sum(c => c.So_TC),
                            Hoc_phi = gr.Sum(d => d.Hoc_phi)
                        

                        };

             datahocphi.DataSource = query;
            
        }

        private void phieubaothutien_Load(object sender, EventArgs e)
        {
            dbmonhocDataContext db = new dbmonhocDataContext();
            int count = (from x in db.chi_tiet_mon_hocs select x).Count();
            int sumTC = (from x in db.chi_tiet_mon_hocs select x).Sum(c => c.So_TC);
            var sumHP = (from x in db.chi_tiet_mon_hocs select x).Sum(d => d.Hoc_phi);
            List<TongHocPhi> r = new List<TongHocPhi>();
            TongHocPhi sp;
            sp = new TongHocPhi() { TongMon = count,TongTC=sumTC,TongHP= Convert.ToDouble(sumHP) };
            r.Add(sp);
            datatonghocphi.DataSource = r;


        }
    }
   
}
