using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace CosmeticsStoreProject
{
    public partial class InsertProductType : UserControl
    {
        public InsertProductType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertProdctTypeData();
        }
        private void InsertProdctTypeData()
        {
            BLL.BLLInsertProductType bLLInsertProductType = new BLLInsertProductType();
            bLLInsertProductType.ProductTypeBLL =txtProductTypeName.Text;
            int row_effected = bLLInsertProductType.BllInsertProductType();

            if (row_effected > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
            }
            else
                MessageBox.Show("Something Error Happend!");

        }

    }
}
