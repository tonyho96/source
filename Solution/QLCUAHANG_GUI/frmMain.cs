using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Threading;
using DevExpress.XtraSplashScreen;

namespace QLCUAHANG_GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        internal static List<byte> typePages = new List<byte>();
        public int isContributor;

        public void addTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            // Check page existing
            for(int i = 0; i < tabDisplay.TabPages.Count; i++)
            {
                if(tabDisplay.TabPages[i].Contains(uct) == true)
                {
                    tabDisplay.SelectedTab = tabDisplay.TabPages[i];
                    return;
                }
            }

            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabDisplay.Size;
            tab.Text = tenTab + "   ";
            tabDisplay.TabPages.Add(tab);
            tabDisplay.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }

        // Close current tab
        public void CloseTabDisplayCurrent()
        {
            tabDisplay.TabPages.Remove(tabDisplay.SelectedTab);
        }

        // Close all tab
        public void CloseAllTab()
        {
            while (tabDisplay.TabPages.Count > 0)
            {
                CloseTabDisplayCurrent();
            }
            //tabDisplay.TabPages.Clear();
        }

        private void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2019 Colorful";
        }

        private void btnInfoAgency_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctVendor.uctVendorInfo, 40, "Vendor Information");
        }

        //private void btnProductOfAgency_ItemClick(object sender, ItemClickEventArgs e)
        //{
            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            //addTabPages(uctSanPhamDL.uctSPDL, 30, "Product of Vendor");
        //}

        private void btnInfoOfCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctCustomer.uctCustomerInfo, 30, "Customer Information");
        }

        private void btnBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctInvoice.uctPHD, 25, "Invoice");
        }


        private void colseAllTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllTab();
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CloseTabDisplayCurrent();
        }


        private void btnProductOfStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctProduct.uctSPCH, 10, "Product in Store");
        }

        private void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            barEditItem3.EditValue = DateTime.Now.ToLongDateString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(2000);
            //addTabPages(uctBackGroud.ucthienthi, 40, "");
            //addTabPages(uctPhieuHoaDon.uctPHD, 40, "Receipt");
            skins();
        }

        private void tabDisplay_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            Font drawFont = new Font("Time New Roman", 10);
            g.FillRectangle(new SolidBrush(Color.Blue), e.Bounds.Left, e.Bounds.Top, 200, 1);
            //e.Graphics.DrawString("X", drawFont, Brushes.Red, e.Bounds.Right - 14, e.Bounds.Top);e.Bounds.Left+10, e.Bounds.Top + 6
            e.Graphics.DrawString(this.tabDisplay.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top + 6);
            e.Graphics.DrawImage(Properties.Resources.x2, e.Bounds.Right - 16, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabDisplay.TabPages.Count; i++)

            {
                Rectangle r = tabDisplay.GetTabRect(i);
                //Getting the position of the “x” mark.
                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 4, 20, 20);

                if (closeButton.Contains(e.Location))

                {
                    if (MessageBox.Show("Do you want to close the current tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        this.tabDisplay.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void btnChangePassWord_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChangePassword Change = new frmChangePassword();
            Change.ShowDialog();
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            //frmLogin l = new frmLogin();
            //l.ShowDialog();
            this.Close();
        }
       
        private void btnRevenue_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCaoDoanhThu baocao = new frmBaoCaoDoanhThu();
            baocao.ShowDialog();
            this.Show();
        }

        private void btnProductOfStore1_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctProduct.uctSPCH, 10, "Product Management");
        }

        private void btnAuthorInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAuthorInfo author=new frmAuthorInfo();
            author.ShowDialog();
            this.Show();
        }

        private void btnSorftwareInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmSorftwareInfo author = new frmSorftwareInfo();
                author.ShowDialog();
                this.Show();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification");
            }
        }

        private void btnProductRender_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmBaoCaoSPTonKho report = new frmBaoCaoSPTonKho();
                report.ShowDialog();
                this.Show();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification");
            }
        }

        private void btnDebtAgency_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmBaoCaoNoDaiLi report = new frmBaoCaoNoDaiLi();
                report.ShowDialog();
                this.Show();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification");
            }
        }

        private void btnDeptCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmBaoCaoTienNoKhachHang baocao = new frmBaoCaoTienNoKhachHang();
                baocao.ShowDialog();
                this.Show();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Notification");
            }
        }

        private void btnStatistics_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctThongKe.uctthongke, 10, "Summary of Revenue");
        }

        private void btnInfoAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTinTaiKhoan account = new frmThongTinTaiKhoan();
            account.ShowDialog();
            this.Show();
        }

        private void btnManagerAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAdmin account = new frmAdmin();
            account.ShowDialog();
            this.Show();
        }

        private void BtnUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctUnit.uctUnitInfo, 40, "Unit Information");
        }

        private void btnProductCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctProductCategory.uctProductCategoryInfo, 40, "Category Information");
        }
    }
}