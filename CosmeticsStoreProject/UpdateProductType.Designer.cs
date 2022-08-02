
namespace CosmeticsStoreProject
{
    partial class UpdateProductType
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
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.cmbUpdateProductType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateProductTypeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEdit);
            this.panel2.Controls.Add(this.lblProductId);
            this.panel2.Controls.Add(this.cmbUpdateProductType);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.lblUpdateProductTypeName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 470);
            this.panel2.TabIndex = 1;
            // 
            // txtEdit
            // 
            this.txtEdit.ForeColor = System.Drawing.Color.White;
            this.txtEdit.Location = new System.Drawing.Point(319, 236);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(396, 20);
            this.txtEdit.TabIndex = 14;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.ForeColor = System.Drawing.Color.White;
            this.lblProductId.Location = new System.Drawing.Point(176, 93);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(56, 13);
            this.lblProductId.TabIndex = 13;
            this.lblProductId.Text = "Product Id";
            // 
            // cmbUpdateProductType
            // 
            this.cmbUpdateProductType.ForeColor = System.Drawing.Color.White;
            this.cmbUpdateProductType.FormattingEnabled = true;
            this.cmbUpdateProductType.Location = new System.Drawing.Point(320, 186);
            this.cmbUpdateProductType.Name = "cmbUpdateProductType";
            this.cmbUpdateProductType.Size = new System.Drawing.Size(395, 21);
            this.cmbUpdateProductType.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(594, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 39);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblUpdateProductTypeName
            // 
            this.lblUpdateProductTypeName.AutoSize = true;
            this.lblUpdateProductTypeName.ForeColor = System.Drawing.Color.White;
            this.lblUpdateProductTypeName.Location = new System.Drawing.Point(133, 189);
            this.lblUpdateProductTypeName.Name = "lblUpdateProductTypeName";
            this.lblUpdateProductTypeName.Size = new System.Drawing.Size(108, 13);
            this.lblUpdateProductTypeName.TabIndex = 9;
            this.lblUpdateProductTypeName.Text = "Product Type Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Update Product Type";
            // 
            // UpdateProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateProductType";
            this.Size = new System.Drawing.Size(900, 512);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.ComboBox cmbUpdateProductType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateProductTypeName;
        private System.Windows.Forms.Label label1;
    }
}
