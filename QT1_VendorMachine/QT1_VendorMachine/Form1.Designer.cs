namespace QT1_VendorMachine
{
    partial class frmVendor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbXinChao = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbXinChao
            // 
            this.lbXinChao.AutoSize = true;
            this.lbXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXinChao.Location = new System.Drawing.Point(194, 150);
            this.lbXinChao.Name = "lbXinChao";
            this.lbXinChao.Size = new System.Drawing.Size(342, 39);
            this.lbXinChao.TabIndex = 0;
            this.lbXinChao.Text = "Xin chào quý khách!";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(279, 264);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(149, 37);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Bắt đầu";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // frmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lbXinChao);
            this.Name = "frmVendor";
            this.Text = "Vendor machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbXinChao;
        private System.Windows.Forms.Button btnBegin;
    }
}

