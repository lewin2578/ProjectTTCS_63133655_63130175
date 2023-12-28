namespace ProjectTTCS_63133655_63130175
{
    partial class simForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(simForm));
            this.lblGantt = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlGantt = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridInput = new System.Windows.Forms.DataGridView();
            this.gridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPrior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuantum = new System.Windows.Forms.Panel();
            this.quantumInput = new System.Windows.Forms.NumericUpDown();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.pnlPreemp = new System.Windows.Forms.Panel();
            this.radioPreemp = new System.Windows.Forms.RadioButton();
            this.radioNonPreemp = new System.Windows.Forms.RadioButton();
            this.lblAppName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sitemFCFS = new System.Windows.Forms.ToolStripMenuItem();
            this.sitemSJF = new System.Windows.Forms.ToolStripMenuItem();
            this.sitemRR = new System.Windows.Forms.ToolStripMenuItem();
            this.sitemPrior = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSign = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInput)).BeginInit();
            this.pnlQuantum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantumInput)).BeginInit();
            this.pnlPreemp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGantt
            // 
            this.lblGantt.AutoSize = true;
            this.lblGantt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGantt.Location = new System.Drawing.Point(14, 267);
            this.lblGantt.Name = "lblGantt";
            this.lblGantt.Size = new System.Drawing.Size(93, 20);
            this.lblGantt.TabIndex = 28;
            this.lblGantt.Text = "Gantt chart";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOutput.Location = new System.Drawing.Point(14, 353);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(59, 20);
            this.lblOutput.TabIndex = 27;
            this.lblOutput.Text = "Output";
            // 
            // pnlGantt
            // 
            this.pnlGantt.AutoScroll = true;
            this.pnlGantt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGantt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnlGantt.Location = new System.Drawing.Point(18, 290);
            this.pnlGantt.Name = "pnlGantt";
            this.pnlGantt.Size = new System.Drawing.Size(690, 60);
            this.pnlGantt.TabIndex = 26;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOutput.ForeColor = System.Drawing.Color.Aqua;
            this.txtOutput.Location = new System.Drawing.Point(18, 376);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(690, 131);
            this.txtOutput.TabIndex = 25;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReset.Location = new System.Drawing.Point(636, 205);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 43);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Lime;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRun.Location = new System.Drawing.Point(636, 156);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(72, 43);
            this.btnRun.TabIndex = 23;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDelete.Location = new System.Drawing.Point(636, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 43);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Location = new System.Drawing.Point(636, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 43);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridInput
            // 
            this.dataGridInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridName,
            this.gridQueue,
            this.gridCPU,
            this.gridPrior});
            this.dataGridInput.Location = new System.Drawing.Point(217, 58);
            this.dataGridInput.Name = "dataGridInput";
            this.dataGridInput.RowHeadersWidth = 51;
            this.dataGridInput.RowTemplate.Height = 24;
            this.dataGridInput.Size = new System.Drawing.Size(404, 190);
            this.dataGridInput.TabIndex = 20;
            // 
            // gridName
            // 
            this.gridName.HeaderText = "Tiến trình";
            this.gridName.MinimumWidth = 6;
            this.gridName.Name = "gridName";
            this.gridName.Width = 125;
            // 
            // gridQueue
            // 
            this.gridQueue.HeaderText = "Thời gian đến";
            this.gridQueue.MinimumWidth = 6;
            this.gridQueue.Name = "gridQueue";
            this.gridQueue.Width = 75;
            // 
            // gridCPU
            // 
            this.gridCPU.HeaderText = "Thời gian CPU";
            this.gridCPU.MinimumWidth = 6;
            this.gridCPU.Name = "gridCPU";
            this.gridCPU.Width = 75;
            // 
            // gridPrior
            // 
            this.gridPrior.HeaderText = "Độ ưu tiên";
            this.gridPrior.MinimumWidth = 6;
            this.gridPrior.Name = "gridPrior";
            this.gridPrior.Visible = false;
            this.gridPrior.Width = 75;
            // 
            // pnlQuantum
            // 
            this.pnlQuantum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlQuantum.Controls.Add(this.quantumInput);
            this.pnlQuantum.Controls.Add(this.lblQuantum);
            this.pnlQuantum.Location = new System.Drawing.Point(18, 107);
            this.pnlQuantum.Name = "pnlQuantum";
            this.pnlQuantum.Size = new System.Drawing.Size(173, 71);
            this.pnlQuantum.TabIndex = 19;
            this.pnlQuantum.Visible = false;
            // 
            // quantumInput
            // 
            this.quantumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.quantumInput.Location = new System.Drawing.Point(83, 25);
            this.quantumInput.Name = "quantumInput";
            this.quantumInput.Size = new System.Drawing.Size(71, 24);
            this.quantumInput.TabIndex = 31;
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQuantum.Location = new System.Drawing.Point(12, 27);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(69, 18);
            this.lblQuantum.TabIndex = 21;
            this.lblQuantum.Text = "Quantum";
            // 
            // pnlPreemp
            // 
            this.pnlPreemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPreemp.Controls.Add(this.radioPreemp);
            this.pnlPreemp.Controls.Add(this.radioNonPreemp);
            this.pnlPreemp.Location = new System.Drawing.Point(18, 107);
            this.pnlPreemp.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPreemp.Name = "pnlPreemp";
            this.pnlPreemp.Size = new System.Drawing.Size(173, 71);
            this.pnlPreemp.TabIndex = 18;
            this.pnlPreemp.Visible = false;
            // 
            // radioPreemp
            // 
            this.radioPreemp.AutoSize = true;
            this.radioPreemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioPreemp.Location = new System.Drawing.Point(17, 35);
            this.radioPreemp.Name = "radioPreemp";
            this.radioPreemp.Size = new System.Drawing.Size(144, 22);
            this.radioPreemp.TabIndex = 20;
            this.radioPreemp.Text = "Không độc quyền";
            this.radioPreemp.UseVisualStyleBackColor = true;
            // 
            // radioNonPreemp
            // 
            this.radioNonPreemp.AutoSize = true;
            this.radioNonPreemp.Checked = true;
            this.radioNonPreemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioNonPreemp.Location = new System.Drawing.Point(17, 7);
            this.radioNonPreemp.Name = "radioNonPreemp";
            this.radioNonPreemp.Size = new System.Drawing.Size(100, 22);
            this.radioNonPreemp.TabIndex = 19;
            this.radioNonPreemp.TabStop = true;
            this.radioNonPreemp.Text = "Độc quyền";
            this.radioNonPreemp.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAppName.Location = new System.Drawing.Point(212, 16);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(324, 29);
            this.lblAppName.TabIndex = 17;
            this.lblAppName.Text = "Mô phỏng điều phối tiến trình";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseStrip});
            this.menuStrip1.Location = new System.Drawing.Point(35, 45);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(137, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseStrip
            // 
            this.chooseStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sitemFCFS,
            this.sitemSJF,
            this.sitemRR,
            this.sitemPrior});
            this.chooseStrip.Name = "chooseStrip";
            this.chooseStrip.Size = new System.Drawing.Size(129, 24);
            this.chooseStrip.Text = "Chọn chiến lược";
            this.chooseStrip.Click += new System.EventHandler(this.chooseStrip_Click);
            // 
            // sitemFCFS
            // 
            this.sitemFCFS.Name = "sitemFCFS";
            this.sitemFCFS.Size = new System.Drawing.Size(242, 26);
            this.sitemFCFS.Text = "First Come First Served";
            this.sitemFCFS.Click += new System.EventHandler(this.FCFS_Choose);
            // 
            // sitemSJF
            // 
            this.sitemSJF.Name = "sitemSJF";
            this.sitemSJF.Size = new System.Drawing.Size(242, 26);
            this.sitemSJF.Text = "Shortest Job First";
            this.sitemSJF.Click += new System.EventHandler(this.SJF_Choose);
            // 
            // sitemRR
            // 
            this.sitemRR.Name = "sitemRR";
            this.sitemRR.Size = new System.Drawing.Size(242, 26);
            this.sitemRR.Text = "Round Robin";
            this.sitemRR.Click += new System.EventHandler(this.RR_Choose);
            // 
            // sitemPrior
            // 
            this.sitemPrior.Name = "sitemPrior";
            this.sitemPrior.Size = new System.Drawing.Size(242, 26);
            this.sitemPrior.Text = "Priority";
            this.sitemPrior.Click += new System.EventHandler(this.Prior_Choose);
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSign.Location = new System.Drawing.Point(36, 16);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(138, 32);
            this.lblSign.TabIndex = 30;
            this.lblSign.Text = "Bấm vào đây để chọn\r\n                 ↓";
            // 
            // lblChoose
            // 
            this.lblChoose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChoose.Location = new System.Drawing.Point(18, 73);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(173, 26);
            this.lblChoose.TabIndex = 29;
            this.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(732, 523);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblGantt);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pnlGantt);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridInput);
            this.Controls.Add(this.pnlQuantum);
            this.Controls.Add(this.pnlPreemp);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "simForm";
            this.Text = "MÔ PHỎNG CÁC CHIẾN LƯỢC ĐIỀU PHỐI TIẾN TRÌNH";
            this.Load += new System.EventHandler(this.simForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInput)).EndInit();
            this.pnlQuantum.ResumeLayout(false);
            this.pnlQuantum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantumInput)).EndInit();
            this.pnlPreemp.ResumeLayout(false);
            this.pnlPreemp.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGantt;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel pnlGantt;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPrior;
        private System.Windows.Forms.Panel pnlQuantum;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.Panel pnlPreemp;
        private System.Windows.Forms.RadioButton radioPreemp;
        private System.Windows.Forms.RadioButton radioNonPreemp;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseStrip;
        private System.Windows.Forms.ToolStripMenuItem sitemFCFS;
        private System.Windows.Forms.ToolStripMenuItem sitemSJF;
        private System.Windows.Forms.ToolStripMenuItem sitemRR;
        private System.Windows.Forms.ToolStripMenuItem sitemPrior;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.NumericUpDown quantumInput;
    }
}

