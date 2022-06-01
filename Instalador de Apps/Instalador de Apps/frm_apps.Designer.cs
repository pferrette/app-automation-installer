namespace Instalador_de_Apps
{
    partial class frm_apps
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chk_All = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.clb_apps = new System.Windows.Forms.CheckedListBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_All
            // 
            this.chk_All.AutoSize = true;
            this.chk_All.Location = new System.Drawing.Point(12, 12);
            this.chk_All.Name = "chk_All";
            this.chk_All.Size = new System.Drawing.Size(83, 19);
            this.chk_All.TabIndex = 0;
            this.chk_All.Text = "checkBox1";
            this.chk_All.UseVisualStyleBackColor = true;
            this.chk_All.CheckedChanged += new System.EventHandler(this.chk_All_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(56, 326);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "button1";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(147, 326);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "button2";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // clb_apps
            // 
            this.clb_apps.FormattingEnabled = true;
            this.clb_apps.HorizontalScrollbar = true;
            this.clb_apps.Location = new System.Drawing.Point(12, 37);
            this.clb_apps.Name = "clb_apps";
            this.clb_apps.Size = new System.Drawing.Size(131, 256);
            this.clb_apps.Sorted = true;
            this.clb_apps.TabIndex = 3;
            this.clb_apps.Tag = "";
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(185, 95);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 4;
            this.btn_test.Text = "Tester";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // frm_apps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.clb_apps);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.chk_All);
            this.Name = "frm_apps";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chk_All;
        private Button btn_cancel;
        private Button btn_start;
        private CheckedListBox clb_apps;
        private Button btn_test;
        private Label label1;
    }
}