using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticsStoreProject
{
    public partial class HOMEPAGE : Form
    {
        public HOMEPAGE()
        {
            InitializeComponent();
            IsPanelLoginOrRegisterVisibleOrNot();
        }

        private void HOMEPAGE_Load(object sender, EventArgs e)
        {
            deleteproduct1.Hide();
            deleteProductType1.Hide();
            insertProduct1.Hide();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnInsertProductType_Click(object sender, EventArgs e)
        {
            
            hideSubMenu();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void showSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        private void IsPanelLoginOrRegisterVisibleOrNot()
        {
            pnlProductDetails.Visible = false;
            pnlProductTypeDetails.Visible = false;
            pnlSupplierDetails.Visible = false;
        }
        private void hideSubMenu()

        {
            if(pnlProductDetails.Visible==true)
            {
                pnlProductDetails.Visible = false;
            }
            if(pnlProductTypeDetails.Visible==true)
            {
                pnlProductTypeDetails.Visible = false;
            }
            if(pnlSupplierDetails.Visible==true)
            {
                pnlSupplierDetails.Visible = false;
            }
        }
        private Form activeForm = null;
        private void OpenhildFormInPanel(Form childForm)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlParentFormPanel.Controls.Add(childForm);
                pnlParentFormPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlProductDetails);
        }

        private void btnProductType_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlProductTypeDetails);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSupplierDetails);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlProductDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void pnlSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnlSupplierDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteSupplierDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateSupplierDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertSupplierDetails_Click(object sender, EventArgs e)
        {

        }

        private void pnlSupplier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void pnlProductTypeDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteProductType_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProductType_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void pnlProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
