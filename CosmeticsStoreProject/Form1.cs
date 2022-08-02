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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsPanelLoginOrRegisterVisibleOrNot();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlLoginOrRegister);
        }
        private void IsPanelLoginOrRegisterVisibleOrNot()
        {
            pnlLoginOrRegister.Visible = false;
            pnlShowProductDetails.Visible = false;
            pnlProductTypeDetails.Visible = false;
            pnlSupplierDetails.Visible = false;
            
        }
        

       /* private void pnlEmployee_Paint(object sender, PaintEventArgs e)
        {

        }
*/
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pnlMenuBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void hideSubMenu()
        {
            if(pnlLoginOrRegister.Visible == true)
            {
                pnlLoginOrRegister.Visible = false;
            }
            if(pnlShowProductDetails.Visible == true)
            {
                pnlShowProductDetails.Visible = false;
            }
            if (pnlProductTypeDetails.Visible == true)
            {
                pnlProductTypeDetails.Visible = false;
            }
            if (pnlSupplierDetails.Visible == true)
            {
                pnlSupplierDetails.Visible = false;
            }
        }
        private void showSubMenu(Panel panel )
        {
            if(panel.Visible==false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        /*private void btnProductDetails_Click(object sender, EventArgs e)
        {
               showSubMenu(pnlShowProductDetails);
            
        }*/
        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlShowProductDetails);
        }

        private void btnProductTypeDetails_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlProductTypeDetails);
        }

        private void btnProductTypeDetails_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlProductTypeDetails);
        }

        private void btnSupplier_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlSupplierDetails);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
