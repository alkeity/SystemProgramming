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
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startNewProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideWhenMinimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.refreshNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.selectColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripProcessAmount = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripRefreshRate = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageProcesses = new System.Windows.Forms.TabPage();
			this.listViewProcesses = new System.Windows.Forms.ListView();
			this.columnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuProcList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.endTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPagePerformance = new System.Windows.Forms.TabPage();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.mainMenuStrip.SuspendLayout();
			this.statusStripMain.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageProcesses.SuspendLayout();
			this.contextMenuProcList.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(437, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewProcessToolStripMenuItem,
            this.toolStripSeparator1,
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.hideWhenMinimizedToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshNowToolStripMenuItem,
            this.refreshRateToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectColumnsToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
			// 
			// hideWhenMinimizedToolStripMenuItem
			// 
			this.hideWhenMinimizedToolStripMenuItem.CheckOnClick = true;
			this.hideWhenMinimizedToolStripMenuItem.Name = "hideWhenMinimizedToolStripMenuItem";
			this.hideWhenMinimizedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.hideWhenMinimizedToolStripMenuItem.Text = "Hide when minimized";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
			// 
			// refreshNowToolStripMenuItem
			// 
			this.refreshNowToolStripMenuItem.Name = "refreshNowToolStripMenuItem";
			this.refreshNowToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.refreshNowToolStripMenuItem.Text = "Refresh now";
			// 
			// refreshRateToolStripMenuItem
			// 
			this.refreshRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.lowToolStripMenuItem});
			this.refreshRateToolStripMenuItem.Name = "refreshRateToolStripMenuItem";
			this.refreshRateToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.refreshRateToolStripMenuItem.Text = "Refresh rate...";
			// 
			// highToolStripMenuItem
			// 
			this.highToolStripMenuItem.Name = "highToolStripMenuItem";
			this.highToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.highToolStripMenuItem.Text = "High";
			// 
			// normalToolStripMenuItem
			// 
			this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
			this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.normalToolStripMenuItem.Text = "Normal";
			// 
			// lowToolStripMenuItem
			// 
			this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
			this.lowToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.lowToolStripMenuItem.Text = "Low";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
			// 
			// selectColumnsToolStripMenuItem
			// 
			this.selectColumnsToolStripMenuItem.Name = "selectColumnsToolStripMenuItem";
			this.selectColumnsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.selectColumnsToolStripMenuItem.Text = "Select columns";
			// 
			// statusStripMain
			// 
			this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProcessAmount,
            this.toolStripRefreshRate});
			this.statusStripMain.Location = new System.Drawing.Point(0, 314);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(437, 22);
			this.statusStripMain.TabIndex = 1;
			this.statusStripMain.Text = "statusStrip1";
			// 
			// toolStripProcessAmount
			// 
			this.toolStripProcessAmount.Name = "toolStripProcessAmount";
			this.toolStripProcessAmount.Size = new System.Drawing.Size(118, 17);
			this.toolStripProcessAmount.Text = "toolStripStatusLabel1";
			// 
			// toolStripRefreshRate
			// 
			this.toolStripRefreshRate.Name = "toolStripRefreshRate";
			this.toolStripRefreshRate.Size = new System.Drawing.Size(118, 17);
			this.toolStripRefreshRate.Text = "toolStripStatusLabel1";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageProcesses);
			this.tabControl.Controls.Add(this.tabPagePerformance);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(437, 290);
			this.tabControl.TabIndex = 2;
			// 
			// tabPageProcesses
			// 
			this.tabPageProcesses.Controls.Add(this.listViewProcesses);
			this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
			this.tabPageProcesses.Name = "tabPageProcesses";
			this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProcesses.Size = new System.Drawing.Size(429, 264);
			this.tabPageProcesses.TabIndex = 0;
			this.tabPageProcesses.Text = "Processes";
			this.tabPageProcesses.UseVisualStyleBackColor = true;
			// 
			// listViewProcesses
			// 
			this.listViewProcesses.AllowColumnReorder = true;
			this.listViewProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProcessName,
            this.columnPID});
			this.listViewProcesses.ContextMenuStrip = this.contextMenuProcList;
			this.listViewProcesses.FullRowSelect = true;
			this.listViewProcesses.HideSelection = false;
			this.listViewProcesses.Location = new System.Drawing.Point(1, 1);
			this.listViewProcesses.MultiSelect = false;
			this.listViewProcesses.Name = "listViewProcesses";
			this.listViewProcesses.Size = new System.Drawing.Size(428, 230);
			this.listViewProcesses.TabIndex = 0;
			this.listViewProcesses.UseCompatibleStateImageBehavior = false;
			this.listViewProcesses.View = System.Windows.Forms.View.Details;
			// 
			// columnPID
			// 
			this.columnPID.Text = "PID";
			// 
			// columnProcessName
			// 
			this.columnProcessName.Text = "Process name";
			this.columnProcessName.Width = 120;
			// 
			// contextMenuProcList
			// 
			this.contextMenuProcList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSourceToolStripMenuItem,
            this.endTaskToolStripMenuItem});
			this.contextMenuProcList.Name = "contextMenuProcList";
			this.contextMenuProcList.Size = new System.Drawing.Size(142, 48);
			this.contextMenuProcList.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuProcList_Opening);
			// 
			// openSourceToolStripMenuItem
			// 
			this.openSourceToolStripMenuItem.Name = "openSourceToolStripMenuItem";
			this.openSourceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.openSourceToolStripMenuItem.Text = "Open source";
			this.openSourceToolStripMenuItem.Click += new System.EventHandler(this.openSourceToolStripMenuItem_Click);
			// 
			// endTaskToolStripMenuItem
			// 
			this.endTaskToolStripMenuItem.Name = "endTaskToolStripMenuItem";
			this.endTaskToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.endTaskToolStripMenuItem.Text = "End task";
			this.endTaskToolStripMenuItem.Click += new System.EventHandler(this.endTaskToolStripMenuItem_Click);
			// 
			// tabPagePerformance
			// 
			this.tabPagePerformance.Location = new System.Drawing.Point(4, 22);
			this.tabPagePerformance.Name = "tabPagePerformance";
			this.tabPagePerformance.Size = new System.Drawing.Size(429, 264);
			this.tabPagePerformance.TabIndex = 1;
			this.tabPagePerformance.Text = "Performance";
			this.tabPagePerformance.UseVisualStyleBackColor = true;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 336);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Task Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.statusStripMain.ResumeLayout(false);
			this.statusStripMain.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageProcesses.ResumeLayout(false);
			this.contextMenuProcList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startNewProcessToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideWhenMinimizedToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem refreshNowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshRateToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem selectColumnsToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageProcesses;
		private System.Windows.Forms.TabPage tabPagePerformance;
		private System.Windows.Forms.ListView listViewProcesses;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ColumnHeader columnProcessName;
		private System.Windows.Forms.ColumnHeader columnPID;
		private System.Windows.Forms.ToolStripStatusLabel toolStripProcessAmount;
		private System.Windows.Forms.ToolStripStatusLabel toolStripRefreshRate;
		private System.Windows.Forms.ContextMenuStrip contextMenuProcList;
		private System.Windows.Forms.ToolStripMenuItem openSourceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem endTaskToolStripMenuItem;
	}
}

