
namespace WinFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.led_off_btn = new System.Windows.Forms.Button();
            this.led_on_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.led_txt = new System.Windows.Forms.TextBox();
            this.tmp_txt = new System.Windows.Forms.TextBox();
            this.light_txt = new System.Windows.Forms.TextBox();
            this.dis_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.conn_btn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(110, 32);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(75, 23);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17"});
            this.comboBox1.Location = new System.Drawing.Point(6, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.led_off_btn);
            this.groupBox2.Controls.Add(this.led_on_btn);
            this.groupBox2.Location = new System.Drawing.Point(26, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // led_off_btn
            // 
            this.led_off_btn.Location = new System.Drawing.Point(110, 31);
            this.led_off_btn.Name = "led_off_btn";
            this.led_off_btn.Size = new System.Drawing.Size(75, 48);
            this.led_off_btn.TabIndex = 1;
            this.led_off_btn.Text = "OFF";
            this.led_off_btn.UseVisualStyleBackColor = true;
            this.led_off_btn.Click += new System.EventHandler(this.led_off_btn_Click);
            // 
            // led_on_btn
            // 
            this.led_on_btn.Location = new System.Drawing.Point(17, 31);
            this.led_on_btn.Name = "led_on_btn";
            this.led_on_btn.Size = new System.Drawing.Size(75, 48);
            this.led_on_btn.TabIndex = 0;
            this.led_on_btn.Text = "ON";
            this.led_on_btn.UseVisualStyleBackColor = true;
            this.led_on_btn.Click += new System.EventHandler(this.led_on_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.led_txt);
            this.groupBox3.Location = new System.Drawing.Point(26, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 46);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "점등 상태";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tmp_txt);
            this.groupBox4.Location = new System.Drawing.Point(26, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 50);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "온도 센서";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.light_txt);
            this.groupBox5.Location = new System.Drawing.Point(26, 339);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 50);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "조도 센서";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dis_txt);
            this.groupBox6.Location = new System.Drawing.Point(26, 407);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 50);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "초음파 센서";
            // 
            // led_txt
            // 
            this.led_txt.Location = new System.Drawing.Point(17, 17);
            this.led_txt.Name = "led_txt";
            this.led_txt.Size = new System.Drawing.Size(168, 23);
            this.led_txt.TabIndex = 0;
            this.led_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tmp_txt
            // 
            this.tmp_txt.Location = new System.Drawing.Point(17, 21);
            this.tmp_txt.Name = "tmp_txt";
            this.tmp_txt.Size = new System.Drawing.Size(168, 23);
            this.tmp_txt.TabIndex = 1;
            // 
            // light_txt
            // 
            this.light_txt.Location = new System.Drawing.Point(17, 21);
            this.light_txt.Name = "light_txt";
            this.light_txt.Size = new System.Drawing.Size(168, 23);
            this.light_txt.TabIndex = 1;
            // 
            // dis_txt
            // 
            this.dis_txt.Location = new System.Drawing.Point(17, 21);
            this.dis_txt.Name = "dis_txt";
            this.dis_txt.Size = new System.Drawing.Size(168, 23);
            this.dis_txt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 485);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button led_off_btn;
        private System.Windows.Forms.Button led_on_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox led_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tmp_txt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox light_txt;
        private System.Windows.Forms.TextBox dis_txt;
    }
}
