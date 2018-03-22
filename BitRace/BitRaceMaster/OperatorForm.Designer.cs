namespace BitRaceMaster
{
    partial class OperatorForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SQL_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacing_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TCP_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ipAdress_textBox = new System.Windows.Forms.TextBox();
            this.portNumber_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SQL_StatusLabel,
            this.spacing_toolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.TCP_StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 0;
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
            // ipAdress_textBox
            // 
            this.ipAdress_textBox.Location = new System.Drawing.Point(30, 39);
            this.ipAdress_textBox.Name = "ipAdress_textBox";
            this.ipAdress_textBox.Size = new System.Drawing.Size(100, 20);
            this.ipAdress_textBox.TabIndex = 1;
            this.ipAdress_textBox.Text = "127.0.0.1";
            // 
            // portNumber_textBox
            // 
            this.portNumber_textBox.Location = new System.Drawing.Point(154, 39);
            this.portNumber_textBox.Name = "portNumber_textBox";
            this.portNumber_textBox.Size = new System.Drawing.Size(100, 20);
            this.portNumber_textBox.TabIndex = 2;
            this.portNumber_textBox.Text = "8912";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Adress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port Number:";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(278, 23);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 36);
            this.connect_button.TabIndex = 5;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 347);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.connect_button);
            this.tabPage1.Controls.Add(this.ipAdress_textBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.portNumber_textBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamName,
            this.TeamScore});
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeamName
            // 
            this.TeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamName.HeaderText = "Team Name";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            this.TeamName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TeamScore
            // 
            this.TeamScore.HeaderText = "Team Score";
            this.TeamScore.Name = "TeamScore";
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(523, 369);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "OperatorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SQL_StatusLabel;
        private System.Windows.Forms.TextBox ipAdress_textBox;
        private System.Windows.Forms.TextBox portNumber_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.ToolStripStatusLabel spacing_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TCP_StatusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamScore;
    }
}

