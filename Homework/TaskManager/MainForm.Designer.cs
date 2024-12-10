namespace TaskManager
{
	partial class MainForm
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageProcesses = new System.Windows.Forms.TabPage();
			this.statusStripProcesses = new System.Windows.Forms.StatusStrip();
			this.labelProcessAmount = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripRefresh = new System.Windows.Forms.ToolStripStatusLabel();
			this.lvProcesses = new TaskManager.ListViewEx();
			this.colProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuProcessList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.endTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuColumns = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.pIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cpuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnEndTask = new System.Windows.Forms.Button();
			this.tabPagePerformance = new System.Windows.Forms.TabPage();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startNewProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.topmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideWhenMinimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pausedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.timerUpdate = new System.Windows.Forms.Timer(this.components);
			this.tabControl.SuspendLayout();
			this.tabPageProcesses.SuspendLayout();
			this.statusStripProcesses.SuspendLayout();
			this.contextMenuProcessList.SuspendLayout();
			this.contextMenuColumns.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageProcesses);
			this.tabControl.Controls.Add(this.tabPagePerformance);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(540, 357);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageProcesses
			// 
			this.tabPageProcesses.Controls.Add(this.statusStripProcesses);
			this.tabPageProcesses.Controls.Add(this.lvProcesses);
			this.tabPageProcesses.Controls.Add(this.btnEndTask);
			this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
			this.tabPageProcesses.Name = "tabPageProcesses";
			this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProcesses.Size = new System.Drawing.Size(532, 331);
			this.tabPageProcesses.TabIndex = 0;
			this.tabPageProcesses.Text = "Processes";
			this.tabPageProcesses.UseVisualStyleBackColor = true;
			// 
			// statusStripProcesses
			// 
			this.statusStripProcesses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelProcessAmount,
            this.toolStripRefresh});
			this.statusStripProcesses.Location = new System.Drawing.Point(3, 306);
			this.statusStripProcesses.Name = "statusStripProcesses";
			this.statusStripProcesses.Size = new System.Drawing.Size(526, 22);
			this.statusStripProcesses.TabIndex = 3;
			this.statusStripProcesses.Text = "statusStrip1";
			// 
			// labelProcessAmount
			// 
			this.labelProcessAmount.Name = "labelProcessAmount";
			this.labelProcessAmount.Size = new System.Drawing.Size(118, 17);
			this.labelProcessAmount.Text = "toolStripStatusLabel1";
			// 
			// toolStripRefresh
			// 
			this.toolStripRefresh.Name = "toolStripRefresh";
			this.toolStripRefresh.Size = new System.Drawing.Size(118, 17);
			this.toolStripRefresh.Text = "toolStripStatusLabel1";
			// 
			// lvProcesses
			// 
			this.lvProcesses.AllowColumnReorder = true;
			this.lvProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProcessName,
            this.colPID,
            this.colStatus,
            this.colOwner,
            this.colCPU,
            this.colMemory,
            this.colPath});
			this.lvProcesses.ContextMenuStrip = this.contextMenuProcessList;
			this.lvProcesses.FullRowSelect = true;
			this.lvProcesses.HeaderContextMenu = this.contextMenuColumns;
			this.lvProcesses.HideSelection = false;
			this.lvProcesses.Location = new System.Drawing.Point(0, 0);
			this.lvProcesses.MultiSelect = false;
			this.lvProcesses.Name = "lvProcesses";
			this.lvProcesses.Size = new System.Drawing.Size(532, 268);
			this.lvProcesses.TabIndex = 2;
			this.lvProcesses.UseCompatibleStateImageBehavior = false;
			this.lvProcesses.View = System.Windows.Forms.View.Details;
			this.lvProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lwProcesses_ColumnClick);
			this.lvProcesses.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvProcesses_ColumnWidthChanging);
			// 
			// colProcessName
			// 
			this.colProcessName.Text = "Process Name";
			this.colProcessName.Width = 110;
			// 
			// colPID
			// 
			this.colPID.Text = "PID";
			this.colPID.Width = 50;
			// 
			// colStatus
			// 
			this.colStatus.Text = "Status";
			this.colStatus.Width = 100;
			// 
			// colOwner
			// 
			this.colOwner.Text = "Owner";
			// 
			// colCPU
			// 
			this.colCPU.Text = "CPU";
			// 
			// colMemory
			// 
			this.colMemory.Text = "Memory";
			this.colMemory.Width = 88;
			// 
			// colPath
			// 
			this.colPath.Text = "Path";
			// 
			// contextMenuProcessList
			// 
			this.contextMenuProcessList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileLocationToolStripMenuItem,
            this.endTaskToolStripMenuItem});
			this.contextMenuProcessList.Name = "contextMenuProcessList";
			this.contextMenuProcessList.Size = new System.Drawing.Size(181, 70);
			// 
			// openFileLocationToolStripMenuItem
			// 
			this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
			this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openFileLocationToolStripMenuItem.Text = "Open file location";
			this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
			// 
			// endTaskToolStripMenuItem
			// 
			this.endTaskToolStripMenuItem.Name = "endTaskToolStripMenuItem";
			this.endTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.endTaskToolStripMenuItem.Text = "End task";
			this.endTaskToolStripMenuItem.Click += new System.EventHandler(this.KillTasks);
			// 
			// contextMenuColumns
			// 
			this.contextMenuColumns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIDToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.userToolStripMenuItem,
            this.cpuToolStripMenuItem,
            this.memoryToolStripMenuItem,
            this.pathToolStripMenuItem});
			this.contextMenuColumns.Name = "contextMenuColumns";
			this.contextMenuColumns.Size = new System.Drawing.Size(120, 136);
			// 
			// pIDToolStripMenuItem
			// 
			this.pIDToolStripMenuItem.Checked = true;
			this.pIDToolStripMenuItem.CheckOnClick = true;
			this.pIDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.pIDToolStripMenuItem.Name = "pIDToolStripMenuItem";
			this.pIDToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.pIDToolStripMenuItem.Tag = "1";
			this.pIDToolStripMenuItem.Text = "PID";
			this.pIDToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuColumnsItemClick);
			// 
			// statusToolStripMenuItem
			// 
			this.statusToolStripMenuItem.Checked = true;
			this.statusToolStripMenuItem.CheckOnClick = true;
			this.statusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
			this.statusToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.statusToolStripMenuItem.Tag = "2";
			this.statusToolStripMenuItem.Text = "Status";
			this.statusToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuColumnsItemClick);
			// 
			// userToolStripMenuItem
			// 
			this.userToolStripMenuItem.Checked = true;
			this.userToolStripMenuItem.CheckOnClick = true;
			this.userToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.userToolStripMenuItem.Name = "userToolStripMenuItem";
			this.userToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.userToolStripMenuItem.Tag = "3";
			this.userToolStripMenuItem.Text = "Owner";
			this.userToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuColumnsItemClick);
			// 
			// cpuToolStripMenuItem
			// 
			this.cpuToolStripMenuItem.Checked = true;
			this.cpuToolStripMenuItem.CheckOnClick = true;
			this.cpuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cpuToolStripMenuItem.Name = "cpuToolStripMenuItem";
			this.cpuToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.cpuToolStripMenuItem.Tag = "4";
			this.cpuToolStripMenuItem.Text = "CPU";
			this.cpuToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuColumnsItemClick);
			// 
			// memoryToolStripMenuItem
			// 
			this.memoryToolStripMenuItem.Checked = true;
			this.memoryToolStripMenuItem.CheckOnClick = true;
			this.memoryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.memoryToolStripMenuItem.Name = "memoryToolStripMenuItem";
			this.memoryToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.memoryToolStripMenuItem.Tag = "5";
			this.memoryToolStripMenuItem.Text = "Memory";
			this.memoryToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuColumnsItemClick);
			// 
			// pathToolStripMenuItem
			// 
			this.pathToolStripMenuItem.Checked = true;
			this.pathToolStripMenuItem.CheckOnClick = true;
			this.pathToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
			this.pathToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.pathToolStripMenuItem.Tag = "6";
			this.pathToolStripMenuItem.Text = "Path";
			this.pathToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuColumnsItemClick);
			// 
			// btnEndTask
			// 
			this.btnEndTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEndTask.Location = new System.Drawing.Point(441, 274);
			this.btnEndTask.Name = "btnEndTask";
			this.btnEndTask.Size = new System.Drawing.Size(83, 23);
			this.btnEndTask.TabIndex = 1;
			this.btnEndTask.Text = "End Task";
			this.btnEndTask.UseVisualStyleBackColor = true;
			this.btnEndTask.Click += new System.EventHandler(this.KillTasks);
			// 
			// tabPagePerformance
			// 
			this.tabPagePerformance.Location = new System.Drawing.Point(4, 22);
			this.tabPagePerformance.Name = "tabPagePerformance";
			this.tabPagePerformance.Size = new System.Drawing.Size(532, 331);
			this.tabPagePerformance.TabIndex = 1;
			this.tabPagePerformance.Text = "Performance";
			this.tabPagePerformance.UseVisualStyleBackColor = true;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(540, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewProcessToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// startNewProcessToolStripMenuItem
			// 
			this.startNewProcessToolStripMenuItem.Name = "startNewProcessToolStripMenuItem";
			this.startNewProcessToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.startNewProcessToolStripMenuItem.Text = "Start new process";
			this.startNewProcessToolStripMenuItem.Click += new System.EventHandler(this.startNewProcessToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topmostToolStripMenuItem,
            this.hideWhenMinimizedToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// topmostToolStripMenuItem
			// 
			this.topmostToolStripMenuItem.CheckOnClick = true;
			this.topmostToolStripMenuItem.Name = "topmostToolStripMenuItem";
			this.topmostToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.topmostToolStripMenuItem.Text = "Always on top";
			this.topmostToolStripMenuItem.Click += new System.EventHandler(this.topmostToolStripMenuItem_Click);
			// 
			// hideWhenMinimizedToolStripMenuItem
			// 
			this.hideWhenMinimizedToolStripMenuItem.CheckOnClick = true;
			this.hideWhenMinimizedToolStripMenuItem.Name = "hideWhenMinimizedToolStripMenuItem";
			this.hideWhenMinimizedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.hideWhenMinimizedToolStripMenuItem.Text = "Hide when minimized";
			this.hideWhenMinimizedToolStripMenuItem.Click += new System.EventHandler(this.hideWhenMinimizedToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateNowToolStripMenuItem,
            this.refreshRateToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// updateNowToolStripMenuItem
			// 
			this.updateNowToolStripMenuItem.Name = "updateNowToolStripMenuItem";
			this.updateNowToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.updateNowToolStripMenuItem.Text = "Update now";
			this.updateNowToolStripMenuItem.Click += new System.EventHandler(this.updateNowToolStripMenuItem_Click);
			// 
			// refreshRateToolStripMenuItem
			// 
			this.refreshRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.slowToolStripMenuItem,
            this.pausedToolStripMenuItem});
			this.refreshRateToolStripMenuItem.Name = "refreshRateToolStripMenuItem";
			this.refreshRateToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.refreshRateToolStripMenuItem.Text = "Refresh rate...";
			// 
			// fastToolStripMenuItem
			// 
			this.fastToolStripMenuItem.CheckOnClick = true;
			this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
			this.fastToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.fastToolStripMenuItem.Text = "Fast";
			this.fastToolStripMenuItem.Click += new System.EventHandler(this.refreshRatesToolStripMenuItem_Click);
			// 
			// normalToolStripMenuItem
			// 
			this.normalToolStripMenuItem.Checked = true;
			this.normalToolStripMenuItem.CheckOnClick = true;
			this.normalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
			this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.normalToolStripMenuItem.Text = "Normal";
			this.normalToolStripMenuItem.Click += new System.EventHandler(this.refreshRatesToolStripMenuItem_Click);
			// 
			// slowToolStripMenuItem
			// 
			this.slowToolStripMenuItem.CheckOnClick = true;
			this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
			this.slowToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.slowToolStripMenuItem.Text = "Slow";
			this.slowToolStripMenuItem.Click += new System.EventHandler(this.refreshRatesToolStripMenuItem_Click);
			// 
			// pausedToolStripMenuItem
			// 
			this.pausedToolStripMenuItem.CheckOnClick = true;
			this.pausedToolStripMenuItem.Name = "pausedToolStripMenuItem";
			this.pausedToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.pausedToolStripMenuItem.Text = "Paused";
			this.pausedToolStripMenuItem.Click += new System.EventHandler(this.refreshRatesToolStripMenuItem_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Text = "Task Manager";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// timerUpdate
			// 
			this.timerUpdate.Enabled = true;
			this.timerUpdate.Interval = 1000;
			this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 381);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(556, 420);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Task Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.tabControl.ResumeLayout(false);
			this.tabPageProcesses.ResumeLayout(false);
			this.tabPageProcesses.PerformLayout();
			this.statusStripProcesses.ResumeLayout(false);
			this.statusStripProcesses.PerformLayout();
			this.contextMenuProcessList.ResumeLayout(false);
			this.contextMenuColumns.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageProcesses;
		private System.Windows.Forms.Button btnEndTask;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startNewProcessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateNowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideWhenMinimizedToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		//private System.Windows.Forms.ListView lvProcesses;
		private TaskManager.ListViewEx lvProcesses;
		private System.Windows.Forms.ColumnHeader colProcessName;
		private System.Windows.Forms.ColumnHeader colPID;
		private System.Windows.Forms.ColumnHeader colStatus;
		private System.Windows.Forms.StatusStrip statusStripProcesses;
		private System.Windows.Forms.ToolStripStatusLabel labelProcessAmount;
		private System.Windows.Forms.TabPage tabPagePerformance;
		private System.Windows.Forms.Timer timerUpdate;
		private System.Windows.Forms.ToolStripMenuItem refreshRateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pausedToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripRefresh;
		private System.Windows.Forms.ContextMenuStrip contextMenuProcessList;
		private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem endTaskToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuColumns;
		private System.Windows.Forms.ToolStripMenuItem pIDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader colOwner;
		private System.Windows.Forms.ColumnHeader colPath;
		private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cpuToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader colCPU;
		private System.Windows.Forms.ColumnHeader colMemory;
		private System.Windows.Forms.ToolStripMenuItem memoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
	}
}

