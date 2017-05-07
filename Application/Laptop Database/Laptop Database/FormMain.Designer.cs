namespace Laptop_Database
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_About = new System.Windows.Forms.PictureBox();
            this.pictureBox_Add = new System.Windows.Forms.PictureBox();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Search = new System.Windows.Forms.TabPage();
            this.dataGridView_Search = new System.Windows.Forms.DataGridView();
            this.product_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolution_width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolution_height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu_cores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ram_freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ram_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drive_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inconsistent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Search_Top = new System.Windows.Forms.Panel();
            this.topSearch = new Bunifu.Framework.UI.BunifuDropdown();
            this.customFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage_Add = new System.Windows.Forms.TabPage();
            this.label_NumberOfAdded = new System.Windows.Forms.Label();
            this.panel_Result = new System.Windows.Forms.Panel();
            this.label_Result = new System.Windows.Forms.Label();
            this.panel_Add_DragAndDrop = new System.Windows.Forms.Panel();
            this.tabPage_About = new System.Windows.Forms.TabPage();
            this.panel_CodeCreator = new System.Windows.Forms.Panel();
            this.pictureBox_CodeCreator = new System.Windows.Forms.PictureBox();
            this.label_CodeCreatorName = new System.Windows.Forms.Label();
            this.label_CodeCreator = new System.Windows.Forms.Label();
            this.panel_DesignCreator = new System.Windows.Forms.Panel();
            this.pictureBox_DesignCreator = new System.Windows.Forms.PictureBox();
            this.label_DesignCreatorName = new System.Windows.Forms.Label();
            this.label_DesignCreator = new System.Windows.Forms.Label();
            this.panel_DatabaseCreator = new System.Windows.Forms.Panel();
            this.pictureBox_DatabaseCreator = new System.Windows.Forms.PictureBox();
            this.label_DatabaseCreatorName = new System.Windows.Forms.Label();
            this.label_DatabaseCreator = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).BeginInit();
            this.panel_Search_Top.SuspendLayout();
            this.tabPage_Add.SuspendLayout();
            this.panel_Result.SuspendLayout();
            this.tabPage_About.SuspendLayout();
            this.panel_CodeCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CodeCreator)).BeginInit();
            this.panel_DesignCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DesignCreator)).BeginInit();
            this.panel_DatabaseCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DatabaseCreator)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_Menu.Controls.Add(this.pictureBox_Logo);
            this.panel_Menu.Controls.Add(this.pictureBox_About);
            this.panel_Menu.Controls.Add(this.pictureBox_Add);
            this.panel_Menu.Controls.Add(this.pictureBox_Search);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(157, 439);
            this.panel_Menu.TabIndex = 0;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::Laptop_Database.Properties.Resources.logo1;
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 12);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(157, 79);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 6;
            this.pictureBox_Logo.TabStop = false;
            // 
            // pictureBox_About
            // 
            this.pictureBox_About.Image = global::Laptop_Database.Properties.Resources.button_about;
            this.pictureBox_About.Location = new System.Drawing.Point(0, 377);
            this.pictureBox_About.Name = "pictureBox_About";
            this.pictureBox_About.Size = new System.Drawing.Size(160, 50);
            this.pictureBox_About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_About.TabIndex = 5;
            this.pictureBox_About.TabStop = false;
            this.pictureBox_About.Click += new System.EventHandler(this.Button_AboutClick);
            this.pictureBox_About.MouseLeave += new System.EventHandler(this.Button_AboutLeave);
            this.pictureBox_About.MouseHover += new System.EventHandler(this.Button_AboutHover);
            // 
            // pictureBox_Add
            // 
            this.pictureBox_Add.Image = global::Laptop_Database.Properties.Resources.button_add;
            this.pictureBox_Add.Location = new System.Drawing.Point(0, 178);
            this.pictureBox_Add.Name = "pictureBox_Add";
            this.pictureBox_Add.Size = new System.Drawing.Size(160, 50);
            this.pictureBox_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Add.TabIndex = 4;
            this.pictureBox_Add.TabStop = false;
            this.pictureBox_Add.Click += new System.EventHandler(this.Button_AddClick);
            this.pictureBox_Add.MouseLeave += new System.EventHandler(this.Button_AddLeave);
            this.pictureBox_Add.MouseHover += new System.EventHandler(this.Button_AddHover);
            // 
            // pictureBox_Search
            // 
            this.pictureBox_Search.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox_Search.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Search.Image")));
            this.pictureBox_Search.Location = new System.Drawing.Point(0, 122);
            this.pictureBox_Search.Name = "pictureBox_Search";
            this.pictureBox_Search.Size = new System.Drawing.Size(160, 50);
            this.pictureBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Search.TabIndex = 3;
            this.pictureBox_Search.TabStop = false;
            this.pictureBox_Search.Click += new System.EventHandler(this.Button_SearchClick);
            this.pictureBox_Search.MouseLeave += new System.EventHandler(this.Button_SearchLeave);
            this.pictureBox_Search.MouseHover += new System.EventHandler(this.Button_SearchHover);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Search);
            this.tabControl.Controls.Add(this.tabPage_Add);
            this.tabControl.Controls.Add(this.tabPage_About);
            this.tabControl.Location = new System.Drawing.Point(151, -24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(739, 472);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_Search
            // 
            this.tabPage_Search.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Search.Controls.Add(this.dataGridView_Search);
            this.tabPage_Search.Controls.Add(this.panel_Search_Top);
            this.tabPage_Search.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Search.Name = "tabPage_Search";
            this.tabPage_Search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Search.Size = new System.Drawing.Size(731, 446);
            this.tabPage_Search.TabIndex = 0;
            this.tabPage_Search.Text = "tabPage_Search";
            // 
            // dataGridView_Search
            // 
            this.dataGridView_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Search.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_number,
            this.screen,
            this.resolution_width,
            this.resolution_height,
            this.os,
            this.gpu,
            this.cpu,
            this.cpu_cores,
            this.ram,
            this.ram_freq,
            this.ram_size,
            this.drive,
            this.drive_capacity,
            this.color,
            this.height,
            this.width,
            this.Depth,
            this.weight,
            this.inconsistent});
            this.dataGridView_Search.Location = new System.Drawing.Point(0, 76);
            this.dataGridView_Search.Name = "dataGridView_Search";
            this.dataGridView_Search.ReadOnly = true;
            this.dataGridView_Search.RowHeadersVisible = false;
            this.dataGridView_Search.Size = new System.Drawing.Size(729, 365);
            this.dataGridView_Search.TabIndex = 0;
            this.dataGridView_Search.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_Search_CellFormatting);
            // 
            // product_number
            // 
            this.product_number.DataPropertyName = "serial";
            this.product_number.HeaderText = "Product Number";
            this.product_number.Name = "product_number";
            this.product_number.ReadOnly = true;
            // 
            // screen
            // 
            this.screen.DataPropertyName = "display.diagonal";
            this.screen.HeaderText = "Screen";
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Width = 66;
            // 
            // resolution_width
            // 
            this.resolution_width.DataPropertyName = "display.width";
            this.resolution_width.HeaderText = "Resolution Width";
            this.resolution_width.Name = "resolution_width";
            this.resolution_width.ReadOnly = true;
            this.resolution_width.Width = 104;
            // 
            // resolution_height
            // 
            this.resolution_height.DataPropertyName = "display.height";
            this.resolution_height.HeaderText = "Resolution Height";
            this.resolution_height.Name = "resolution_height";
            this.resolution_height.ReadOnly = true;
            this.resolution_height.Width = 106;
            // 
            // os
            // 
            this.os.DataPropertyName = "os.label";
            this.os.HeaderText = "OS";
            this.os.Name = "os";
            this.os.ReadOnly = true;
            this.os.Width = 47;
            // 
            // gpu
            // 
            this.gpu.DataPropertyName = "gpu.type";
            this.gpu.HeaderText = "GPU";
            this.gpu.Name = "gpu";
            this.gpu.ReadOnly = true;
            this.gpu.Width = 55;
            // 
            // cpu
            // 
            this.cpu.DataPropertyName = "cpu.type";
            this.cpu.HeaderText = "CPU";
            this.cpu.Name = "cpu";
            this.cpu.ReadOnly = true;
            this.cpu.Width = 54;
            // 
            // cpu_cores
            // 
            this.cpu_cores.DataPropertyName = "cpu.number_cores";
            this.cpu_cores.HeaderText = "Cores";
            this.cpu_cores.Name = "cpu_cores";
            this.cpu_cores.ReadOnly = true;
            this.cpu_cores.Width = 59;
            // 
            // ram
            // 
            this.ram.DataPropertyName = "ram.type";
            this.ram.HeaderText = "RAM";
            this.ram.Name = "ram";
            this.ram.ReadOnly = true;
            this.ram.Width = 56;
            // 
            // ram_freq
            // 
            this.ram_freq.DataPropertyName = "ram.frequency";
            this.ram_freq.HeaderText = "Frequency";
            this.ram_freq.Name = "ram_freq";
            this.ram_freq.ReadOnly = true;
            this.ram_freq.Width = 82;
            // 
            // ram_size
            // 
            this.ram_size.DataPropertyName = "ram.size";
            this.ram_size.HeaderText = "Size";
            this.ram_size.Name = "ram_size";
            this.ram_size.ReadOnly = true;
            this.ram_size.Width = 52;
            // 
            // drive
            // 
            this.drive.DataPropertyName = "hdd.type";
            this.drive.HeaderText = "Drive";
            this.drive.Name = "drive";
            this.drive.ReadOnly = true;
            this.drive.Width = 57;
            // 
            // drive_capacity
            // 
            this.drive_capacity.DataPropertyName = "hdd.size";
            this.drive_capacity.HeaderText = "Capacity";
            this.drive_capacity.Name = "drive_capacity";
            this.drive_capacity.ReadOnly = true;
            this.drive_capacity.Width = 73;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 56;
            // 
            // height
            // 
            this.height.DataPropertyName = "height";
            this.height.HeaderText = "Height";
            this.height.Name = "height";
            this.height.ReadOnly = true;
            this.height.Width = 63;
            // 
            // width
            // 
            this.width.DataPropertyName = "width";
            this.width.HeaderText = "Width";
            this.width.Name = "width";
            this.width.ReadOnly = true;
            this.width.Width = 60;
            // 
            // Depth
            // 
            this.Depth.DataPropertyName = "depth";
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            this.Depth.ReadOnly = true;
            this.Depth.Width = 61;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 66;
            // 
            // inconsistent
            // 
            this.inconsistent.HeaderText = "Inconsistent";
            this.inconsistent.Name = "inconsistent";
            this.inconsistent.ReadOnly = true;
            this.inconsistent.Width = 89;
            // 
            // panel_Search_Top
            // 
            this.panel_Search_Top.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Search_Top.BackgroundImage = global::Laptop_Database.Properties.Resources.CodeTranslation;
            this.panel_Search_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_Search_Top.Controls.Add(this.topSearch);
            this.panel_Search_Top.Controls.Add(this.customFilter);
            this.panel_Search_Top.Location = new System.Drawing.Point(0, 2);
            this.panel_Search_Top.Name = "panel_Search_Top";
            this.panel_Search_Top.Size = new System.Drawing.Size(731, 74);
            this.panel_Search_Top.TabIndex = 6;
            // 
            // topSearch
            // 
            this.topSearch.BackColor = System.Drawing.Color.Transparent;
            this.topSearch.BorderRadius = 3;
            this.topSearch.ForeColor = System.Drawing.Color.White;
            this.topSearch.Items = new string[0];
            this.topSearch.Location = new System.Drawing.Point(16, 12);
            this.topSearch.Name = "topSearch";
            this.topSearch.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.topSearch.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.topSearch.selectedIndex = -1;
            this.topSearch.Size = new System.Drawing.Size(453, 48);
            this.topSearch.TabIndex = 1;
            this.topSearch.onItemSelected += new System.EventHandler(this.TopSearch_onItemSelected);
            // 
            // customFilter
            // 
            this.customFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.customFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.customFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customFilter.BorderRadius = 0;
            this.customFilter.ButtonText = "Custom filter";
            this.customFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customFilter.DisabledColor = System.Drawing.Color.Gray;
            this.customFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.customFilter.Iconimage = null;
            this.customFilter.Iconimage_right = null;
            this.customFilter.Iconimage_right_Selected = null;
            this.customFilter.Iconimage_Selected = null;
            this.customFilter.IconMarginLeft = 0;
            this.customFilter.IconMarginRight = 0;
            this.customFilter.IconRightVisible = true;
            this.customFilter.IconRightZoom = 0D;
            this.customFilter.IconVisible = true;
            this.customFilter.IconZoom = 90D;
            this.customFilter.IsTab = false;
            this.customFilter.Location = new System.Drawing.Point(475, 12);
            this.customFilter.Name = "customFilter";
            this.customFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.customFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.customFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.customFilter.selected = false;
            this.customFilter.Size = new System.Drawing.Size(241, 48);
            this.customFilter.TabIndex = 0;
            this.customFilter.Text = "Custom filter";
            this.customFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customFilter.Textcolor = System.Drawing.Color.White;
            this.customFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customFilter.Click += new System.EventHandler(this.CustomFilter_Click);
            // 
            // tabPage_Add
            // 
            this.tabPage_Add.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Add.BackgroundImage = global::Laptop_Database.Properties.Resources.CodeTranslation;
            this.tabPage_Add.Controls.Add(this.label_NumberOfAdded);
            this.tabPage_Add.Controls.Add(this.panel_Result);
            this.tabPage_Add.Controls.Add(this.panel_Add_DragAndDrop);
            this.tabPage_Add.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Add.Name = "tabPage_Add";
            this.tabPage_Add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Add.Size = new System.Drawing.Size(731, 446);
            this.tabPage_Add.TabIndex = 1;
            this.tabPage_Add.Text = "tabPage_Add";
            // 
            // label_NumberOfAdded
            // 
            this.label_NumberOfAdded.AutoSize = true;
            this.label_NumberOfAdded.BackColor = System.Drawing.Color.Transparent;
            this.label_NumberOfAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NumberOfAdded.Location = new System.Drawing.Point(174, 396);
            this.label_NumberOfAdded.Name = "label_NumberOfAdded";
            this.label_NumberOfAdded.Size = new System.Drawing.Size(0, 16);
            this.label_NumberOfAdded.TabIndex = 4;
            // 
            // panel_Result
            // 
            this.panel_Result.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel_Result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Result.Controls.Add(this.label_Result);
            this.panel_Result.Location = new System.Drawing.Point(16, 379);
            this.panel_Result.Name = "panel_Result";
            this.panel_Result.Size = new System.Drawing.Size(115, 49);
            this.panel_Result.TabIndex = 3;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.Transparent;
            this.label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Result.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Result.Location = new System.Drawing.Point(36, 17);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(46, 16);
            this.label_Result.TabIndex = 2;
            this.label_Result.Text = "Result";
            // 
            // panel_Add_DragAndDrop
            // 
            this.panel_Add_DragAndDrop.AllowDrop = true;
            this.panel_Add_DragAndDrop.BackColor = System.Drawing.Color.Transparent;
            this.panel_Add_DragAndDrop.BackgroundImage = global::Laptop_Database.Properties.Resources.DragAndDrop;
            this.panel_Add_DragAndDrop.Location = new System.Drawing.Point(16, 14);
            this.panel_Add_DragAndDrop.Name = "panel_Add_DragAndDrop";
            this.panel_Add_DragAndDrop.Size = new System.Drawing.Size(700, 348);
            this.panel_Add_DragAndDrop.TabIndex = 0;
            this.panel_Add_DragAndDrop.Click += new System.EventHandler(this.DragAndDrop_Click);
            this.panel_Add_DragAndDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragAndDrop_DragDrop);
            this.panel_Add_DragAndDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragAndDrop_DragEnter);
            this.panel_Add_DragAndDrop.DragLeave += new System.EventHandler(this.DragAndDrop_DragLeave);
            // 
            // tabPage_About
            // 
            this.tabPage_About.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_About.Controls.Add(this.panel_CodeCreator);
            this.tabPage_About.Controls.Add(this.panel_DesignCreator);
            this.tabPage_About.Controls.Add(this.panel_DatabaseCreator);
            this.tabPage_About.Location = new System.Drawing.Point(4, 22);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Size = new System.Drawing.Size(731, 446);
            this.tabPage_About.TabIndex = 2;
            this.tabPage_About.Text = "tabPage_About";
            // 
            // panel_CodeCreator
            // 
            this.panel_CodeCreator.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_CodeCreator.BackgroundImage = global::Laptop_Database.Properties.Resources.CodeTranslation;
            this.panel_CodeCreator.Controls.Add(this.pictureBox_CodeCreator);
            this.panel_CodeCreator.Controls.Add(this.label_CodeCreatorName);
            this.panel_CodeCreator.Controls.Add(this.label_CodeCreator);
            this.panel_CodeCreator.Location = new System.Drawing.Point(-4, 145);
            this.panel_CodeCreator.Name = "panel_CodeCreator";
            this.panel_CodeCreator.Size = new System.Drawing.Size(739, 152);
            this.panel_CodeCreator.TabIndex = 7;
            // 
            // pictureBox_CodeCreator
            // 
            this.pictureBox_CodeCreator.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CodeCreator.Image = global::Laptop_Database.Properties.Resources.code;
            this.pictureBox_CodeCreator.Location = new System.Drawing.Point(87, 51);
            this.pictureBox_CodeCreator.Name = "pictureBox_CodeCreator";
            this.pictureBox_CodeCreator.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_CodeCreator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CodeCreator.TabIndex = 7;
            this.pictureBox_CodeCreator.TabStop = false;
            // 
            // label_CodeCreatorName
            // 
            this.label_CodeCreatorName.AutoSize = true;
            this.label_CodeCreatorName.BackColor = System.Drawing.Color.Transparent;
            this.label_CodeCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CodeCreatorName.Location = new System.Drawing.Point(472, 65);
            this.label_CodeCreatorName.Name = "label_CodeCreatorName";
            this.label_CodeCreatorName.Size = new System.Drawing.Size(68, 20);
            this.label_CodeCreatorName.TabIndex = 6;
            this.label_CodeCreatorName.Text = "Karel Šír";
            // 
            // label_CodeCreator
            // 
            this.label_CodeCreator.AutoSize = true;
            this.label_CodeCreator.BackColor = System.Drawing.Color.Transparent;
            this.label_CodeCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CodeCreator.Location = new System.Drawing.Point(156, 65);
            this.label_CodeCreator.Name = "label_CodeCreator";
            this.label_CodeCreator.Size = new System.Drawing.Size(47, 20);
            this.label_CodeCreator.TabIndex = 1;
            this.label_CodeCreator.Text = "Code";
            // 
            // panel_DesignCreator
            // 
            this.panel_DesignCreator.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_DesignCreator.BackgroundImage = global::Laptop_Database.Properties.Resources.DesignTranslation;
            this.panel_DesignCreator.Controls.Add(this.pictureBox_DesignCreator);
            this.panel_DesignCreator.Controls.Add(this.label_DesignCreatorName);
            this.panel_DesignCreator.Controls.Add(this.label_DesignCreator);
            this.panel_DesignCreator.Location = new System.Drawing.Point(-4, 295);
            this.panel_DesignCreator.Name = "panel_DesignCreator";
            this.panel_DesignCreator.Size = new System.Drawing.Size(739, 146);
            this.panel_DesignCreator.TabIndex = 6;
            // 
            // pictureBox_DesignCreator
            // 
            this.pictureBox_DesignCreator.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_DesignCreator.Image = global::Laptop_Database.Properties.Resources.design;
            this.pictureBox_DesignCreator.Location = new System.Drawing.Point(87, 52);
            this.pictureBox_DesignCreator.Name = "pictureBox_DesignCreator";
            this.pictureBox_DesignCreator.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_DesignCreator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_DesignCreator.TabIndex = 8;
            this.pictureBox_DesignCreator.TabStop = false;
            // 
            // label_DesignCreatorName
            // 
            this.label_DesignCreatorName.AutoSize = true;
            this.label_DesignCreatorName.BackColor = System.Drawing.Color.Transparent;
            this.label_DesignCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_DesignCreatorName.Location = new System.Drawing.Point(447, 67);
            this.label_DesignCreatorName.Name = "label_DesignCreatorName";
            this.label_DesignCreatorName.Size = new System.Drawing.Size(121, 20);
            this.label_DesignCreatorName.TabIndex = 7;
            this.label_DesignCreatorName.Text = "Tomáš Moravec";
            // 
            // label_DesignCreator
            // 
            this.label_DesignCreator.AutoSize = true;
            this.label_DesignCreator.BackColor = System.Drawing.Color.Transparent;
            this.label_DesignCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_DesignCreator.Location = new System.Drawing.Point(156, 67);
            this.label_DesignCreator.Name = "label_DesignCreator";
            this.label_DesignCreator.Size = new System.Drawing.Size(59, 20);
            this.label_DesignCreator.TabIndex = 2;
            this.label_DesignCreator.Text = "Design";
            // 
            // panel_DatabaseCreator
            // 
            this.panel_DatabaseCreator.BackColor = System.Drawing.Color.LightGray;
            this.panel_DatabaseCreator.BackgroundImage = global::Laptop_Database.Properties.Resources.DatabaseTranslation;
            this.panel_DatabaseCreator.Controls.Add(this.pictureBox_DatabaseCreator);
            this.panel_DatabaseCreator.Controls.Add(this.label_DatabaseCreatorName);
            this.panel_DatabaseCreator.Controls.Add(this.label_DatabaseCreator);
            this.panel_DatabaseCreator.Location = new System.Drawing.Point(-4, 0);
            this.panel_DatabaseCreator.Name = "panel_DatabaseCreator";
            this.panel_DatabaseCreator.Size = new System.Drawing.Size(739, 146);
            this.panel_DatabaseCreator.TabIndex = 5;
            // 
            // pictureBox_DatabaseCreator
            // 
            this.pictureBox_DatabaseCreator.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_DatabaseCreator.Image = global::Laptop_Database.Properties.Resources.database;
            this.pictureBox_DatabaseCreator.Location = new System.Drawing.Point(87, 48);
            this.pictureBox_DatabaseCreator.Name = "pictureBox_DatabaseCreator";
            this.pictureBox_DatabaseCreator.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_DatabaseCreator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_DatabaseCreator.TabIndex = 6;
            this.pictureBox_DatabaseCreator.TabStop = false;
            // 
            // label_DatabaseCreatorName
            // 
            this.label_DatabaseCreatorName.AutoSize = true;
            this.label_DatabaseCreatorName.BackColor = System.Drawing.Color.Transparent;
            this.label_DatabaseCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_DatabaseCreatorName.Location = new System.Drawing.Point(456, 63);
            this.label_DatabaseCreatorName.Name = "label_DatabaseCreatorName";
            this.label_DatabaseCreatorName.Size = new System.Drawing.Size(101, 20);
            this.label_DatabaseCreatorName.TabIndex = 5;
            this.label_DatabaseCreatorName.Text = "Václav Langr";
            // 
            // label_DatabaseCreator
            // 
            this.label_DatabaseCreator.AutoSize = true;
            this.label_DatabaseCreator.BackColor = System.Drawing.Color.Transparent;
            this.label_DatabaseCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_DatabaseCreator.Location = new System.Drawing.Point(156, 63);
            this.label_DatabaseCreator.Name = "label_DatabaseCreator";
            this.label_DatabaseCreator.Size = new System.Drawing.Size(79, 20);
            this.label_DatabaseCreator.TabIndex = 4;
            this.label_DatabaseCreator.Text = "Database";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 439);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Laptop Database";
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).EndInit();
            this.panel_Search_Top.ResumeLayout(false);
            this.tabPage_Add.ResumeLayout(false);
            this.tabPage_Add.PerformLayout();
            this.panel_Result.ResumeLayout(false);
            this.panel_Result.PerformLayout();
            this.tabPage_About.ResumeLayout(false);
            this.panel_CodeCreator.ResumeLayout(false);
            this.panel_CodeCreator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CodeCreator)).EndInit();
            this.panel_DesignCreator.ResumeLayout(false);
            this.panel_DesignCreator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DesignCreator)).EndInit();
            this.panel_DatabaseCreator.ResumeLayout(false);
            this.panel_DatabaseCreator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DatabaseCreator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.PictureBox pictureBox_Add;
        private System.Windows.Forms.PictureBox pictureBox_About;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Search;
        private System.Windows.Forms.TabPage tabPage_Add;
        private System.Windows.Forms.TabPage tabPage_About;
        private System.Windows.Forms.Label label_DesignCreator;
        private System.Windows.Forms.Label label_CodeCreator;
        private System.Windows.Forms.Label label_DatabaseCreator;
        private System.Windows.Forms.Panel panel_DatabaseCreator;
        private System.Windows.Forms.Panel panel_CodeCreator;
        private System.Windows.Forms.Panel panel_DesignCreator;
        private System.Windows.Forms.Label label_DatabaseCreatorName;
        private System.Windows.Forms.Label label_CodeCreatorName;
        private System.Windows.Forms.Label label_DesignCreatorName;
        private System.Windows.Forms.PictureBox pictureBox_CodeCreator;
        private System.Windows.Forms.PictureBox pictureBox_DesignCreator;
        private System.Windows.Forms.PictureBox pictureBox_DatabaseCreator;
        private System.Windows.Forms.DataGridView dataGridView_Search;
        private System.Windows.Forms.Panel panel_Search_Top;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Panel panel_Add_DragAndDrop;
        private System.Windows.Forms.Panel panel_Result;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn screen;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolution_width;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolution_height;
        private System.Windows.Forms.DataGridViewTextBoxColumn os;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu_cores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn ram_freq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ram_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn drive;
        private System.Windows.Forms.DataGridViewTextBoxColumn drive_capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn inconsistent;
        private System.Windows.Forms.Label label_NumberOfAdded;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Bunifu.Framework.UI.BunifuDropdown topSearch;
        private Bunifu.Framework.UI.BunifuFlatButton customFilter;
    }
}

