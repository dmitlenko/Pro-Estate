using Pro_Estate.Core.Database.Base;

namespace Pro_Estate.Forms.DataEntry
{
	partial class DataEntryForm<T>
		where T : class, IIdentifable
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
			this.fieldsForm = new System.Windows.Forms.Panel();
			this.cancelButton = new ReaLTaiizor.Controls.CrownButton();
			this.actionButton = new ReaLTaiizor.Controls.CrownButton();
			this.SuspendLayout();
			// 
			// fieldsForm
			// 
			this.fieldsForm.Location = new System.Drawing.Point(8, 8);
			this.fieldsForm.Name = "fieldsForm";
			this.fieldsForm.Size = new System.Drawing.Size(296, 264);
			this.fieldsForm.TabIndex = 0;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cancelButton.Location = new System.Drawing.Point(8, 280);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Padding = new System.Windows.Forms.Padding(5);
			this.cancelButton.Size = new System.Drawing.Size(144, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Скасувати";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// actionButton
			// 
			this.actionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.actionButton.Location = new System.Drawing.Point(160, 280);
			this.actionButton.Name = "actionButton";
			this.actionButton.Padding = new System.Windows.Forms.Padding(5);
			this.actionButton.Size = new System.Drawing.Size(144, 23);
			this.actionButton.TabIndex = 2;
			this.actionButton.Text = "action";
			this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
			// 
			// DataEntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 312);
			this.Controls.Add(this.actionButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.fieldsForm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataEntryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DataEntryForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataEntryForm_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel fieldsForm;
		private ReaLTaiizor.Controls.CrownButton cancelButton;
		private ReaLTaiizor.Controls.CrownButton actionButton;
	}
}