namespace Alarm_kur
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1AlarmKur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3saat = new System.Windows.Forms.Label();
            this.textBox1saat = new System.Windows.Forms.TextBox();
            this.textBox2tarih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3Dur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Saat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarih :";
            // 
            // button1AlarmKur
            // 
            this.button1AlarmKur.BackColor = System.Drawing.Color.BurlyWood;
            this.button1AlarmKur.Location = new System.Drawing.Point(113, 262);
            this.button1AlarmKur.Name = "button1AlarmKur";
            this.button1AlarmKur.Size = new System.Drawing.Size(113, 34);
            this.button1AlarmKur.TabIndex = 2;
            this.button1AlarmKur.Text = "Alarm Kur";
            this.button1AlarmKur.UseVisualStyleBackColor = false;
            this.button1AlarmKur.Click += new System.EventHandler(this.button1AlarmKur_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(64, 302);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(369, 43);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3saat
            // 
            this.label3saat.AutoSize = true;
            this.label3saat.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3saat.Location = new System.Drawing.Point(140, 74);
            this.label3saat.Name = "label3saat";
            this.label3saat.Size = new System.Drawing.Size(27, 32);
            this.label3saat.TabIndex = 0;
            this.label3saat.Text = "..";
            // 
            // textBox1saat
            // 
            this.textBox1saat.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1saat.Location = new System.Drawing.Point(146, 199);
            this.textBox1saat.Name = "textBox1saat";
            this.textBox1saat.Size = new System.Drawing.Size(191, 32);
            this.textBox1saat.TabIndex = 1;
            this.textBox1saat.Text = "00:00:00";
            // 
            // textBox2tarih
            // 
            this.textBox2tarih.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2tarih.Location = new System.Drawing.Point(146, 139);
            this.textBox2tarih.Name = "textBox2tarih";
            this.textBox2tarih.Size = new System.Drawing.Size(191, 32);
            this.textBox2tarih.TabIndex = 0;
            this.textBox2tarih.Text = "01.04.2020";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Saat Girin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tarih Girin :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(405, 361);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 14);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NihatBeyi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3Dur
            // 
            this.button3Dur.BackColor = System.Drawing.Color.BurlyWood;
            this.button3Dur.Location = new System.Drawing.Point(233, 262);
            this.button3Dur.Name = "button3Dur";
            this.button3Dur.Size = new System.Drawing.Size(113, 34);
            this.button3Dur.TabIndex = 16;
            this.button3Dur.Text = "Durdur";
            this.button3Dur.UseVisualStyleBackColor = false;
            this.button3Dur.Click += new System.EventHandler(this.button3Dur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(477, 387);
            this.Controls.Add(this.button3Dur);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2tarih);
            this.Controls.Add(this.textBox1saat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.button1AlarmKur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3saat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tarih ve  Saat Alarm Kur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1AlarmKur;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3saat;
        private System.Windows.Forms.TextBox textBox1saat;
        private System.Windows.Forms.TextBox textBox2tarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3Dur;
    }
}

