namespace AlbumRegistry
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateNewAlbum = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.lblMessages = new System.Windows.Forms.Label();
            this.groupBoxAddEditDeleteAlbums = new System.Windows.Forms.GroupBox();
            this.btnDeleteAlbum = new System.Windows.Forms.Button();
            this.btnUpdateAlbum = new System.Windows.Forms.Button();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.txtYearProduced = new System.Windows.Forms.TextBox();
            this.lblYearProduced = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBandOrArtist = new System.Windows.Forms.TextBox();
            this.lblBandOrArtist = new System.Windows.Forms.Label();
            this.txtAlbumId = new System.Windows.Forms.TextBox();
            this.lblAlbumId = new System.Windows.Forms.Label();
            this.groupBoxAddEditDeleteAlbums.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateNewAlbum
            // 
            this.btnCreateNewAlbum.Location = new System.Drawing.Point(16, 16);
            this.btnCreateNewAlbum.Name = "btnCreateNewAlbum";
            this.btnCreateNewAlbum.Size = new System.Drawing.Size(124, 23);
            this.btnCreateNewAlbum.TabIndex = 0;
            this.btnCreateNewAlbum.Text = "Create new album";
            this.btnCreateNewAlbum.UseVisualStyleBackColor = true;
            this.btnCreateNewAlbum.Click += new System.EventHandler(this.btnCreateNewAlbum_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 15;
            this.listBoxAlbums.Location = new System.Drawing.Point(18, 59);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(144, 229);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(18, 308);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(184, 15);
            this.lblMessages.TabIndex = 2;
            this.lblMessages.Text = "Placeholder for err/info messages";
            // 
            // groupBoxAddEditDeleteAlbums
            // 
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.btnDeleteAlbum);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.btnUpdateAlbum);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.btnSaveAlbum);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.txtYearProduced);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.lblYearProduced);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.txtTitle);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.lblTitle);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.txtBandOrArtist);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.lblBandOrArtist);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.txtAlbumId);
            this.groupBoxAddEditDeleteAlbums.Controls.Add(this.lblAlbumId);
            this.groupBoxAddEditDeleteAlbums.Location = new System.Drawing.Point(200, 21);
            this.groupBoxAddEditDeleteAlbums.Name = "groupBoxAddEditDeleteAlbums";
            this.groupBoxAddEditDeleteAlbums.Size = new System.Drawing.Size(444, 264);
            this.groupBoxAddEditDeleteAlbums.TabIndex = 3;
            this.groupBoxAddEditDeleteAlbums.TabStop = false;
            this.groupBoxAddEditDeleteAlbums.Text = "Add/Edit/Delete albums:";
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.Location = new System.Drawing.Point(275, 209);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteAlbum.TabIndex = 10;
            this.btnDeleteAlbum.Text = "Delete album";
            this.btnDeleteAlbum.UseVisualStyleBackColor = true;
            this.btnDeleteAlbum.Click += new System.EventHandler(this.btnDeleteAlbum_Click);
            // 
            // btnUpdateAlbum
            // 
            this.btnUpdateAlbum.Location = new System.Drawing.Point(143, 209);
            this.btnUpdateAlbum.Name = "btnUpdateAlbum";
            this.btnUpdateAlbum.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateAlbum.TabIndex = 9;
            this.btnUpdateAlbum.Text = "Update album";
            this.btnUpdateAlbum.UseVisualStyleBackColor = true;
            this.btnUpdateAlbum.Click += new System.EventHandler(this.btnUpdateAlbum_Click);
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Location = new System.Drawing.Point(26, 209);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(100, 23);
            this.btnSaveAlbum.TabIndex = 8;
            this.btnSaveAlbum.Text = "Save album";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // txtYearProduced
            // 
            this.txtYearProduced.Location = new System.Drawing.Point(118, 154);
            this.txtYearProduced.Name = "txtYearProduced";
            this.txtYearProduced.Size = new System.Drawing.Size(100, 23);
            this.txtYearProduced.TabIndex = 7;
            // 
            // lblYearProduced
            // 
            this.lblYearProduced.AutoSize = true;
            this.lblYearProduced.Location = new System.Drawing.Point(26, 157);
            this.lblYearProduced.Name = "lblYearProduced";
            this.lblYearProduced.Size = new System.Drawing.Size(86, 15);
            this.lblYearProduced.TabIndex = 6;
            this.lblYearProduced.Text = "Year produced:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(118, 111);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 23);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 111);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 15);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // txtBandOrArtist
            // 
            this.txtBandOrArtist.Location = new System.Drawing.Point(118, 71);
            this.txtBandOrArtist.Name = "txtBandOrArtist";
            this.txtBandOrArtist.Size = new System.Drawing.Size(100, 23);
            this.txtBandOrArtist.TabIndex = 3;
            // 
            // lblBandOrArtist
            // 
            this.lblBandOrArtist.AutoSize = true;
            this.lblBandOrArtist.Location = new System.Drawing.Point(26, 73);
            this.lblBandOrArtist.Name = "lblBandOrArtist";
            this.lblBandOrArtist.Size = new System.Drawing.Size(70, 15);
            this.lblBandOrArtist.TabIndex = 2;
            this.lblBandOrArtist.Text = "Band/Artist:";
            // 
            // txtAlbumId
            // 
            this.txtAlbumId.Enabled = false;
            this.txtAlbumId.Location = new System.Drawing.Point(118, 26);
            this.txtAlbumId.Name = "txtAlbumId";
            this.txtAlbumId.Size = new System.Drawing.Size(100, 23);
            this.txtAlbumId.TabIndex = 1;
            // 
            // lblAlbumId
            // 
            this.lblAlbumId.AutoSize = true;
            this.lblAlbumId.Location = new System.Drawing.Point(26, 34);
            this.lblAlbumId.Name = "lblAlbumId";
            this.lblAlbumId.Size = new System.Drawing.Size(60, 15);
            this.lblAlbumId.TabIndex = 0;
            this.lblAlbumId.Text = "Album ID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 358);
            this.Controls.Add(this.groupBoxAddEditDeleteAlbums);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.btnCreateNewAlbum);
            this.Name = "MainForm";
            this.Text = "Album Registry";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxAddEditDeleteAlbums.ResumeLayout(false);
            this.groupBoxAddEditDeleteAlbums.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreateNewAlbum;
        private ListBox listBoxAlbums;
        private Label lblMessages;
        private GroupBox groupBoxAddEditDeleteAlbums;
        private TextBox txtYearProduced;
        private Label lblYearProduced;
        private TextBox txtTitle;
        private Label lblTitle;
        private TextBox txtBandOrArtist;
        private Label lblBandOrArtist;
        private TextBox txtAlbumId;
        private Label lblAlbumId;
        private Button btnDeleteAlbum;
        private Button btnUpdateAlbum;
        private Button btnSaveAlbum;
    }
}