namespace Dang_nhap
{
    partial class Trogiup
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
            this.BTgui = new System.Windows.Forms.Button();
            this.btql = new System.Windows.Forms.Button();
            this.txttrogiup = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTgui
            // 
            this.BTgui.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTgui.Location = new System.Drawing.Point(166, 210);
            this.BTgui.Name = "BTgui";
            this.BTgui.Size = new System.Drawing.Size(84, 28);
            this.BTgui.TabIndex = 57;
            this.BTgui.Text = "Gửi";
            this.BTgui.UseVisualStyleBackColor = true;
            this.BTgui.Click += new System.EventHandler(this.BTgui_Click);
            // 
            // btql
            // 
            this.btql.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btql.Location = new System.Drawing.Point(339, 210);
            this.btql.Name = "btql";
            this.btql.Size = new System.Drawing.Size(89, 28);
            this.btql.TabIndex = 58;
            this.btql.Text = "Quay lại";
            this.btql.UseVisualStyleBackColor = true;
            this.btql.Click += new System.EventHandler(this.btql_Click);
            // 
            // txttrogiup
            // 
            this.txttrogiup.Location = new System.Drawing.Point(8, 100);
            this.txttrogiup.Name = "txttrogiup";
            this.txttrogiup.Size = new System.Drawing.Size(576, 79);
            this.txttrogiup.TabIndex = 56;
            this.txttrogiup.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Mời nhập câu hỏi tại đây:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(251, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 54;
            this.label1.Text = "HỖ TRỢ";
            // 
            // Trogiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(587, 262);
            this.Controls.Add(this.BTgui);
            this.Controls.Add(this.btql);
            this.Controls.Add(this.txttrogiup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Trogiup";
            this.Text = "Trogiup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Trogiup_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTgui;
        private System.Windows.Forms.Button btql;
        private System.Windows.Forms.RichTextBox txttrogiup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}