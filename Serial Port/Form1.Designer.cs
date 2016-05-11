namespace Serial_Port
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Messageshow = new System.Windows.Forms.TextBox();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.PortOopen = new System.Windows.Forms.Button();
            this.BountRate = new System.Windows.Forms.ComboBox();
            this.ui_dataBit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.cmd_list = new System.Windows.Forms.ComboBox();
            this.Send = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Messageshow
            // 
            this.Messageshow.Location = new System.Drawing.Point(4, 129);
            this.Messageshow.Multiline = true;
            this.Messageshow.Name = "Messageshow";
            this.Messageshow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Messageshow.Size = new System.Drawing.Size(679, 304);
            this.Messageshow.TabIndex = 0;
            // 
            // PortList
            // 
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(70, 12);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(121, 20);
            this.PortList.TabIndex = 1;
            // 
            // PortOopen
            // 
            this.PortOopen.Location = new System.Drawing.Point(12, 74);
            this.PortOopen.Name = "PortOopen";
            this.PortOopen.Size = new System.Drawing.Size(75, 23);
            this.PortOopen.TabIndex = 2;
            this.PortOopen.Text = "打开";
            this.PortOopen.UseVisualStyleBackColor = true;
            this.PortOopen.Click += new System.EventHandler(this.button1_Click);
            // 
            // BountRate
            // 
            this.BountRate.FormattingEnabled = true;
            this.BountRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BountRate.Location = new System.Drawing.Point(284, 12);
            this.BountRate.Name = "BountRate";
            this.BountRate.Size = new System.Drawing.Size(121, 20);
            this.BountRate.TabIndex = 3;
            this.BountRate.Text = "9600";
            // 
            // ui_dataBit
            // 
            this.ui_dataBit.FormattingEnabled = true;
            this.ui_dataBit.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ui_dataBit.Location = new System.Drawing.Point(511, 12);
            this.ui_dataBit.Name = "ui_dataBit";
            this.ui_dataBit.Size = new System.Drawing.Size(121, 20);
            this.ui_dataBit.TabIndex = 4;
            this.ui_dataBit.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "数据位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "效验";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "停止位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "流控";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "无",
            "寄校验",
            "偶校验"});
            this.comboBox3.Location = new System.Drawing.Point(70, 38);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.Text = "无";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox4.Location = new System.Drawing.Point(284, 46);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.Text = "1";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "无",
            "硬件",
            "X on/ X Off"});
            this.comboBox5.Location = new System.Drawing.Point(511, 46);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 20);
            this.comboBox5.TabIndex = 13;
            this.comboBox5.Text = "无";
            // 
            // cmd_list
            // 
            this.cmd_list.FormattingEnabled = true;
            this.cmd_list.Location = new System.Drawing.Point(12, 103);
            this.cmd_list.Name = "cmd_list";
            this.cmd_list.Size = new System.Drawing.Size(671, 20);
            this.cmd_list.TabIndex = 14;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(221, 74);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 15;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "清除接收区";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "选择命令文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "关闭";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 434);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.cmd_list);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ui_dataBit);
            this.Controls.Add(this.BountRate);
            this.Controls.Add(this.PortOopen);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.Messageshow);
            this.Name = "Form1";
            this.Text = "串口调试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Messageshow;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Button PortOopen;
        private System.Windows.Forms.ComboBox BountRate;
        private System.Windows.Forms.ComboBox ui_dataBit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox cmd_list;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

