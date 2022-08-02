
namespace CosmeticsStoreProject
{
    partial class DeleteProductType
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.lblproductId = new System.Windows.Forms.Label();
            this.cmbUpdateProductType = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblProductTypeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 32);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDelete);
            this.panel2.Controls.Add(this.lblproductId);
            this.panel2.Controls.Add(this.cmbUpdateProductType);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.lblProductTypeName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 480);
            this.panel2.TabIndex = 1;
            // 
            // txtDelete
            // 
            this.txtDelete.ForeColor = System.Drawing.Color.White;
            this.txtDelete.Location = new System.Drawing.Point(331, 298);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(396, 20);
            this.txtDelete.TabIndex = 14;
            // 
            // lblproductId
            // 
            this.lblproductId.AutoSize = true;
            this.lblproductId.ForeColor = System.Drawing.Color.White;
            this.lblproductId.Location = new System.Drawing.Point(208, 183);
            this.lblproductId.Name = "lblproductId";
            this.lblproductId.Size = new System.Drawing.Size(56, 13);
            this.lblproductId.TabIndex = 13;
            this.lblproductId.Text = "Product Id";
            // 
            // cmbUpdateProductType
            // 
            this.cmbUpdateProductType.ForeColor = System.Drawing.Color.White;
            this.cmbUpdateProductType.FormattingEnabled = true;
            this.cmbUpdateProductType.Location = new System.Drawing.Point(332, 248);
            this.cmbUpdateProductType.Name = "cmbUpdateProductType";
            this.cmbUpdateProductType.Size = new System.Drawing.Size(395, 21);
            this.cmbUpdateProductType.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(606, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 39);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblProductTypeName
            // 
            this.lblProductTypeName.AutoSize = true;
            this.lblProductTypeName.ForeColor = System.Drawing.Color.White;
            this.lblProductTypeName.Location = new System.Drawing.Point(145, 251);
            this.lblProductTypeName.Name = "lblProductTypeName";
            this.lblProductTypeName.Size = new System.Drawing.Size(108, 13);
            this.lblProductTypeName.TabIndex = 9;
            this.lblProductTypeName.Text = "Product Type Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Delete Product Type";
            // 
            // DeleteProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteProductType";
            this.Size = new System.Drawing.Size(900, 512);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label lblproductId;
        private System.Windows.Forms.ComboBox cmbUpdateProductType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblProductTypeName;
        private System.Windows.Forms.Label label1;
    }
}
