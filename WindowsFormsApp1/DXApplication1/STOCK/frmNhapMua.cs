using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinesssLayer;
namespace STOCK
{
    public partial class frmNhapMua : DevExpress.XtraEditors.XtraForm
    {
        CONGTY _congty = new CONGTY();
        DONVI _donvi = new DONVI();
        NHACUNGCAP _nhacungcap = new NHACUNGCAP();
        void loadCongTy()
        {
            cboCongTy.DataSource = _congty.getALL();
            cboCongTy.DisplayMember = "TENCTY";
            cboCongTy.ValueMember = "MACTY";
        }
        void loadKho()
        {
            cboKho.DataSource = _donvi.getKhoBYCty(cboCongTy.SelectedValue.ToString());
            cboKho.DisplayMember = "TENDVI";
            cboKho.ValueMember = "TENDVI";
        }
        void loadDonVi()
        {
            cboDonVi.DataSource = _donvi.getKhoBYCty(cboCongTy.SelectedValue.ToString());
            cboDonVi.DisplayMember = "TENDVI";
            cboDonVi.ValueMember = "TENDVI";

        }
        void loadnhacungcap()
        {
            cboNhacungcap.DataSource = _nhacungcap.getALL();
            cboNhacungcap.DisplayMember = "TENNCC";
            cboNhacungcap.ValueMember = "MANCC";

        }
        public frmNhapMua()
        {
            InitializeComponent();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
        void showHidecontrol(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
            toolStripSeparator1.Visible = t;
            toolStripSeparator2.Visible = t;
            toolStripSeparator3.Visible = t;
            toolStripSeparator4.Visible = t;
            toolStripSeparator5.Visible = !t;
            toolStripSeparator6.Visible = !t;
            toolStripSeparator7.Visible = t;
        }
        public void _edcontrol(bool t)
        {
            txtGhichu.Enabled = t;
            cboTrangthai.Enabled = t;
            cboCongTy.Enabled = t;
            cboNhacungcap.Enabled = t;
            dtNgay.Enabled = t;
        }
        public void _reset()
        {
            txtSophieu.Clear();
            txtGhichu.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void frmNhapMua_Load(object sender, EventArgs e)
        {
            showHidecontrol(true);
            loadCongTy();
            loadDonVi();
            loadKho();
            loadnhacungcap();
            cboCongTy.SelectedIndexChanged += CboCongTy_SelectedIndexChanged;
            cboCongTy.SelectedValue = "CT01";
        }

        private void CboCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadKho();
            loadDonVi();
        }
    }
}