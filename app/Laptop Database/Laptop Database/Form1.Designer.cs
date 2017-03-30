namespace Laptop_Database
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_About = new System.Windows.Forms.PictureBox();
            this.pictureBox_Add = new System.Windows.Forms.PictureBox();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Search = new System.Windows.Forms.TabPage();
            this.tabPage_Add = new System.Windows.Forms.TabPage();
            this.tabPage_About = new System.Windows.Forms.TabPage();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Controls.Add(this.pictureBox_About);
            this.panel_menu.Controls.Add(this.pictureBox_Add);
            this.panel_menu.Controls.Add(this.pictureBox_Search);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(157, 439);
            this.panel_menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laptop_Database.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.tabPage_Search.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Search.Name = "tabPage_Search";
            this.tabPage_Search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Search.Size = new System.Drawing.Size(731, 446);
            this.tabPage_Search.TabIndex = 0;
            this.tabPage_Search.Text = "tabPage_Search";
            // 
            // tabPage_Add
            // 
            this.tabPage_Add.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Add.Name = "tabPage_Add";
            this.tabPage_Add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Add.Size = new System.Drawing.Size(556, 311);
            this.tabPage_Add.TabIndex = 1;
            this.tabPage_Add.Text = "tabPage_Add";
            this.tabPage_Add.UseVisualStyleBackColor = true;
            // 
            // tabPage_About
            // 
            this.tabPage_About.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_About.Location = new System.Drawing.Point(4, 22);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Size = new System.Drawing.Size(556, 311);
            this.tabPage_About.TabIndex = 2;
            this.tabPage_About.Text = "tabPage_About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 439);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Laptop Database";
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.PictureBox pictureBox_Add;
        private System.Windows.Forms.PictureBox pictureBox_About;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Search;
        private System.Windows.Forms.TabPage tabPage_Add;
        private System.Windows.Forms.TabPage tabPage_About;
    }
}

