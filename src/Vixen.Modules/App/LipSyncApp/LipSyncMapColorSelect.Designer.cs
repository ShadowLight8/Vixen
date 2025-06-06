﻿namespace VixenModules.App.LipSyncApp
{
    partial class LipSyncMapColorSelect
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LipSyncMapColorSelect));
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.lipSyncMapColorCtrl1 = new VixenModules.App.LipSyncApp.LipSyncMapColorCtrl();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(48, 82);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(129, 82);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// lipSyncMapColorCtrl1
			// 
			this.lipSyncMapColorCtrl1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lipSyncMapColorCtrl1.HSVColor = ((Common.Controls.ColorManagement.ColorModels.HSV)(resources.GetObject("lipSyncMapColorCtrl1.HSVColor")));
			this.lipSyncMapColorCtrl1.Intensity = 0D;
			this.lipSyncMapColorCtrl1.Location = new System.Drawing.Point(8, 3);
			this.lipSyncMapColorCtrl1.Name = "lipSyncMapColorCtrl1";
			this.lipSyncMapColorCtrl1.Size = new System.Drawing.Size(196, 73);
			this.lipSyncMapColorCtrl1.TabIndex = 4;
			// 
			// LipSyncMapColorSelect
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(216, 114);
			this.Controls.Add(this.lipSyncMapColorCtrl1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.MaximumSize = new System.Drawing.Size(232, 153);
			this.MinimumSize = new System.Drawing.Size(232, 153);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LipSyncMapColorSelect";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "LipSyncMapColorSelect";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private LipSyncMapColorCtrl lipSyncMapColorCtrl1;
    }
}