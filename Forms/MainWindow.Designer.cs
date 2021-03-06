﻿namespace Timotheus.Forms
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Calendar_View = new System.Windows.Forms.DataGridView();
            this.Calendar_StartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calendar_EndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calendar_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calendar_DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calendar_LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Calendar_Page = new System.Windows.Forms.TabPage();
            this.Calendar_MonthButton = new System.Windows.Forms.RadioButton();
            this.Calendar_HalfYearButton = new System.Windows.Forms.RadioButton();
            this.Calendar_YearButton = new System.Windows.Forms.RadioButton();
            this.Calendar_AllButton = new System.Windows.Forms.RadioButton();
            this.Calendar_SaveButton = new System.Windows.Forms.Button();
            this.Calendar_OpenButton = new System.Windows.Forms.Button();
            this.Calendar_SyncButton = new System.Windows.Forms.Button();
            this.Calendar_ExportButton = new System.Windows.Forms.Button();
            this.Calendar_RemoveButton = new System.Windows.Forms.Button();
            this.Calendar_AddButton = new System.Windows.Forms.Button();
            this.Calendar_PeriodBox = new System.Windows.Forms.TextBox();
            this.Calendar_AddYearButton = new System.Windows.Forms.Button();
            this.Calendar_SubtractYearButton = new System.Windows.Forms.Button();
            this.SFTP_Page = new System.Windows.Forms.TabPage();
            this.SFTP_SyncButton = new System.Windows.Forms.Button();
            this.SFTP_DownloadButton = new System.Windows.Forms.Button();
            this.SFTP_ShowDirectoryButton = new System.Windows.Forms.Button();
            this.SFTP_View = new System.Windows.Forms.DataGridView();
            this.SFTP_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SFTP_SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SFTP_BrowseButton = new System.Windows.Forms.Button();
            this.SFTP_RemoteDirectoryBox = new System.Windows.Forms.TextBox();
            this.SFTP_RemoteDirectoryLabel = new System.Windows.Forms.Label();
            this.SFTP_LocalDirectoryLabel = new System.Windows.Forms.Label();
            this.SFTP_LocalDirectoryBox = new System.Windows.Forms.TextBox();
            this.SFTP_PasswordLabel = new System.Windows.Forms.Label();
            this.SFTP_PasswordBox = new System.Windows.Forms.TextBox();
            this.SFTP_UsernameLabel = new System.Windows.Forms.Label();
            this.SFTP_UsernameBox = new System.Windows.Forms.TextBox();
            this.SFTP_HostLabel = new System.Windows.Forms.Label();
            this.SFTP_HostBox = new System.Windows.Forms.TextBox();
            this.ConsentForms_Page = new System.Windows.Forms.TabPage();
            this.ConsentForms_RemoveButton = new System.Windows.Forms.Button();
            this.ConsentForms_AddButton = new System.Windows.Forms.Button();
            this.ConsentForms_View = new System.Windows.Forms.DataGridView();
            this.ConsentForms_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsentForms_DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsentForms_VersionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsentForms_CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Settings_Page = new System.Windows.Forms.TabPage();
            this.Settings_InfoBox = new System.Windows.Forms.GroupBox();
            this.Settings_LogoBox = new System.Windows.Forms.TextBox();
            this.Settings_LogoLabel = new System.Windows.Forms.Label();
            this.Settings_BrowseButton = new System.Windows.Forms.Button();
            this.Settings_AddressLabel = new System.Windows.Forms.Label();
            this.Settings_AddressBox = new System.Windows.Forms.TextBox();
            this.Settings_NameLabel = new System.Windows.Forms.Label();
            this.Settings_NameBox = new System.Windows.Forms.TextBox();
            this.Settings_PictureBox = new System.Windows.Forms.PictureBox();
            this.Help_Page = new System.Windows.Forms.TabPage();
            this.Help_EmailLink = new System.Windows.Forms.LinkLabel();
            this.Help_EmailLabel = new System.Windows.Forms.Label();
            this.Help_AuthorLabel = new System.Windows.Forms.Label();
            this.Help_LicenseLabel = new System.Windows.Forms.Label();
            this.Help_SourceLink = new System.Windows.Forms.LinkLabel();
            this.Help_SourceLabel = new System.Windows.Forms.Label();
            this.Help_VersionLabel = new System.Windows.Forms.Label();
            this.Help_IconBox = new System.Windows.Forms.PictureBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar_View)).BeginInit();
            this.tabControl.SuspendLayout();
            this.Calendar_Page.SuspendLayout();
            this.SFTP_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SFTP_View)).BeginInit();
            this.ConsentForms_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsentForms_View)).BeginInit();
            this.Settings_Page.SuspendLayout();
            this.Settings_InfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_PictureBox)).BeginInit();
            this.Help_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help_IconBox)).BeginInit();
            this.TrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar_View
            // 
            this.Calendar_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Calendar_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Calendar_StartColumn,
            this.Calendar_EndColumn,
            this.Calendar_NameColumn,
            this.Calendar_DescriptionColumn,
            this.Calendar_LocationColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Calendar_View.DefaultCellStyle = dataGridViewCellStyle1;
            this.Calendar_View.Location = new System.Drawing.Point(10, 39);
            this.Calendar_View.Name = "Calendar_View";
            this.Calendar_View.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calendar_View.RowHeadersVisible = false;
            this.Calendar_View.RowHeadersWidth = 51;
            this.Calendar_View.RowTemplate.Height = 25;
            this.Calendar_View.Size = new System.Drawing.Size(774, 331);
            this.Calendar_View.TabIndex = 3;
            // 
            // Calendar_StartColumn
            // 
            this.Calendar_StartColumn.DataPropertyName = "StartTime";
            this.Calendar_StartColumn.FillWeight = 39.11343F;
            this.Calendar_StartColumn.HeaderText = "Start";
            this.Calendar_StartColumn.MinimumWidth = 6;
            this.Calendar_StartColumn.Name = "Calendar_StartColumn";
            this.Calendar_StartColumn.Width = 125;
            // 
            // Calendar_EndColumn
            // 
            this.Calendar_EndColumn.DataPropertyName = "EndTime";
            this.Calendar_EndColumn.FillWeight = 44.62484F;
            this.Calendar_EndColumn.HeaderText = "End";
            this.Calendar_EndColumn.MinimumWidth = 6;
            this.Calendar_EndColumn.Name = "Calendar_EndColumn";
            this.Calendar_EndColumn.Width = 125;
            // 
            // Calendar_NameColumn
            // 
            this.Calendar_NameColumn.DataPropertyName = "Name";
            this.Calendar_NameColumn.FillWeight = 132.2595F;
            this.Calendar_NameColumn.HeaderText = "Name";
            this.Calendar_NameColumn.MinimumWidth = 6;
            this.Calendar_NameColumn.Name = "Calendar_NameColumn";
            this.Calendar_NameColumn.Width = 253;
            // 
            // Calendar_DescriptionColumn
            // 
            this.Calendar_DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Calendar_DescriptionColumn.DataPropertyName = "Description";
            this.Calendar_DescriptionColumn.FillWeight = 184.0022F;
            this.Calendar_DescriptionColumn.HeaderText = "Description";
            this.Calendar_DescriptionColumn.MinimumWidth = 6;
            this.Calendar_DescriptionColumn.Name = "Calendar_DescriptionColumn";
            // 
            // Calendar_LocationColumn
            // 
            this.Calendar_LocationColumn.DataPropertyName = "Location";
            this.Calendar_LocationColumn.HeaderText = "Location";
            this.Calendar_LocationColumn.MinimumWidth = 6;
            this.Calendar_LocationColumn.Name = "Calendar_LocationColumn";
            this.Calendar_LocationColumn.Width = 125;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.Calendar_Page);
            this.tabControl.Controls.Add(this.SFTP_Page);
            this.tabControl.Controls.Add(this.ConsentForms_Page);
            this.tabControl.Controls.Add(this.Settings_Page);
            this.tabControl.Controls.Add(this.Help_Page);
            this.tabControl.Location = new System.Drawing.Point(2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 437);
            this.tabControl.TabIndex = 0;
            // 
            // Calendar_Page
            // 
            this.Calendar_Page.Controls.Add(this.Calendar_MonthButton);
            this.Calendar_Page.Controls.Add(this.Calendar_HalfYearButton);
            this.Calendar_Page.Controls.Add(this.Calendar_YearButton);
            this.Calendar_Page.Controls.Add(this.Calendar_AllButton);
            this.Calendar_Page.Controls.Add(this.Calendar_SaveButton);
            this.Calendar_Page.Controls.Add(this.Calendar_OpenButton);
            this.Calendar_Page.Controls.Add(this.Calendar_SyncButton);
            this.Calendar_Page.Controls.Add(this.Calendar_ExportButton);
            this.Calendar_Page.Controls.Add(this.Calendar_RemoveButton);
            this.Calendar_Page.Controls.Add(this.Calendar_AddButton);
            this.Calendar_Page.Controls.Add(this.Calendar_View);
            this.Calendar_Page.Controls.Add(this.Calendar_PeriodBox);
            this.Calendar_Page.Controls.Add(this.Calendar_AddYearButton);
            this.Calendar_Page.Controls.Add(this.Calendar_SubtractYearButton);
            this.Calendar_Page.Location = new System.Drawing.Point(4, 24);
            this.Calendar_Page.Name = "Calendar_Page";
            this.Calendar_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Calendar_Page.Size = new System.Drawing.Size(794, 409);
            this.Calendar_Page.TabIndex = 0;
            this.Calendar_Page.Text = "Calendar";
            this.Calendar_Page.UseVisualStyleBackColor = true;
            // 
            // Calendar_MonthButton
            // 
            this.Calendar_MonthButton.AutoSize = true;
            this.Calendar_MonthButton.Location = new System.Drawing.Point(407, 11);
            this.Calendar_MonthButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calendar_MonthButton.Name = "Calendar_MonthButton";
            this.Calendar_MonthButton.Size = new System.Drawing.Size(61, 19);
            this.Calendar_MonthButton.TabIndex = 13;
            this.Calendar_MonthButton.TabStop = true;
            this.Calendar_MonthButton.Text = "Month";
            this.Calendar_MonthButton.UseVisualStyleBackColor = true;
            this.Calendar_MonthButton.CheckedChanged += new System.EventHandler(this.PeriodChanged);
            // 
            // Calendar_HalfYearButton
            // 
            this.Calendar_HalfYearButton.AutoSize = true;
            this.Calendar_HalfYearButton.Location = new System.Drawing.Point(315, 11);
            this.Calendar_HalfYearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calendar_HalfYearButton.Name = "Calendar_HalfYearButton";
            this.Calendar_HalfYearButton.Size = new System.Drawing.Size(74, 19);
            this.Calendar_HalfYearButton.TabIndex = 12;
            this.Calendar_HalfYearButton.TabStop = true;
            this.Calendar_HalfYearButton.Text = "Half-year";
            this.Calendar_HalfYearButton.UseVisualStyleBackColor = true;
            this.Calendar_HalfYearButton.CheckedChanged += new System.EventHandler(this.PeriodChanged);
            // 
            // Calendar_YearButton
            // 
            this.Calendar_YearButton.AutoSize = true;
            this.Calendar_YearButton.Checked = true;
            this.Calendar_YearButton.Location = new System.Drawing.Point(249, 11);
            this.Calendar_YearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calendar_YearButton.Name = "Calendar_YearButton";
            this.Calendar_YearButton.Size = new System.Drawing.Size(47, 19);
            this.Calendar_YearButton.TabIndex = 11;
            this.Calendar_YearButton.TabStop = true;
            this.Calendar_YearButton.Text = "Year";
            this.Calendar_YearButton.UseVisualStyleBackColor = true;
            this.Calendar_YearButton.CheckedChanged += new System.EventHandler(this.PeriodChanged);
            // 
            // Calendar_AllButton
            // 
            this.Calendar_AllButton.AutoSize = true;
            this.Calendar_AllButton.Location = new System.Drawing.Point(192, 11);
            this.Calendar_AllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calendar_AllButton.Name = "Calendar_AllButton";
            this.Calendar_AllButton.Size = new System.Drawing.Size(39, 19);
            this.Calendar_AllButton.TabIndex = 10;
            this.Calendar_AllButton.Text = "All";
            this.Calendar_AllButton.UseVisualStyleBackColor = true;
            this.Calendar_AllButton.CheckedChanged += new System.EventHandler(this.PeriodChanged);
            // 
            // Calendar_SaveButton
            // 
            this.Calendar_SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar_SaveButton.Location = new System.Drawing.Point(674, 10);
            this.Calendar_SaveButton.Name = "Calendar_SaveButton";
            this.Calendar_SaveButton.Size = new System.Drawing.Size(50, 23);
            this.Calendar_SaveButton.TabIndex = 9;
            this.Calendar_SaveButton.Text = "Save";
            this.Calendar_SaveButton.UseVisualStyleBackColor = true;
            this.Calendar_SaveButton.Click += new System.EventHandler(this.SaveCalendar);
            // 
            // Calendar_OpenButton
            // 
            this.Calendar_OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar_OpenButton.Location = new System.Drawing.Point(734, 10);
            this.Calendar_OpenButton.Name = "Calendar_OpenButton";
            this.Calendar_OpenButton.Size = new System.Drawing.Size(50, 23);
            this.Calendar_OpenButton.TabIndex = 8;
            this.Calendar_OpenButton.Text = "Open";
            this.Calendar_OpenButton.UseVisualStyleBackColor = true;
            this.Calendar_OpenButton.Click += new System.EventHandler(this.OpenCalendar);
            // 
            // Calendar_SyncButton
            // 
            this.Calendar_SyncButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar_SyncButton.Location = new System.Drawing.Point(549, 378);
            this.Calendar_SyncButton.Name = "Calendar_SyncButton";
            this.Calendar_SyncButton.Size = new System.Drawing.Size(125, 23);
            this.Calendar_SyncButton.TabIndex = 7;
            this.Calendar_SyncButton.Text = "Sync Calendar";
            this.Calendar_SyncButton.UseVisualStyleBackColor = true;
            this.Calendar_SyncButton.Click += new System.EventHandler(this.SyncCalendar);
            // 
            // Calendar_ExportButton
            // 
            this.Calendar_ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar_ExportButton.Location = new System.Drawing.Point(684, 378);
            this.Calendar_ExportButton.Name = "Calendar_ExportButton";
            this.Calendar_ExportButton.Size = new System.Drawing.Size(100, 23);
            this.Calendar_ExportButton.TabIndex = 6;
            this.Calendar_ExportButton.Text = "Export PDF";
            this.Calendar_ExportButton.UseVisualStyleBackColor = true;
            this.Calendar_ExportButton.Click += new System.EventHandler(this.ExportPDF);
            // 
            // Calendar_RemoveButton
            // 
            this.Calendar_RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Calendar_RemoveButton.Location = new System.Drawing.Point(95, 378);
            this.Calendar_RemoveButton.Name = "Calendar_RemoveButton";
            this.Calendar_RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.Calendar_RemoveButton.TabIndex = 5;
            this.Calendar_RemoveButton.Text = "Remove";
            this.Calendar_RemoveButton.UseVisualStyleBackColor = true;
            this.Calendar_RemoveButton.Click += new System.EventHandler(this.RemoveEvent);
            // 
            // Calendar_AddButton
            // 
            this.Calendar_AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Calendar_AddButton.Location = new System.Drawing.Point(10, 378);
            this.Calendar_AddButton.Name = "Calendar_AddButton";
            this.Calendar_AddButton.Size = new System.Drawing.Size(75, 23);
            this.Calendar_AddButton.TabIndex = 4;
            this.Calendar_AddButton.Text = "Add";
            this.Calendar_AddButton.UseVisualStyleBackColor = true;
            this.Calendar_AddButton.Click += new System.EventHandler(this.AddEvent);
            // 
            // Calendar_PeriodBox
            // 
            this.Calendar_PeriodBox.Location = new System.Drawing.Point(38, 10);
            this.Calendar_PeriodBox.Name = "Calendar_PeriodBox";
            this.Calendar_PeriodBox.Size = new System.Drawing.Size(100, 23);
            this.Calendar_PeriodBox.TabIndex = 2;
            this.Calendar_PeriodBox.Text = "2020";
            this.Calendar_PeriodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calendar_AddYearButton
            // 
            this.Calendar_AddYearButton.Location = new System.Drawing.Point(143, 10);
            this.Calendar_AddYearButton.Name = "Calendar_AddYearButton";
            this.Calendar_AddYearButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Calendar_AddYearButton.Size = new System.Drawing.Size(23, 23);
            this.Calendar_AddYearButton.TabIndex = 1;
            this.Calendar_AddYearButton.Text = "+";
            this.Calendar_AddYearButton.UseVisualStyleBackColor = true;
            this.Calendar_AddYearButton.Click += new System.EventHandler(this.UpdatePeriod);
            // 
            // Calendar_SubtractYearButton
            // 
            this.Calendar_SubtractYearButton.Location = new System.Drawing.Point(10, 10);
            this.Calendar_SubtractYearButton.Name = "Calendar_SubtractYearButton";
            this.Calendar_SubtractYearButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Calendar_SubtractYearButton.Size = new System.Drawing.Size(23, 23);
            this.Calendar_SubtractYearButton.TabIndex = 0;
            this.Calendar_SubtractYearButton.Text = "-";
            this.Calendar_SubtractYearButton.UseVisualStyleBackColor = true;
            this.Calendar_SubtractYearButton.Click += new System.EventHandler(this.UpdatePeriod);
            // 
            // SFTP_Page
            // 
            this.SFTP_Page.Controls.Add(this.SFTP_SyncButton);
            this.SFTP_Page.Controls.Add(this.SFTP_DownloadButton);
            this.SFTP_Page.Controls.Add(this.SFTP_ShowDirectoryButton);
            this.SFTP_Page.Controls.Add(this.SFTP_View);
            this.SFTP_Page.Controls.Add(this.SFTP_BrowseButton);
            this.SFTP_Page.Controls.Add(this.SFTP_RemoteDirectoryBox);
            this.SFTP_Page.Controls.Add(this.SFTP_RemoteDirectoryLabel);
            this.SFTP_Page.Controls.Add(this.SFTP_LocalDirectoryLabel);
            this.SFTP_Page.Controls.Add(this.SFTP_LocalDirectoryBox);
            this.SFTP_Page.Controls.Add(this.SFTP_PasswordLabel);
            this.SFTP_Page.Controls.Add(this.SFTP_PasswordBox);
            this.SFTP_Page.Controls.Add(this.SFTP_UsernameLabel);
            this.SFTP_Page.Controls.Add(this.SFTP_UsernameBox);
            this.SFTP_Page.Controls.Add(this.SFTP_HostLabel);
            this.SFTP_Page.Controls.Add(this.SFTP_HostBox);
            this.SFTP_Page.Location = new System.Drawing.Point(4, 24);
            this.SFTP_Page.Name = "SFTP_Page";
            this.SFTP_Page.Size = new System.Drawing.Size(794, 409);
            this.SFTP_Page.TabIndex = 2;
            this.SFTP_Page.Text = "SFTP";
            this.SFTP_Page.UseVisualStyleBackColor = true;
            // 
            // SFTP_SyncButton
            // 
            this.SFTP_SyncButton.Location = new System.Drawing.Point(10, 198);
            this.SFTP_SyncButton.Name = "SFTP_SyncButton";
            this.SFTP_SyncButton.Size = new System.Drawing.Size(220, 38);
            this.SFTP_SyncButton.TabIndex = 14;
            this.SFTP_SyncButton.Text = "Synchronize";
            this.SFTP_SyncButton.UseVisualStyleBackColor = true;
            this.SFTP_SyncButton.Click += new System.EventHandler(this.SyncDirectories);
            // 
            // SFTP_DownloadButton
            // 
            this.SFTP_DownloadButton.Location = new System.Drawing.Point(10, 154);
            this.SFTP_DownloadButton.Name = "SFTP_DownloadButton";
            this.SFTP_DownloadButton.Size = new System.Drawing.Size(220, 38);
            this.SFTP_DownloadButton.TabIndex = 13;
            this.SFTP_DownloadButton.Text = "Download all files";
            this.SFTP_DownloadButton.UseVisualStyleBackColor = true;
            this.SFTP_DownloadButton.Click += new System.EventHandler(this.DownloadAll);
            // 
            // SFTP_ShowDirectoryButton
            // 
            this.SFTP_ShowDirectoryButton.Location = new System.Drawing.Point(10, 110);
            this.SFTP_ShowDirectoryButton.Name = "SFTP_ShowDirectoryButton";
            this.SFTP_ShowDirectoryButton.Size = new System.Drawing.Size(220, 38);
            this.SFTP_ShowDirectoryButton.TabIndex = 12;
            this.SFTP_ShowDirectoryButton.Text = "Show directory";
            this.SFTP_ShowDirectoryButton.UseVisualStyleBackColor = true;
            this.SFTP_ShowDirectoryButton.Click += new System.EventHandler(this.ShowDirectory);
            // 
            // SFTP_View
            // 
            this.SFTP_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SFTP_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SFTP_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SFTP_NameColumn,
            this.SFTP_SizeColumn});
            this.SFTP_View.Location = new System.Drawing.Point(250, 70);
            this.SFTP_View.Name = "SFTP_View";
            this.SFTP_View.RowHeadersVisible = false;
            this.SFTP_View.RowHeadersWidth = 51;
            this.SFTP_View.RowTemplate.Height = 25;
            this.SFTP_View.Size = new System.Drawing.Size(536, 332);
            this.SFTP_View.TabIndex = 11;
            // 
            // SFTP_NameColumn
            // 
            this.SFTP_NameColumn.DataPropertyName = "Name";
            this.SFTP_NameColumn.HeaderText = "File name";
            this.SFTP_NameColumn.MinimumWidth = 6;
            this.SFTP_NameColumn.Name = "SFTP_NameColumn";
            this.SFTP_NameColumn.Width = 400;
            // 
            // SFTP_SizeColumn
            // 
            this.SFTP_SizeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SFTP_SizeColumn.DataPropertyName = "Length";
            this.SFTP_SizeColumn.HeaderText = "File size";
            this.SFTP_SizeColumn.MinimumWidth = 6;
            this.SFTP_SizeColumn.Name = "SFTP_SizeColumn";
            // 
            // SFTP_BrowseButton
            // 
            this.SFTP_BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SFTP_BrowseButton.Location = new System.Drawing.Point(711, 10);
            this.SFTP_BrowseButton.Name = "SFTP_BrowseButton";
            this.SFTP_BrowseButton.Size = new System.Drawing.Size(75, 20);
            this.SFTP_BrowseButton.TabIndex = 10;
            this.SFTP_BrowseButton.Text = "Browse";
            this.SFTP_BrowseButton.UseVisualStyleBackColor = true;
            this.SFTP_BrowseButton.Click += new System.EventHandler(this.BrowseLocalDirectory);
            // 
            // SFTP_RemoteDirectoryBox
            // 
            this.SFTP_RemoteDirectoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SFTP_RemoteDirectoryBox.Location = new System.Drawing.Point(363, 40);
            this.SFTP_RemoteDirectoryBox.Name = "SFTP_RemoteDirectoryBox";
            this.SFTP_RemoteDirectoryBox.Size = new System.Drawing.Size(423, 23);
            this.SFTP_RemoteDirectoryBox.TabIndex = 9;
            // 
            // SFTP_RemoteDirectoryLabel
            // 
            this.SFTP_RemoteDirectoryLabel.AutoSize = true;
            this.SFTP_RemoteDirectoryLabel.Location = new System.Drawing.Point(250, 43);
            this.SFTP_RemoteDirectoryLabel.Name = "SFTP_RemoteDirectoryLabel";
            this.SFTP_RemoteDirectoryLabel.Size = new System.Drawing.Size(98, 15);
            this.SFTP_RemoteDirectoryLabel.TabIndex = 8;
            this.SFTP_RemoteDirectoryLabel.Text = "Remote directory";
            // 
            // SFTP_LocalDirectoryLabel
            // 
            this.SFTP_LocalDirectoryLabel.AutoSize = true;
            this.SFTP_LocalDirectoryLabel.Location = new System.Drawing.Point(250, 13);
            this.SFTP_LocalDirectoryLabel.Name = "SFTP_LocalDirectoryLabel";
            this.SFTP_LocalDirectoryLabel.Size = new System.Drawing.Size(85, 15);
            this.SFTP_LocalDirectoryLabel.TabIndex = 7;
            this.SFTP_LocalDirectoryLabel.Text = "Local directory";
            // 
            // SFTP_LocalDirectoryBox
            // 
            this.SFTP_LocalDirectoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SFTP_LocalDirectoryBox.Location = new System.Drawing.Point(363, 10);
            this.SFTP_LocalDirectoryBox.Name = "SFTP_LocalDirectoryBox";
            this.SFTP_LocalDirectoryBox.Size = new System.Drawing.Size(342, 23);
            this.SFTP_LocalDirectoryBox.TabIndex = 6;
            // 
            // SFTP_PasswordLabel
            // 
            this.SFTP_PasswordLabel.AutoSize = true;
            this.SFTP_PasswordLabel.Location = new System.Drawing.Point(10, 73);
            this.SFTP_PasswordLabel.Name = "SFTP_PasswordLabel";
            this.SFTP_PasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.SFTP_PasswordLabel.TabIndex = 5;
            this.SFTP_PasswordLabel.Text = "Password";
            // 
            // SFTP_PasswordBox
            // 
            this.SFTP_PasswordBox.Location = new System.Drawing.Point(98, 70);
            this.SFTP_PasswordBox.Name = "SFTP_PasswordBox";
            this.SFTP_PasswordBox.Size = new System.Drawing.Size(132, 23);
            this.SFTP_PasswordBox.TabIndex = 4;
            // 
            // SFTP_UsernameLabel
            // 
            this.SFTP_UsernameLabel.AutoSize = true;
            this.SFTP_UsernameLabel.Location = new System.Drawing.Point(10, 43);
            this.SFTP_UsernameLabel.Name = "SFTP_UsernameLabel";
            this.SFTP_UsernameLabel.Size = new System.Drawing.Size(60, 15);
            this.SFTP_UsernameLabel.TabIndex = 3;
            this.SFTP_UsernameLabel.Text = "Username";
            // 
            // SFTP_UsernameBox
            // 
            this.SFTP_UsernameBox.Location = new System.Drawing.Point(98, 40);
            this.SFTP_UsernameBox.Name = "SFTP_UsernameBox";
            this.SFTP_UsernameBox.Size = new System.Drawing.Size(132, 23);
            this.SFTP_UsernameBox.TabIndex = 2;
            // 
            // SFTP_HostLabel
            // 
            this.SFTP_HostLabel.AutoSize = true;
            this.SFTP_HostLabel.Location = new System.Drawing.Point(10, 13);
            this.SFTP_HostLabel.Name = "SFTP_HostLabel";
            this.SFTP_HostLabel.Size = new System.Drawing.Size(32, 15);
            this.SFTP_HostLabel.TabIndex = 1;
            this.SFTP_HostLabel.Text = "Host";
            // 
            // SFTP_HostBox
            // 
            this.SFTP_HostBox.Location = new System.Drawing.Point(98, 10);
            this.SFTP_HostBox.Name = "SFTP_HostBox";
            this.SFTP_HostBox.Size = new System.Drawing.Size(132, 23);
            this.SFTP_HostBox.TabIndex = 0;
            // 
            // ConsentForms_Page
            // 
            this.ConsentForms_Page.Controls.Add(this.ConsentForms_RemoveButton);
            this.ConsentForms_Page.Controls.Add(this.ConsentForms_AddButton);
            this.ConsentForms_Page.Controls.Add(this.ConsentForms_View);
            this.ConsentForms_Page.Location = new System.Drawing.Point(4, 24);
            this.ConsentForms_Page.Name = "ConsentForms_Page";
            this.ConsentForms_Page.Padding = new System.Windows.Forms.Padding(3);
            this.ConsentForms_Page.Size = new System.Drawing.Size(794, 409);
            this.ConsentForms_Page.TabIndex = 4;
            this.ConsentForms_Page.Text = "Consent forms";
            this.ConsentForms_Page.UseVisualStyleBackColor = true;
            // 
            // ConsentForms_RemoveButton
            // 
            this.ConsentForms_RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConsentForms_RemoveButton.Location = new System.Drawing.Point(95, 378);
            this.ConsentForms_RemoveButton.Name = "ConsentForms_RemoveButton";
            this.ConsentForms_RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.ConsentForms_RemoveButton.TabIndex = 6;
            this.ConsentForms_RemoveButton.Text = "Remove";
            this.ConsentForms_RemoveButton.UseVisualStyleBackColor = false;
            this.ConsentForms_RemoveButton.Click += new System.EventHandler(this.RemoveConsentForm);
            // 
            // ConsentForms_AddButton
            // 
            this.ConsentForms_AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConsentForms_AddButton.Location = new System.Drawing.Point(10, 378);
            this.ConsentForms_AddButton.Name = "ConsentForms_AddButton";
            this.ConsentForms_AddButton.Size = new System.Drawing.Size(75, 23);
            this.ConsentForms_AddButton.TabIndex = 5;
            this.ConsentForms_AddButton.Text = "Add";
            this.ConsentForms_AddButton.UseVisualStyleBackColor = true;
            this.ConsentForms_AddButton.Click += new System.EventHandler(this.AddConsentForm);
            // 
            // ConsentForms_View
            // 
            this.ConsentForms_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsentForms_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsentForms_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsentForms_NameColumn,
            this.ConsentForms_DateColumn,
            this.ConsentForms_VersionColumn,
            this.ConsentForms_CommentColumn});
            this.ConsentForms_View.Location = new System.Drawing.Point(10, 10);
            this.ConsentForms_View.Name = "ConsentForms_View";
            this.ConsentForms_View.RowHeadersVisible = false;
            this.ConsentForms_View.RowHeadersWidth = 51;
            this.ConsentForms_View.RowTemplate.Height = 25;
            this.ConsentForms_View.Size = new System.Drawing.Size(776, 357);
            this.ConsentForms_View.TabIndex = 0;
            // 
            // ConsentForms_NameColumn
            // 
            this.ConsentForms_NameColumn.DataPropertyName = "Name";
            this.ConsentForms_NameColumn.HeaderText = "Name";
            this.ConsentForms_NameColumn.MinimumWidth = 6;
            this.ConsentForms_NameColumn.Name = "ConsentForms_NameColumn";
            this.ConsentForms_NameColumn.Width = 300;
            // 
            // ConsentForms_DateColumn
            // 
            this.ConsentForms_DateColumn.DataPropertyName = "Signed";
            this.ConsentForms_DateColumn.HeaderText = "Date";
            this.ConsentForms_DateColumn.MinimumWidth = 6;
            this.ConsentForms_DateColumn.Name = "ConsentForms_DateColumn";
            this.ConsentForms_DateColumn.Width = 125;
            // 
            // ConsentForms_VersionColumn
            // 
            this.ConsentForms_VersionColumn.DataPropertyName = "Version";
            this.ConsentForms_VersionColumn.HeaderText = "Version";
            this.ConsentForms_VersionColumn.MinimumWidth = 6;
            this.ConsentForms_VersionColumn.Name = "ConsentForms_VersionColumn";
            this.ConsentForms_VersionColumn.Width = 125;
            // 
            // ConsentForms_CommentColumn
            // 
            this.ConsentForms_CommentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConsentForms_CommentColumn.DataPropertyName = "Comment";
            this.ConsentForms_CommentColumn.HeaderText = "Comment";
            this.ConsentForms_CommentColumn.MinimumWidth = 6;
            this.ConsentForms_CommentColumn.Name = "ConsentForms_CommentColumn";
            // 
            // Settings_Page
            // 
            this.Settings_Page.Controls.Add(this.Settings_InfoBox);
            this.Settings_Page.Location = new System.Drawing.Point(4, 24);
            this.Settings_Page.Name = "Settings_Page";
            this.Settings_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Settings_Page.Size = new System.Drawing.Size(794, 409);
            this.Settings_Page.TabIndex = 3;
            this.Settings_Page.Text = "Settings";
            this.Settings_Page.UseVisualStyleBackColor = true;
            // 
            // Settings_InfoBox
            // 
            this.Settings_InfoBox.Controls.Add(this.Settings_LogoBox);
            this.Settings_InfoBox.Controls.Add(this.Settings_LogoLabel);
            this.Settings_InfoBox.Controls.Add(this.Settings_BrowseButton);
            this.Settings_InfoBox.Controls.Add(this.Settings_AddressLabel);
            this.Settings_InfoBox.Controls.Add(this.Settings_AddressBox);
            this.Settings_InfoBox.Controls.Add(this.Settings_NameLabel);
            this.Settings_InfoBox.Controls.Add(this.Settings_NameBox);
            this.Settings_InfoBox.Controls.Add(this.Settings_PictureBox);
            this.Settings_InfoBox.Location = new System.Drawing.Point(10, 10);
            this.Settings_InfoBox.Name = "Settings_InfoBox";
            this.Settings_InfoBox.Size = new System.Drawing.Size(548, 160);
            this.Settings_InfoBox.TabIndex = 1;
            this.Settings_InfoBox.TabStop = false;
            this.Settings_InfoBox.Text = "Association information";
            // 
            // Settings_LogoBox
            // 
            this.Settings_LogoBox.Location = new System.Drawing.Point(229, 79);
            this.Settings_LogoBox.Name = "Settings_LogoBox";
            this.Settings_LogoBox.Size = new System.Drawing.Size(226, 23);
            this.Settings_LogoBox.TabIndex = 8;
            // 
            // Settings_LogoLabel
            // 
            this.Settings_LogoLabel.AutoSize = true;
            this.Settings_LogoLabel.Location = new System.Drawing.Point(160, 81);
            this.Settings_LogoLabel.Name = "Settings_LogoLabel";
            this.Settings_LogoLabel.Size = new System.Drawing.Size(34, 15);
            this.Settings_LogoLabel.TabIndex = 6;
            this.Settings_LogoLabel.Text = "Logo";
            // 
            // Settings_BrowseButton
            // 
            this.Settings_BrowseButton.Location = new System.Drawing.Point(460, 79);
            this.Settings_BrowseButton.Name = "Settings_BrowseButton";
            this.Settings_BrowseButton.Size = new System.Drawing.Size(75, 20);
            this.Settings_BrowseButton.TabIndex = 5;
            this.Settings_BrowseButton.Text = "Browse";
            this.Settings_BrowseButton.UseVisualStyleBackColor = true;
            this.Settings_BrowseButton.Click += new System.EventHandler(this.BrowseLogo);
            // 
            // Settings_AddressLabel
            // 
            this.Settings_AddressLabel.AutoSize = true;
            this.Settings_AddressLabel.Location = new System.Drawing.Point(160, 52);
            this.Settings_AddressLabel.Name = "Settings_AddressLabel";
            this.Settings_AddressLabel.Size = new System.Drawing.Size(49, 15);
            this.Settings_AddressLabel.TabIndex = 4;
            this.Settings_AddressLabel.Text = "Address";
            // 
            // Settings_AddressBox
            // 
            this.Settings_AddressBox.Location = new System.Drawing.Point(229, 50);
            this.Settings_AddressBox.Name = "Settings_AddressBox";
            this.Settings_AddressBox.Size = new System.Drawing.Size(307, 23);
            this.Settings_AddressBox.TabIndex = 3;
            // 
            // Settings_NameLabel
            // 
            this.Settings_NameLabel.AutoSize = true;
            this.Settings_NameLabel.Location = new System.Drawing.Point(160, 22);
            this.Settings_NameLabel.Name = "Settings_NameLabel";
            this.Settings_NameLabel.Size = new System.Drawing.Size(39, 15);
            this.Settings_NameLabel.TabIndex = 2;
            this.Settings_NameLabel.Text = "Name";
            // 
            // Settings_NameBox
            // 
            this.Settings_NameBox.Location = new System.Drawing.Point(229, 20);
            this.Settings_NameBox.Name = "Settings_NameBox";
            this.Settings_NameBox.Size = new System.Drawing.Size(307, 23);
            this.Settings_NameBox.TabIndex = 1;
            // 
            // Settings_PictureBox
            // 
            this.Settings_PictureBox.BackColor = System.Drawing.Color.LightGray;
            this.Settings_PictureBox.Location = new System.Drawing.Point(10, 20);
            this.Settings_PictureBox.Name = "Settings_PictureBox";
            this.Settings_PictureBox.Size = new System.Drawing.Size(128, 128);
            this.Settings_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings_PictureBox.TabIndex = 0;
            this.Settings_PictureBox.TabStop = false;
            // 
            // Help_Page
            // 
            this.Help_Page.Controls.Add(this.Help_EmailLink);
            this.Help_Page.Controls.Add(this.Help_EmailLabel);
            this.Help_Page.Controls.Add(this.Help_AuthorLabel);
            this.Help_Page.Controls.Add(this.Help_LicenseLabel);
            this.Help_Page.Controls.Add(this.Help_SourceLink);
            this.Help_Page.Controls.Add(this.Help_SourceLabel);
            this.Help_Page.Controls.Add(this.Help_VersionLabel);
            this.Help_Page.Controls.Add(this.Help_IconBox);
            this.Help_Page.Location = new System.Drawing.Point(4, 24);
            this.Help_Page.Name = "Help_Page";
            this.Help_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Help_Page.Size = new System.Drawing.Size(794, 409);
            this.Help_Page.TabIndex = 1;
            this.Help_Page.Text = "Help";
            this.Help_Page.UseVisualStyleBackColor = true;
            // 
            // Help_EmailLink
            // 
            this.Help_EmailLink.AutoSize = true;
            this.Help_EmailLink.Location = new System.Drawing.Point(48, 160);
            this.Help_EmailLink.Name = "Help_EmailLink";
            this.Help_EmailLink.Size = new System.Drawing.Size(185, 15);
            this.Help_EmailLink.TabIndex = 7;
            this.Help_EmailLink.TabStop = true;
            this.Help_EmailLink.Text = "martin.jensen.1997@hotmail.com";
            this.Help_EmailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmailLink_LinkClicked);
            // 
            // Help_EmailLabel
            // 
            this.Help_EmailLabel.AutoSize = true;
            this.Help_EmailLabel.Location = new System.Drawing.Point(10, 160);
            this.Help_EmailLabel.Name = "Help_EmailLabel";
            this.Help_EmailLabel.Size = new System.Drawing.Size(39, 15);
            this.Help_EmailLabel.TabIndex = 6;
            this.Help_EmailLabel.Text = "Email:";
            // 
            // Help_AuthorLabel
            // 
            this.Help_AuthorLabel.AutoSize = true;
            this.Help_AuthorLabel.Location = new System.Drawing.Point(10, 145);
            this.Help_AuthorLabel.Name = "Help_AuthorLabel";
            this.Help_AuthorLabel.Size = new System.Drawing.Size(146, 15);
            this.Help_AuthorLabel.TabIndex = 5;
            this.Help_AuthorLabel.Text = "Author: Martin J. R. Jensen";
            // 
            // Help_LicenseLabel
            // 
            this.Help_LicenseLabel.AutoSize = true;
            this.Help_LicenseLabel.Location = new System.Drawing.Point(10, 191);
            this.Help_LicenseLabel.Name = "Help_LicenseLabel";
            this.Help_LicenseLabel.Size = new System.Drawing.Size(112, 15);
            this.Help_LicenseLabel.TabIndex = 4;
            this.Help_LicenseLabel.Text = "License: Apache-2.0";
            // 
            // Help_SourceLink
            // 
            this.Help_SourceLink.AutoSize = true;
            this.Help_SourceLink.Location = new System.Drawing.Point(55, 206);
            this.Help_SourceLink.Name = "Help_SourceLink";
            this.Help_SourceLink.Size = new System.Drawing.Size(199, 15);
            this.Help_SourceLink.TabIndex = 3;
            this.Help_SourceLink.TabStop = true;
            this.Help_SourceLink.Text = "https://github.com/mjrj97/Manager";
            this.Help_SourceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceLink_LinkClicked);
            // 
            // Help_SourceLabel
            // 
            this.Help_SourceLabel.AutoSize = true;
            this.Help_SourceLabel.Location = new System.Drawing.Point(10, 206);
            this.Help_SourceLabel.Name = "Help_SourceLabel";
            this.Help_SourceLabel.Size = new System.Drawing.Size(46, 15);
            this.Help_SourceLabel.TabIndex = 2;
            this.Help_SourceLabel.Text = "Source:";
            // 
            // Help_VersionLabel
            // 
            this.Help_VersionLabel.AutoSize = true;
            this.Help_VersionLabel.Location = new System.Drawing.Point(10, 117);
            this.Help_VersionLabel.Name = "Help_VersionLabel";
            this.Help_VersionLabel.Size = new System.Drawing.Size(102, 15);
            this.Help_VersionLabel.TabIndex = 1;
            this.Help_VersionLabel.Text = "Timotheus v. 0.1.0";
            // 
            // Help_IconBox
            // 
            this.Help_IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Help_IconBox.Image = ((System.Drawing.Image)(resources.GetObject("Help_IconBox.Image")));
            this.Help_IconBox.Location = new System.Drawing.Point(10, 10);
            this.Help_IconBox.Name = "Help_IconBox";
            this.Help_IconBox.Size = new System.Drawing.Size(100, 100);
            this.Help_IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Help_IconBox.TabIndex = 0;
            this.Help_IconBox.TabStop = false;
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayContextMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Manager";
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Open);
            // 
            // TrayContextMenu
            // 
            this.TrayContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayOpen,
            this.TrayClose});
            this.TrayContextMenu.Name = "TrayContextMenu";
            this.TrayContextMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // TrayOpen
            // 
            this.TrayOpen.Name = "TrayOpen";
            this.TrayOpen.Size = new System.Drawing.Size(103, 22);
            this.TrayOpen.Text = "Open";
            this.TrayOpen.Click += new System.EventHandler(this.Open);
            // 
            // TrayClose
            // 
            this.TrayClose.Name = "TrayClose";
            this.TrayClose.Size = new System.Drawing.Size(103, 22);
            this.TrayClose.Text = "Close";
            this.TrayClose.Click += new System.EventHandler(this.Exit);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 248);
            this.Name = "MainWindow";
            this.Text = "Timotheus";
            this.Resize += new System.EventHandler(this.Manager_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Calendar_View)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.Calendar_Page.ResumeLayout(false);
            this.Calendar_Page.PerformLayout();
            this.SFTP_Page.ResumeLayout(false);
            this.SFTP_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SFTP_View)).EndInit();
            this.ConsentForms_Page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsentForms_View)).EndInit();
            this.Settings_Page.ResumeLayout(false);
            this.Settings_InfoBox.ResumeLayout(false);
            this.Settings_InfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_PictureBox)).EndInit();
            this.Help_Page.ResumeLayout(false);
            this.Help_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help_IconBox)).EndInit();
            this.TrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayOpen;
        private System.Windows.Forms.ToolStripMenuItem TrayClose;
        private System.Windows.Forms.TabPage Calendar_Page;
        private System.Windows.Forms.Button Calendar_SaveButton;
        private System.Windows.Forms.Button Calendar_OpenButton;
        private System.Windows.Forms.Button Calendar_ExportButton;
        private System.Windows.Forms.Button Calendar_RemoveButton;
        private System.Windows.Forms.Button Calendar_AddButton;
        private System.Windows.Forms.Button Calendar_AddYearButton;
        private System.Windows.Forms.Button Calendar_SubtractYearButton;
        public System.Windows.Forms.TextBox Calendar_PeriodBox;
        private System.Windows.Forms.Button Calendar_SyncButton;
        private System.Windows.Forms.RadioButton Calendar_MonthButton;
        private System.Windows.Forms.RadioButton Calendar_HalfYearButton;
        private System.Windows.Forms.RadioButton Calendar_YearButton;
        private System.Windows.Forms.RadioButton Calendar_AllButton;
        private System.Windows.Forms.DataGridView Calendar_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calendar_StartColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calendar_EndColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calendar_NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calendar_DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calendar_LocationColumn;
        private System.Windows.Forms.TabPage SFTP_Page;
        private System.Windows.Forms.Label SFTP_HostLabel;
        private System.Windows.Forms.TextBox SFTP_HostBox;
        private System.Windows.Forms.Label SFTP_UsernameLabel;
        private System.Windows.Forms.TextBox SFTP_UsernameBox;
        private System.Windows.Forms.Label SFTP_PasswordLabel;
        private System.Windows.Forms.TextBox SFTP_PasswordBox;
        private System.Windows.Forms.Label SFTP_RemoteDirectoryLabel;
        private System.Windows.Forms.TextBox SFTP_RemoteDirectoryBox;
        private System.Windows.Forms.Label SFTP_LocalDirectoryLabel;
        private System.Windows.Forms.TextBox SFTP_LocalDirectoryBox;
        private System.Windows.Forms.Button SFTP_BrowseButton;
        private System.Windows.Forms.Button SFTP_ShowDirectoryButton;
        private System.Windows.Forms.Button SFTP_DownloadButton;
        private System.Windows.Forms.Button SFTP_SyncButton;
        private System.Windows.Forms.DataGridView SFTP_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFTP_NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SFTP_SizeColumn;
        private System.Windows.Forms.TabPage ConsentForms_Page;
        private System.Windows.Forms.Button ConsentForms_AddButton;
        private System.Windows.Forms.Button ConsentForms_RemoveButton;
        private System.Windows.Forms.DataGridView ConsentForms_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsentForms_NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsentForms_DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsentForms_VersionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsentForms_CommentColumn;
        private System.Windows.Forms.TabPage Settings_Page;
        private System.Windows.Forms.Label Settings_NameLabel;
        private System.Windows.Forms.TextBox Settings_NameBox;
        private System.Windows.Forms.Label Settings_AddressLabel;
        public System.Windows.Forms.TextBox Settings_AddressBox;
        private System.Windows.Forms.Label Settings_LogoLabel;
        private System.Windows.Forms.TextBox Settings_LogoBox;
        private System.Windows.Forms.Button Settings_BrowseButton;
        private System.Windows.Forms.PictureBox Settings_PictureBox;
        private System.Windows.Forms.GroupBox Settings_InfoBox;
        private System.Windows.Forms.TabPage Help_Page;
        private System.Windows.Forms.Label Help_AuthorLabel;
        private System.Windows.Forms.Label Help_VersionLabel;
        private System.Windows.Forms.Label Help_LicenseLabel;
        private System.Windows.Forms.Label Help_EmailLabel;
        private System.Windows.Forms.LinkLabel Help_EmailLink;
        private System.Windows.Forms.Label Help_SourceLabel;
        private System.Windows.Forms.LinkLabel Help_SourceLink;
        private System.Windows.Forms.PictureBox Help_IconBox;
    }
}