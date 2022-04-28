namespace HQ_Dork_Gen
{
    partial class MainApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.dorkListBox = new System.Windows.Forms.RichTextBox();
            this.consoleLogs = new System.Windows.Forms.RichTextBox();
            this.dorkCollection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateDorks = new System.Windows.Forms.Button();
            this.LoadBot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPix4 = new System.Windows.Forms.Label();
            this.textToolname = new System.Windows.Forms.Label();
            this.textByZ3ntl3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusTXT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.textDorks = new System.Windows.Forms.Label();
            this.textLog = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addDorkBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dorkListBox
            // 
            this.dorkListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.dorkListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dorkListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dorkListBox.ForeColor = System.Drawing.Color.White;
            this.dorkListBox.Location = new System.Drawing.Point(12, 107);
            this.dorkListBox.Name = "dorkListBox";
            this.dorkListBox.Size = new System.Drawing.Size(658, 389);
            this.dorkListBox.TabIndex = 0;
            this.dorkListBox.Text = "";
            // 
            // consoleLogs
            // 
            this.consoleLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.consoleLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleLogs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLogs.Location = new System.Drawing.Point(680, 107);
            this.consoleLogs.Name = "consoleLogs";
            this.consoleLogs.Size = new System.Drawing.Size(144, 389);
            this.consoleLogs.TabIndex = 1;
            this.consoleLogs.Text = "";
            // 
            // dorkCollection
            // 
            this.dorkCollection.BackColor = System.Drawing.Color.White;
            this.dorkCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.dorkCollection.FormattingEnabled = true;
            this.dorkCollection.Items.AddRange(new object[] {
            "/wp-content/themes/"});
            this.dorkCollection.Location = new System.Drawing.Point(691, 517);
            this.dorkCollection.Name = "dorkCollection";
            this.dorkCollection.Size = new System.Drawing.Size(121, 21);
            this.dorkCollection.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(688, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dork Collection";
            // 
            // GenerateDorks
            // 
            this.GenerateDorks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.GenerateDorks.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateDorks.ForeColor = System.Drawing.Color.White;
            this.GenerateDorks.Location = new System.Drawing.Point(702, 544);
            this.GenerateDorks.Name = "GenerateDorks";
            this.GenerateDorks.Size = new System.Drawing.Size(90, 25);
            this.GenerateDorks.TabIndex = 4;
            this.GenerateDorks.Text = "Generate";
            this.GenerateDorks.UseVisualStyleBackColor = false;
            this.GenerateDorks.Click += new System.EventHandler(this.GenerateDorks_Click);
            // 
            // LoadBot
            // 
            this.LoadBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.LoadBot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBot.ForeColor = System.Drawing.Color.White;
            this.LoadBot.Location = new System.Drawing.Point(12, 517);
            this.LoadBot.Name = "LoadBot";
            this.LoadBot.Size = new System.Drawing.Size(124, 37);
            this.LoadBot.TabIndex = 5;
            this.LoadBot.Text = "Load Bot";
            this.LoadBot.UseVisualStyleBackColor = false;
            this.LoadBot.Click += new System.EventHandler(this.LoadBot_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.textPix4);
            this.panel1.Controls.Add(this.textToolname);
            this.panel1.Controls.Add(this.textByZ3ntl3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.statusTXT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-26, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 63);
            this.panel1.TabIndex = 6;
            // 
            // textPix4
            // 
            this.textPix4.AutoSize = true;
            this.textPix4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPix4.ForeColor = System.Drawing.Color.White;
            this.textPix4.Location = new System.Drawing.Point(102, 9);
            this.textPix4.Name = "textPix4";
            this.textPix4.Size = new System.Drawing.Size(102, 30);
            this.textPix4.TabIndex = 2;
            this.textPix4.Text = "Pix4Devs";
            // 
            // textToolname
            // 
            this.textToolname.AutoSize = true;
            this.textToolname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToolname.ForeColor = System.Drawing.Color.White;
            this.textToolname.Location = new System.Drawing.Point(104, 37);
            this.textToolname.Name = "textToolname";
            this.textToolname.Size = new System.Drawing.Size(122, 17);
            this.textToolname.TabIndex = 0;
            this.textToolname.Text = "HQ Dork Generator";
            // 
            // textByZ3ntl3
            // 
            this.textByZ3ntl3.AutoSize = true;
            this.textByZ3ntl3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textByZ3ntl3.ForeColor = System.Drawing.Color.Gray;
            this.textByZ3ntl3.Location = new System.Drawing.Point(201, 20);
            this.textByZ3ntl3.Name = "textByZ3ntl3";
            this.textByZ3ntl3.Size = new System.Drawing.Size(66, 15);
            this.textByZ3ntl3.TabIndex = 3;
            this.textByZ3ntl3.Text = "by Z3NTL3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel2.Location = new System.Drawing.Point(96, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 45);
            this.panel2.TabIndex = 14;
            // 
            // statusTXT
            // 
            this.statusTXT.AutoSize = true;
            this.statusTXT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTXT.ForeColor = System.Drawing.Color.Gray;
            this.statusTXT.Location = new System.Drawing.Point(398, 37);
            this.statusTXT.Name = "statusTXT";
            this.statusTXT.Size = new System.Drawing.Size(0, 21);
            this.statusTXT.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(396, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fetch Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(818, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "_";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(843, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(143, 517);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(124, 37);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // textDorks
            // 
            this.textDorks.AutoSize = true;
            this.textDorks.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDorks.ForeColor = System.Drawing.Color.White;
            this.textDorks.Location = new System.Drawing.Point(12, 74);
            this.textDorks.Name = "textDorks";
            this.textDorks.Size = new System.Drawing.Size(308, 30);
            this.textDorks.TabIndex = 8;
            this.textDorks.Text = "Generated High Quality Dorks";
            // 
            // textLog
            // 
            this.textLog.AutoSize = true;
            this.textLog.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLog.ForeColor = System.Drawing.Color.White;
            this.textLog.Location = new System.Drawing.Point(675, 74);
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(59, 30);
            this.textLog.TabIndex = 9;
            this.textLog.Text = "Logs";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(567, 518);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(564, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Add Custom Dork";
            // 
            // addDorkBTN
            // 
            this.addDorkBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.addDorkBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDorkBTN.ForeColor = System.Drawing.Color.White;
            this.addDorkBTN.Location = new System.Drawing.Point(567, 544);
            this.addDorkBTN.Name = "addDorkBTN";
            this.addDorkBTN.Size = new System.Drawing.Size(90, 25);
            this.addDorkBTN.TabIndex = 12;
            this.addDorkBTN.Text = "Add";
            this.addDorkBTN.UseVisualStyleBackColor = false;
            this.addDorkBTN.Click += new System.EventHandler(this.addDorkBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(273, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Our Github";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this.panel2;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panel2;
            this.bunifuDragControl3.Vertical = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(403, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Status";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(843, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addDorkBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.textDorks);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoadBot);
            this.Controls.Add(this.GenerateDorks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dorkCollection);
            this.Controls.Add(this.consoleLogs);
            this.Controls.Add(this.dorkListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HQ Dork Gen by Z3NTL3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dorkListBox;
        private System.Windows.Forms.RichTextBox consoleLogs;
        private System.Windows.Forms.ComboBox dorkCollection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateDorks;
        private System.Windows.Forms.Button LoadBot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textPix4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textToolname;
        private System.Windows.Forms.Label textByZ3ntl3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label textDorks;
        private System.Windows.Forms.Label textLog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addDorkBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Button button2;
    }
}

