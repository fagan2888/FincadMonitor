namespace FincadMonitor
{
    partial class MonitorApplicationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControle = new System.Windows.Forms.Panel();
            this.gpbCommands = new System.Windows.Forms.GroupBox();
            this.btnKillAllSessions = new System.Windows.Forms.Button();
            this.btnKillSession = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnActiveSessions = new System.Windows.Forms.Button();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tbcStatus = new System.Windows.Forms.TabControl();
            this.tbpWorkers = new System.Windows.Forms.TabPage();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.tbpSessions = new System.Windows.Forms.TabPage();
            this.dgvSession = new System.Windows.Forms.DataGridView();
            this.sttServer = new System.Windows.Forms.StatusStrip();
            this.sslServerConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbpLog = new System.Windows.Forms.TabPage();
            this.WorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatformPortNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerPortNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NResponses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControle.SuspendLayout();
            this.gpbCommands.SuspendLayout();
            this.gpbAddress.SuspendLayout();
            this.tbcStatus.SuspendLayout();
            this.tbpWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.tbpSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).BeginInit();
            this.sttServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControle
            // 
            this.pnlControle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControle.Controls.Add(this.gpbCommands);
            this.pnlControle.Controls.Add(this.gpbAddress);
            this.pnlControle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlControle.Location = new System.Drawing.Point(0, 0);
            this.pnlControle.Name = "pnlControle";
            this.pnlControle.Size = new System.Drawing.Size(916, 65);
            this.pnlControle.TabIndex = 0;
            // 
            // gpbCommands
            // 
            this.gpbCommands.Controls.Add(this.btnKillAllSessions);
            this.gpbCommands.Controls.Add(this.btnKillSession);
            this.gpbCommands.Controls.Add(this.btnWorkers);
            this.gpbCommands.Controls.Add(this.btnActiveSessions);
            this.gpbCommands.Location = new System.Drawing.Point(656, 11);
            this.gpbCommands.Name = "gpbCommands";
            this.gpbCommands.Size = new System.Drawing.Size(251, 49);
            this.gpbCommands.TabIndex = 1;
            this.gpbCommands.TabStop = false;
            this.gpbCommands.Text = "Comands";
            // 
            // btnKillAllSessions
            // 
            this.btnKillAllSessions.Location = new System.Drawing.Point(186, 14);
            this.btnKillAllSessions.Name = "btnKillAllSessions";
            this.btnKillAllSessions.Size = new System.Drawing.Size(60, 23);
            this.btnKillAllSessions.TabIndex = 3;
            this.btnKillAllSessions.Text = "Kill All";
            this.btnKillAllSessions.UseVisualStyleBackColor = true;
            this.btnKillAllSessions.Click += new System.EventHandler(this.btnKillAllSessions_Click);
            // 
            // btnKillSession
            // 
            this.btnKillSession.Location = new System.Drawing.Point(126, 14);
            this.btnKillSession.Name = "btnKillSession";
            this.btnKillSession.Size = new System.Drawing.Size(60, 23);
            this.btnKillSession.TabIndex = 2;
            this.btnKillSession.Text = "Kill Sess.";
            this.btnKillSession.UseVisualStyleBackColor = true;
            this.btnKillSession.Click += new System.EventHandler(this.btnKillSession_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Location = new System.Drawing.Point(66, 14);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(60, 23);
            this.btnWorkers.TabIndex = 1;
            this.btnWorkers.Text = "Workers";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnActiveSessions
            // 
            this.btnActiveSessions.Location = new System.Drawing.Point(6, 14);
            this.btnActiveSessions.Name = "btnActiveSessions";
            this.btnActiveSessions.Size = new System.Drawing.Size(60, 23);
            this.btnActiveSessions.TabIndex = 0;
            this.btnActiveSessions.Text = "Sessions";
            this.btnActiveSessions.UseVisualStyleBackColor = true;
            this.btnActiveSessions.Click += new System.EventHandler(this.btnActiveSessions_Click);
            // 
            // gpbAddress
            // 
            this.gpbAddress.Controls.Add(this.textBox3);
            this.gpbAddress.Controls.Add(this.label2);
            this.gpbAddress.Controls.Add(this.textBox2);
            this.gpbAddress.Controls.Add(this.label1);
            this.gpbAddress.Controls.Add(this.btnConnect);
            this.gpbAddress.Controls.Add(this.txtPort);
            this.gpbAddress.Controls.Add(this.lblPort);
            this.gpbAddress.Controls.Add(this.lblAddress);
            this.gpbAddress.Controls.Add(this.txtAddress);
            this.gpbAddress.Location = new System.Drawing.Point(11, 11);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(639, 49);
            this.gpbAddress.TabIndex = 0;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(472, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 21);
            this.textBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Callback:";
            // 
            // btnConnect
            // 
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.Location = new System.Drawing.Point(545, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(69, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(203, 16);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(68, 21);
            this.txtPort.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(167, 20);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 20);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(62, 16);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 21);
            this.txtAddress.TabIndex = 0;
            // 
            // tbcStatus
            // 
            this.tbcStatus.Controls.Add(this.tbpWorkers);
            this.tbcStatus.Controls.Add(this.tbpSessions);
            this.tbcStatus.Controls.Add(this.tbpLog);
            this.tbcStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcStatus.Location = new System.Drawing.Point(0, 65);
            this.tbcStatus.Name = "tbcStatus";
            this.tbcStatus.SelectedIndex = 0;
            this.tbcStatus.Size = new System.Drawing.Size(916, 411);
            this.tbcStatus.TabIndex = 1;
            // 
            // tbpWorkers
            // 
            this.tbpWorkers.Controls.Add(this.dgvWorkers);
            this.tbpWorkers.Location = new System.Drawing.Point(4, 22);
            this.tbpWorkers.Name = "tbpWorkers";
            this.tbpWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWorkers.Size = new System.Drawing.Size(908, 385);
            this.tbpWorkers.TabIndex = 1;
            this.tbpWorkers.Text = "Workers";
            this.tbpWorkers.UseVisualStyleBackColor = true;
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.AllowUserToDeleteRows = false;
            this.dgvWorkers.AllowUserToOrderColumns = true;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkerID,
            this.PlatformPortNumber,
            this.WorkerIPAddress,
            this.WorkerPortNumber,
            this.SessionID,
            this.NRequest,
            this.NResponses,
            this.LastRequest});
            this.dgvWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkers.Location = new System.Drawing.Point(3, 3);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.Size = new System.Drawing.Size(902, 379);
            this.dgvWorkers.TabIndex = 0;
            // 
            // tbpSessions
            // 
            this.tbpSessions.Controls.Add(this.dgvSession);
            this.tbpSessions.Controls.Add(this.sttServer);
            this.tbpSessions.Location = new System.Drawing.Point(4, 22);
            this.tbpSessions.Name = "tbpSessions";
            this.tbpSessions.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSessions.Size = new System.Drawing.Size(908, 385);
            this.tbpSessions.TabIndex = 0;
            this.tbpSessions.Text = "Sessions";
            this.tbpSessions.UseVisualStyleBackColor = true;
            // 
            // dgvSession
            // 
            this.dgvSession.AllowUserToOrderColumns = true;
            this.dgvSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSession.Location = new System.Drawing.Point(3, 3);
            this.dgvSession.Name = "dgvSession";
            this.dgvSession.Size = new System.Drawing.Size(902, 357);
            this.dgvSession.TabIndex = 0;
            // 
            // sttServer
            // 
            this.sttServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslServerConnection});
            this.sttServer.Location = new System.Drawing.Point(3, 360);
            this.sttServer.Name = "sttServer";
            this.sttServer.Size = new System.Drawing.Size(902, 22);
            this.sttServer.TabIndex = 1;
            this.sttServer.Text = "sttServer";
            // 
            // sslServerConnection
            // 
            this.sslServerConnection.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.sslServerConnection.Name = "sslServerConnection";
            this.sslServerConnection.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.sslServerConnection.Size = new System.Drawing.Size(0, 17);
            // 
            // tbpLog
            // 
            this.tbpLog.Location = new System.Drawing.Point(4, 22);
            this.tbpLog.Name = "tbpLog";
            this.tbpLog.Size = new System.Drawing.Size(908, 385);
            this.tbpLog.TabIndex = 2;
            this.tbpLog.Text = "Log";
            this.tbpLog.UseVisualStyleBackColor = true;
            // 
            // WorkerID
            // 
            this.WorkerID.DataPropertyName = "WorkerID";
            this.WorkerID.HeaderText = "Worker";
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.ReadOnly = true;
            // 
            // PlatformPortNumber
            // 
            this.PlatformPortNumber.DataPropertyName = "PlatformPortNumber";
            this.PlatformPortNumber.HeaderText = "Plat. Port";
            this.PlatformPortNumber.Name = "PlatformPortNumber";
            this.PlatformPortNumber.ReadOnly = true;
            // 
            // WorkerIPAddress
            // 
            this.WorkerIPAddress.DataPropertyName = "WorkerIPAddress";
            this.WorkerIPAddress.HeaderText = "Worker IP";
            this.WorkerIPAddress.Name = "WorkerIPAddress";
            this.WorkerIPAddress.ReadOnly = true;
            // 
            // WorkerPortNumber
            // 
            this.WorkerPortNumber.DataPropertyName = "WorkerPortNumber";
            this.WorkerPortNumber.HeaderText = "Worker Port";
            this.WorkerPortNumber.Name = "WorkerPortNumber";
            this.WorkerPortNumber.ReadOnly = true;
            // 
            // SessionID
            // 
            this.SessionID.DataPropertyName = "SessionID";
            this.SessionID.HeaderText = "Session";
            this.SessionID.Name = "SessionID";
            this.SessionID.ReadOnly = true;
            // 
            // NRequest
            // 
            this.NRequest.DataPropertyName = "NRequest";
            this.NRequest.HeaderText = "Requests";
            this.NRequest.Name = "NRequest";
            this.NRequest.ReadOnly = true;
            // 
            // NResponses
            // 
            this.NResponses.DataPropertyName = "NResponses";
            this.NResponses.HeaderText = "Response";
            this.NResponses.Name = "NResponses";
            this.NResponses.ReadOnly = true;
            // 
            // LastRequest
            // 
            this.LastRequest.DataPropertyName = "LastRequest";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm:ss";
            this.LastRequest.DefaultCellStyle = dataGridViewCellStyle3;
            this.LastRequest.HeaderText = "Last Req.";
            this.LastRequest.Name = "LastRequest";
            this.LastRequest.ReadOnly = true;
            // 
            // MonitorApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 476);
            this.Controls.Add(this.tbcStatus);
            this.Controls.Add(this.pnlControle);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MonitorApplicationForm";
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonitorApplicationForm_FormClosing);
            this.Load += new System.EventHandler(this.MonitorApplicationForm_Load);
            this.pnlControle.ResumeLayout(false);
            this.gpbCommands.ResumeLayout(false);
            this.gpbAddress.ResumeLayout(false);
            this.gpbAddress.PerformLayout();
            this.tbcStatus.ResumeLayout(false);
            this.tbpWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.tbpSessions.ResumeLayout(false);
            this.tbpSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).EndInit();
            this.sttServer.ResumeLayout(false);
            this.sttServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControle;
        private System.Windows.Forms.GroupBox gpbAddress;
        private System.Windows.Forms.GroupBox gpbCommands;
        private System.Windows.Forms.Button btnKillAllSessions;
        private System.Windows.Forms.Button btnKillSession;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnActiveSessions;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TabControl tbcStatus;
        private System.Windows.Forms.TabPage tbpSessions;
        private System.Windows.Forms.DataGridView dgvSession;
        private System.Windows.Forms.TabPage tbpWorkers;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.TabPage tbpLog;
        private System.Windows.Forms.StatusStrip sttServer;
        private System.Windows.Forms.ToolStripStatusLabel sslServerConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatformPortNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerPortNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn NResponses;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRequest;

    }
}

