﻿namespace OverlayImpact
{
	partial class StartUp
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
			this.chkOverlay = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// chkOverlay
			// 
			this.chkOverlay.AutoSize = true;
			this.chkOverlay.Location = new System.Drawing.Point(26, 25);
			this.chkOverlay.Name = "chkOverlay";
			this.chkOverlay.Size = new System.Drawing.Size(84, 17);
			this.chkOverlay.TabIndex = 0;
			this.chkOverlay.Text = "StartOverlay";
			this.chkOverlay.UseVisualStyleBackColor = true;
			this.chkOverlay.CheckedChanged += new System.EventHandler(this.chkOverlay_CheckedChanged);
			// 
			// StartUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(180, 73);
			this.Controls.Add(this.chkOverlay);
			this.Name = "StartUp";
			this.Text = "StartUp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkOverlay;
	}
}

