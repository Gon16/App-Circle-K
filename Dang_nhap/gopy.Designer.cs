namespace Dang_nhap
{
    partial class gopy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgopy = new System.Windows.Forms.RichTextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btql = new System.Windows.Forms.Button();
            this.BTluu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "GÓP Ý CỦA KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mời nhập góp ý tại đây:";
            // 
            // txtgopy
            // 
            this.txtgopy.Location = new System.Drawing.Point(24, 86);
            this.txtgopy.Name = "txtgopy";
            this.txtgopy.Size = new System.Drawing.Size(576, 79);
            this.txtgopy.TabIndex = 33;
            this.txtgopy.Text = "";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(360, 171);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(110, 23);
            this.btThoat.TabIndex = 53;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btql
            // 
            this.btql.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btql.Location = new System.Drawing.Point(245, 171);
            this.btql.Name = "btql";
            this.btql.Size = new System.Drawing.Size(100, 23);
            this.btql.TabIndex = 52;
            this.btql.Text = "Quay lại";
            this.btql.UseVisualStyleBackColor = true;
            this.btql.Click += new System.EventHandler(this.btql_Click);
            // 
            // BTluu
            // 
            this.BTluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTluu.Location = new System.Drawing.Point(142, 171);
            this.BTluu.Name = "BTluu";
            this.BTluu.Size = new System.Drawing.Size(87, 23);
            this.BTluu.TabIndex = 51;
            this.BTluu.Text = "Lưu";
            this.BTluu.UseVisualStyleBackColor = true;
            this.BTluu.Click += new System.EventHandler(this.BTluu_Click);
            // 
            // gopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(612, 203);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.BTluu);
            this.Controls.Add(this.btql);
            this.Controls.Add(this.txtgopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gopy";
            this.Text = "gopy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gopy_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtgopy;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button BTluu;
        private System.Windows.Forms.Button btql;
    }
}