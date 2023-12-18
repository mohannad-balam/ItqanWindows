namespace ItqanWindows
{
    partial class ButtonForm
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
            this.Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.myCheckBox = new System.Windows.Forms.CheckBox();
            this.categoriesCb = new System.Windows.Forms.ComboBox();
            this.myDt = new System.Windows.Forms.DateTimePicker();
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.BackColor = System.Drawing.Color.White;
            this.Btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.ForeColor = System.Drawing.Color.Red;
            this.Btn.Location = new System.Drawing.Point(310, 188);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(386, 33);
            this.Btn.TabIndex = 0;
            this.Btn.Text = "Click Me";
            this.Btn.UseVisualStyleBackColor = false;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(203, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click Button";
            // 
            // myCheckBox
            // 
            this.myCheckBox.AutoSize = true;
            this.myCheckBox.Location = new System.Drawing.Point(142, 97);
            this.myCheckBox.Name = "myCheckBox";
            this.myCheckBox.Size = new System.Drawing.Size(67, 20);
            this.myCheckBox.TabIndex = 2;
            this.myCheckBox.Text = "Check";
            this.myCheckBox.UseVisualStyleBackColor = true;
            this.myCheckBox.CheckedChanged += new System.EventHandler(this.myCheckBox_CheckedChanged);
            // 
            // categoriesCb
            // 
            this.categoriesCb.FormattingEnabled = true;
            this.categoriesCb.Items.AddRange(new object[] {
            "Meet",
            "Drinks",
            "Vegetables"});
            this.categoriesCb.Location = new System.Drawing.Point(425, 93);
            this.categoriesCb.Name = "categoriesCb";
            this.categoriesCb.Size = new System.Drawing.Size(197, 24);
            this.categoriesCb.TabIndex = 3;
            this.categoriesCb.SelectedIndexChanged += new System.EventHandler(this.categoriesCb_SelectedIndexChanged);
            // 
            // myDt
            // 
            this.myDt.Location = new System.Drawing.Point(42, 270);
            this.myDt.Name = "myDt";
            this.myDt.Size = new System.Drawing.Size(307, 22);
            this.myDt.TabIndex = 4;
            this.myDt.ValueChanged += new System.EventHandler(this.myDt_ValueChanged);
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(405, 272);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(233, 22);
            this.myTextBox.TabIndex = 5;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(425, 314);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(163, 23);
            this.BtnShow.TabIndex = 6;
            this.BtnShow.Text = "Click To Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // ButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.myTextBox);
            this.Controls.Add(this.myDt);
            this.Controls.Add(this.categoriesCb);
            this.Controls.Add(this.myCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn);
            this.Name = "ButtonForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ButtonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox myCheckBox;
        private System.Windows.Forms.ComboBox categoriesCb;
        private System.Windows.Forms.DateTimePicker myDt;
        private System.Windows.Forms.TextBox myTextBox;
        private System.Windows.Forms.Button BtnShow;
    }
}

