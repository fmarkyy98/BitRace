namespace BitRacePlayer
{
    partial class ViewForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SQL_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacing_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TCP_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.submit_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.ipAdress_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portNumber_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelD = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.send_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.error_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SQL_StatusLabel,
            this.spacing_toolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.TCP_StatusLabel,
            this.toolStripStatusLabel3,
            this.error_StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "SQL State:";
            // 
            // SQL_StatusLabel
            // 
            this.SQL_StatusLabel.AutoSize = false;
            this.SQL_StatusLabel.Name = "SQL_StatusLabel";
            this.SQL_StatusLabel.Size = new System.Drawing.Size(79, 17);
            this.SQL_StatusLabel.Text = "Disconnected";
            this.SQL_StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spacing_toolStripStatusLabel
            // 
            this.spacing_toolStripStatusLabel.Name = "spacing_toolStripStatusLabel";
            this.spacing_toolStripStatusLabel.Size = new System.Drawing.Size(49, 17);
            this.spacing_toolStripStatusLabel.Text = "              ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel2.Text = "TCP/IP State:";
            // 
            // TCP_StatusLabel
            // 
            this.TCP_StatusLabel.Name = "TCP_StatusLabel";
            this.TCP_StatusLabel.Size = new System.Drawing.Size(79, 17);
            this.TCP_StatusLabel.Text = "Disconnected";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 340);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.submit_button);
            this.tabPage1.Controls.Add(this.name_textBox);
            this.tabPage1.Controls.Add(this.connect_button);
            this.tabPage1.Controls.Add(this.ipAdress_textBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.portNumber_textBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(365, 38);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(82, 23);
            this.submit_button.TabIndex = 12;
            this.submit_button.Text = "Submit Name";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(112, 40);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(247, 20);
            this.name_textBox.TabIndex = 11;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(333, 186);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 36);
            this.connect_button.TabIndex = 10;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // ipAdress_textBox
            // 
            this.ipAdress_textBox.Location = new System.Drawing.Point(85, 202);
            this.ipAdress_textBox.Name = "ipAdress_textBox";
            this.ipAdress_textBox.Size = new System.Drawing.Size(100, 20);
            this.ipAdress_textBox.TabIndex = 6;
            this.ipAdress_textBox.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port Number:";
            // 
            // portNumber_textBox
            // 
            this.portNumber_textBox.Location = new System.Drawing.Point(209, 202);
            this.portNumber_textBox.Name = "portNumber_textBox";
            this.portNumber_textBox.Size = new System.Drawing.Size(100, 20);
            this.portNumber_textBox.TabIndex = 7;
            this.portNumber_textBox.Text = "8912";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP Adress:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxQuestion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 308);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.Color.White;
            this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuestion.Location = new System.Drawing.Point(3, 3);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(564, 178);
            this.textBoxQuestion.TabIndex = 4;
            this.textBoxQuestion.Text = "Questin 1.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.send_button, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 187);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 118);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel3.Controls.Add(this.labelD, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelC, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelB, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelA, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonA, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonB, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonC, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonD, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(473, 112);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // labelD
            // 
            this.labelD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelD.Location = new System.Drawing.Point(3, 89);
            this.labelD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(36, 20);
            this.labelD.TabIndex = 6;
            this.labelD.Text = "d:";
            this.labelD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelC
            // 
            this.labelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelC.Location = new System.Drawing.Point(3, 61);
            this.labelC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(36, 20);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "c:";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelB
            // 
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Location = new System.Drawing.Point(3, 33);
            this.labelB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(36, 20);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "b:";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelA
            // 
            this.labelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelA.Location = new System.Drawing.Point(3, 5);
            this.labelA.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(36, 20);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a:";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(45, 3);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(37, 17);
            this.radioButtonA.TabIndex = 7;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "a1";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(45, 31);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(37, 17);
            this.radioButtonB.TabIndex = 8;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "a2";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(45, 59);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(37, 17);
            this.radioButtonC.TabIndex = 9;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "a3";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(45, 87);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(37, 17);
            this.radioButtonD.TabIndex = 10;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "a4";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // send_button
            // 
            this.send_button.AutoSize = true;
            this.send_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.send_button.Location = new System.Drawing.Point(482, 3);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(79, 112);
            this.send_button.TabIndex = 7;
            this.send_button.Text = "Send Answer";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel3.Text = "              ";
            // 
            // error_StatusLabel
            // 
            this.error_StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.error_StatusLabel.Name = "error_StatusLabel";
            this.error_StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ViewForm";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SQL_StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel spacing_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TCP_StatusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox ipAdress_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portNumber_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel error_StatusLabel;
    }
}

