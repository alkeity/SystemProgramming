namespace Processes
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
			this.btnStart = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.process = new System.Diagnostics.Process();
			this.comboProgram = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(294, 44);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(375, 44);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// process
			// 
			this.process.StartInfo.Domain = "";
			this.process.StartInfo.LoadUserProfile = false;
			this.process.StartInfo.Password = null;
			this.process.StartInfo.StandardErrorEncoding = null;
			this.process.StartInfo.StandardOutputEncoding = null;
			this.process.StartInfo.UserName = "";
			this.process.SynchronizingObject = this;
			// 
			// comboProgram
			// 
			this.comboProgram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboProgram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.comboProgram.FormattingEnabled = true;
			this.comboProgram.Location = new System.Drawing.Point(13, 12);
			this.comboProgram.Name = "comboProgram";
			this.comboProgram.Size = new System.Drawing.Size(437, 21);
			this.comboProgram.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(462, 78);
			this.Controls.Add(this.comboProgram);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnStart);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Processes";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnCancel;
		private System.Diagnostics.Process process;
		private System.Windows.Forms.ComboBox comboProgram;
	}
}

