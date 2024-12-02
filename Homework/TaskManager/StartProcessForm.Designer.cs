namespace TaskManager
{
	partial class StartProcessForm
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
			this.comboProcess = new System.Windows.Forms.ComboBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboProcess
			// 
			this.comboProcess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboProcess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.comboProcess.FormattingEnabled = true;
			this.comboProcess.Location = new System.Drawing.Point(12, 12);
			this.comboProcess.Name = "comboProcess";
			this.comboProcess.Size = new System.Drawing.Size(395, 21);
			this.comboProcess.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(332, 42);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(251, 42);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			// 
			// StartProcessForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 77);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.comboProcess);
			this.Name = "StartProcessForm";
			this.Text = "Start new process";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboProcess;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnStart;
	}
}