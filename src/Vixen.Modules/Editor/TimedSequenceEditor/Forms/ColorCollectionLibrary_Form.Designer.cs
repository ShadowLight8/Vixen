﻿namespace VixenModules.Editor.TimedSequenceEditor
{
	partial class ColorCollectionLibrary_Form
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
			this.listViewColors = new System.Windows.Forms.ListView();
			this.lblLibraryName = new System.Windows.Forms.Label();
			this.comboBoxCollections = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.buttonNewCollection = new System.Windows.Forms.Button();
			this.buttonDeleteCollection = new System.Windows.Forms.Button();
			this.buttonAddColor = new System.Windows.Forms.Button();
			this.buttonImportCollection = new System.Windows.Forms.Button();
			this.buttonExportCollection = new System.Windows.Forms.Button();
			this.buttonRemoveColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listViewColors
			// 
			this.listViewColors.AllowDrop = true;
			this.listViewColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewColors.Location = new System.Drawing.Point(12, 42);
			this.listViewColors.Name = "listViewColors";
			this.listViewColors.ShowItemToolTips = true;
			this.listViewColors.Size = new System.Drawing.Size(651, 353);
			this.listViewColors.TabIndex = 0;
			this.listViewColors.UseCompatibleStateImageBehavior = false;
			this.listViewColors.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewColors_ItemDrag);
			this.listViewColors.SelectedIndexChanged += new System.EventHandler(this.listViewColors_SelectedIndexChanged);
			this.listViewColors.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewColors_DragDrop);
			this.listViewColors.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewColors_DragEnter);
			// 
			// lblLibraryName
			// 
			this.lblLibraryName.AutoSize = true;
			this.lblLibraryName.Location = new System.Drawing.Point(13, 15);
			this.lblLibraryName.Name = "lblLibraryName";
			this.lblLibraryName.Size = new System.Drawing.Size(80, 13);
			this.lblLibraryName.TabIndex = 1;
			this.lblLibraryName.Text = "Color Collection";
			// 
			// comboBoxCollections
			// 
			this.comboBoxCollections.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBoxCollections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCollections.FormattingEnabled = true;
			this.comboBoxCollections.Location = new System.Drawing.Point(99, 12);
			this.comboBoxCollections.Margin = new System.Windows.Forms.Padding(1);
			this.comboBoxCollections.Name = "comboBoxCollections";
			this.comboBoxCollections.Size = new System.Drawing.Size(207, 21);
			this.comboBoxCollections.TabIndex = 2;
			this.comboBoxCollections.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
			this.comboBoxCollections.SelectedIndexChanged += new System.EventHandler(this.comboBoxCollections_SelectedIndexChanged);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(452, 412);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(103, 23);
			this.btnOK.TabIndex = 8;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(560, 412);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(103, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(394, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Description";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDescription.Enabled = false;
			this.textBoxDescription.Location = new System.Drawing.Point(460, 12);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(203, 20);
			this.textBoxDescription.TabIndex = 12;
			this.textBoxDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDescription_KeyUp);
			// 
			// buttonNewCollection
			// 
			this.buttonNewCollection.Location = new System.Drawing.Point(317, 11);
			this.buttonNewCollection.Name = "buttonNewCollection";
			this.buttonNewCollection.Size = new System.Drawing.Size(25, 25);
			this.buttonNewCollection.TabIndex = 14;
			this.buttonNewCollection.UseVisualStyleBackColor = true;
			this.buttonNewCollection.Click += new System.EventHandler(this.buttonNewCollection_Click);
			// 
			// buttonDeleteCollection
			// 
			this.buttonDeleteCollection.Location = new System.Drawing.Point(352, 11);
			this.buttonDeleteCollection.Name = "buttonDeleteCollection";
			this.buttonDeleteCollection.Size = new System.Drawing.Size(25, 25);
			this.buttonDeleteCollection.TabIndex = 15;
			this.buttonDeleteCollection.UseVisualStyleBackColor = true;
			this.buttonDeleteCollection.Click += new System.EventHandler(this.buttonDeleteCollection_Click);
			// 
			// buttonAddColor
			// 
			this.buttonAddColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAddColor.Location = new System.Drawing.Point(231, 412);
			this.buttonAddColor.Name = "buttonAddColor";
			this.buttonAddColor.Size = new System.Drawing.Size(103, 23);
			this.buttonAddColor.TabIndex = 16;
			this.buttonAddColor.Text = "Add Color";
			this.buttonAddColor.UseVisualStyleBackColor = false;
			this.buttonAddColor.EnabledChanged += new System.EventHandler(this.buttonTextColorChange);
			this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
			// 
			// buttonImportCollection
			// 
			this.buttonImportCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonImportCollection.Location = new System.Drawing.Point(13, 412);
			this.buttonImportCollection.Name = "buttonImportCollection";
			this.buttonImportCollection.Size = new System.Drawing.Size(103, 23);
			this.buttonImportCollection.TabIndex = 17;
			this.buttonImportCollection.Text = "Import Collection";
			this.buttonImportCollection.UseVisualStyleBackColor = false;
			this.buttonImportCollection.Click += new System.EventHandler(this.buttonImportCollection_Click);
			// 
			// buttonExportCollection
			// 
			this.buttonExportCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonExportCollection.Location = new System.Drawing.Point(122, 412);
			this.buttonExportCollection.Name = "buttonExportCollection";
			this.buttonExportCollection.Size = new System.Drawing.Size(103, 23);
			this.buttonExportCollection.TabIndex = 18;
			this.buttonExportCollection.Text = "Export Collection";
			this.buttonExportCollection.UseVisualStyleBackColor = false;
			this.buttonExportCollection.Click += new System.EventHandler(this.buttonExportCollection_Click);
			// 
			// buttonRemoveColor
			// 
			this.buttonRemoveColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRemoveColor.Location = new System.Drawing.Point(340, 412);
			this.buttonRemoveColor.Name = "buttonRemoveColor";
			this.buttonRemoveColor.Size = new System.Drawing.Size(103, 23);
			this.buttonRemoveColor.TabIndex = 19;
			this.buttonRemoveColor.Text = "Remove Color";
			this.buttonRemoveColor.UseVisualStyleBackColor = false;
			this.buttonRemoveColor.EnabledChanged += new System.EventHandler(this.buttonTextColorChange);
			this.buttonRemoveColor.Click += new System.EventHandler(this.buttonRemoveColor_Click);
			// 
			// ColorCollectionLibrary_Form
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(675, 447);
			this.Controls.Add(this.buttonRemoveColor);
			this.Controls.Add(this.buttonExportCollection);
			this.Controls.Add(this.buttonImportCollection);
			this.Controls.Add(this.buttonAddColor);
			this.Controls.Add(this.buttonNewCollection);
			this.Controls.Add(this.buttonDeleteCollection);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.comboBoxCollections);
			this.Controls.Add(this.lblLibraryName);
			this.Controls.Add(this.listViewColors);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(691, 486);
			this.Name = "ColorCollectionLibrary_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Color Collection Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandomColorLibrary_Form_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewColors;
		private System.Windows.Forms.Label lblLibraryName;
		private System.Windows.Forms.ComboBox comboBoxCollections;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Button buttonNewCollection;
		private System.Windows.Forms.Button buttonDeleteCollection;
		private System.Windows.Forms.Button buttonAddColor;
		private System.Windows.Forms.Button buttonImportCollection;
		private System.Windows.Forms.Button buttonExportCollection;
		private System.Windows.Forms.Button buttonRemoveColor;
	}
}