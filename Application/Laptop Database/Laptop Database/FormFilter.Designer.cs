namespace Laptop_Database
{
    partial class FormFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilter));
            this.labelRam = new System.Windows.Forms.Label();
            this.labelRamTo = new System.Windows.Forms.Label();
            this.filterRam = new Bunifu.Framework.UI.BunifuSlider();
            this.labelWeight = new System.Windows.Forms.Label();
            this.filterWeight = new Bunifu.Framework.UI.BunifuRange();
            this.labelWeightTo = new System.Windows.Forms.Label();
            this.labelWeightFrom = new System.Windows.Forms.Label();
            this.labelRamFrom = new System.Windows.Forms.Label();
            this.labelWidthFrom = new System.Windows.Forms.Label();
            this.filterWidth = new Bunifu.Framework.UI.BunifuSlider();
            this.labelWidthTo = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeightFrom = new System.Windows.Forms.Label();
            this.filterHeight = new Bunifu.Framework.UI.BunifuSlider();
            this.labelHeightTo = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelDepthFrom = new System.Windows.Forms.Label();
            this.filterDepth = new Bunifu.Framework.UI.BunifuSlider();
            this.labelDepthTo = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelCpu = new System.Windows.Forms.Label();
            this.labelInconsistent = new System.Windows.Forms.Label();
            this.filterComboBoxResolution = new System.Windows.Forms.ComboBox();
            this.filterComboBoxCpu = new System.Windows.Forms.ComboBox();
            this.filterCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.filterButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.BackColor = System.Drawing.Color.Transparent;
            this.labelRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRam.ForeColor = System.Drawing.Color.White;
            this.labelRam.Location = new System.Drawing.Point(25, 29);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(41, 16);
            this.labelRam.TabIndex = 2;
            this.labelRam.Text = "RAM";
            // 
            // labelRamTo
            // 
            this.labelRamTo.AutoSize = true;
            this.labelRamTo.BackColor = System.Drawing.Color.Transparent;
            this.labelRamTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRamTo.ForeColor = System.Drawing.Color.White;
            this.labelRamTo.Location = new System.Drawing.Point(540, 29);
            this.labelRamTo.Name = "labelRamTo";
            this.labelRamTo.Size = new System.Drawing.Size(44, 16);
            this.labelRamTo.TabIndex = 4;
            this.labelRamTo.Text = "16 GB";
            // 
            // filterRam
            // 
            this.filterRam.BackColor = System.Drawing.Color.Transparent;
            this.filterRam.BackgroudColor = System.Drawing.Color.DarkGray;
            this.filterRam.BorderRadius = 0;
            this.filterRam.IndicatorColor = System.Drawing.Color.PaleTurquoise;
            this.filterRam.Location = new System.Drawing.Point(180, 25);
            this.filterRam.MaximumValue = 100;
            this.filterRam.Name = "filterRam";
            this.filterRam.Size = new System.Drawing.Size(334, 30);
            this.filterRam.TabIndex = 7;
            this.filterRam.Value = 100;
            this.filterRam.ValueChanged += new System.EventHandler(this.FilterRam_ValueChanged);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.BackColor = System.Drawing.Color.Transparent;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeight.ForeColor = System.Drawing.Color.White;
            this.labelWeight.Location = new System.Drawing.Point(25, 65);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(56, 16);
            this.labelWeight.TabIndex = 8;
            this.labelWeight.Text = "Weight";
            // 
            // filterWeight
            // 
            this.filterWeight.BackColor = System.Drawing.Color.Transparent;
            this.filterWeight.BackgroudColor = System.Drawing.Color.DarkGray;
            this.filterWeight.BorderRadius = 0;
            this.filterWeight.IndicatorColor = System.Drawing.Color.PaleTurquoise;
            this.filterWeight.Location = new System.Drawing.Point(180, 61);
            this.filterWeight.MaximumRange = 100;
            this.filterWeight.Name = "filterWeight";
            this.filterWeight.RangeMax = 49;
            this.filterWeight.RangeMin = 0;
            this.filterWeight.Size = new System.Drawing.Size(334, 30);
            this.filterWeight.TabIndex = 10;
            this.filterWeight.RangeChanged += new System.EventHandler(this.FilterWeight_RangeChanged);
            // 
            // labelWeightTo
            // 
            this.labelWeightTo.AutoSize = true;
            this.labelWeightTo.BackColor = System.Drawing.Color.Transparent;
            this.labelWeightTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeightTo.ForeColor = System.Drawing.Color.White;
            this.labelWeightTo.Location = new System.Drawing.Point(540, 65);
            this.labelWeightTo.Name = "labelWeightTo";
            this.labelWeightTo.Size = new System.Drawing.Size(34, 16);
            this.labelWeightTo.TabIndex = 12;
            this.labelWeightTo.Text = "5 Kg";
            // 
            // labelWeightFrom
            // 
            this.labelWeightFrom.AutoSize = true;
            this.labelWeightFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelWeightFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeightFrom.ForeColor = System.Drawing.Color.White;
            this.labelWeightFrom.Location = new System.Drawing.Point(125, 65);
            this.labelWeightFrom.Name = "labelWeightFrom";
            this.labelWeightFrom.Size = new System.Drawing.Size(34, 16);
            this.labelWeightFrom.TabIndex = 13;
            this.labelWeightFrom.Text = "0 Kg";
            // 
            // labelRamFrom
            // 
            this.labelRamFrom.AutoSize = true;
            this.labelRamFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelRamFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRamFrom.ForeColor = System.Drawing.Color.White;
            this.labelRamFrom.Location = new System.Drawing.Point(125, 29);
            this.labelRamFrom.Name = "labelRamFrom";
            this.labelRamFrom.Size = new System.Drawing.Size(37, 16);
            this.labelRamFrom.TabIndex = 14;
            this.labelRamFrom.Text = "0 GB";
            // 
            // labelWidthFrom
            // 
            this.labelWidthFrom.AutoSize = true;
            this.labelWidthFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelWidthFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWidthFrom.ForeColor = System.Drawing.Color.White;
            this.labelWidthFrom.Location = new System.Drawing.Point(125, 101);
            this.labelWidthFrom.Name = "labelWidthFrom";
            this.labelWidthFrom.Size = new System.Drawing.Size(36, 16);
            this.labelWidthFrom.TabIndex = 18;
            this.labelWidthFrom.Text = "0 cm";
            // 
            // filterWidth
            // 
            this.filterWidth.BackColor = System.Drawing.Color.Transparent;
            this.filterWidth.BackgroudColor = System.Drawing.Color.DarkGray;
            this.filterWidth.BorderRadius = 0;
            this.filterWidth.IndicatorColor = System.Drawing.Color.PaleTurquoise;
            this.filterWidth.Location = new System.Drawing.Point(180, 97);
            this.filterWidth.MaximumValue = 100;
            this.filterWidth.Name = "filterWidth";
            this.filterWidth.Size = new System.Drawing.Size(334, 30);
            this.filterWidth.TabIndex = 17;
            this.filterWidth.Value = 100;
            this.filterWidth.ValueChanged += new System.EventHandler(this.FilterWidth_ValueChanged);
            // 
            // labelWidthTo
            // 
            this.labelWidthTo.AutoSize = true;
            this.labelWidthTo.BackColor = System.Drawing.Color.Transparent;
            this.labelWidthTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWidthTo.ForeColor = System.Drawing.Color.White;
            this.labelWidthTo.Location = new System.Drawing.Point(540, 101);
            this.labelWidthTo.Name = "labelWidthTo";
            this.labelWidthTo.Size = new System.Drawing.Size(43, 16);
            this.labelWidthTo.TabIndex = 16;
            this.labelWidthTo.Text = "30 cm";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.BackColor = System.Drawing.Color.Transparent;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWidth.ForeColor = System.Drawing.Color.White;
            this.labelWidth.Location = new System.Drawing.Point(25, 101);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(47, 16);
            this.labelWidth.TabIndex = 15;
            this.labelWidth.Text = "Width";
            // 
            // labelHeightFrom
            // 
            this.labelHeightFrom.AutoSize = true;
            this.labelHeightFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelHeightFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeightFrom.ForeColor = System.Drawing.Color.White;
            this.labelHeightFrom.Location = new System.Drawing.Point(125, 137);
            this.labelHeightFrom.Name = "labelHeightFrom";
            this.labelHeightFrom.Size = new System.Drawing.Size(36, 16);
            this.labelHeightFrom.TabIndex = 22;
            this.labelHeightFrom.Text = "0 cm";
            // 
            // filterHeight
            // 
            this.filterHeight.BackColor = System.Drawing.Color.Transparent;
            this.filterHeight.BackgroudColor = System.Drawing.Color.DarkGray;
            this.filterHeight.BorderRadius = 0;
            this.filterHeight.IndicatorColor = System.Drawing.Color.PaleTurquoise;
            this.filterHeight.Location = new System.Drawing.Point(180, 133);
            this.filterHeight.MaximumValue = 100;
            this.filterHeight.Name = "filterHeight";
            this.filterHeight.Size = new System.Drawing.Size(334, 30);
            this.filterHeight.TabIndex = 21;
            this.filterHeight.Value = 100;
            this.filterHeight.ValueChanged += new System.EventHandler(this.FilterHeight_ValueChanged);
            // 
            // labelHeightTo
            // 
            this.labelHeightTo.AutoSize = true;
            this.labelHeightTo.BackColor = System.Drawing.Color.Transparent;
            this.labelHeightTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeightTo.ForeColor = System.Drawing.Color.White;
            this.labelHeightTo.Location = new System.Drawing.Point(540, 137);
            this.labelHeightTo.Name = "labelHeightTo";
            this.labelHeightTo.Size = new System.Drawing.Size(43, 16);
            this.labelHeightTo.TabIndex = 20;
            this.labelHeightTo.Text = "25 cm";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.BackColor = System.Drawing.Color.Transparent;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeight.ForeColor = System.Drawing.Color.White;
            this.labelHeight.Location = new System.Drawing.Point(25, 137);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(53, 16);
            this.labelHeight.TabIndex = 19;
            this.labelHeight.Text = "Height";
            // 
            // labelDepthFrom
            // 
            this.labelDepthFrom.AutoSize = true;
            this.labelDepthFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelDepthFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDepthFrom.ForeColor = System.Drawing.Color.White;
            this.labelDepthFrom.Location = new System.Drawing.Point(125, 173);
            this.labelDepthFrom.Name = "labelDepthFrom";
            this.labelDepthFrom.Size = new System.Drawing.Size(36, 16);
            this.labelDepthFrom.TabIndex = 26;
            this.labelDepthFrom.Text = "0 cm";
            // 
            // filterDepth
            // 
            this.filterDepth.BackColor = System.Drawing.Color.Transparent;
            this.filterDepth.BackgroudColor = System.Drawing.Color.DarkGray;
            this.filterDepth.BorderRadius = 0;
            this.filterDepth.IndicatorColor = System.Drawing.Color.PaleTurquoise;
            this.filterDepth.Location = new System.Drawing.Point(180, 169);
            this.filterDepth.MaximumValue = 100;
            this.filterDepth.Name = "filterDepth";
            this.filterDepth.Size = new System.Drawing.Size(334, 30);
            this.filterDepth.TabIndex = 25;
            this.filterDepth.Value = 100;
            this.filterDepth.ValueChanged += new System.EventHandler(this.FilterDepth_ValueChanged);
            // 
            // labelDepthTo
            // 
            this.labelDepthTo.AutoSize = true;
            this.labelDepthTo.BackColor = System.Drawing.Color.Transparent;
            this.labelDepthTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDepthTo.ForeColor = System.Drawing.Color.White;
            this.labelDepthTo.Location = new System.Drawing.Point(540, 173);
            this.labelDepthTo.Name = "labelDepthTo";
            this.labelDepthTo.Size = new System.Drawing.Size(36, 16);
            this.labelDepthTo.TabIndex = 24;
            this.labelDepthTo.Text = "5 cm";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.BackColor = System.Drawing.Color.Transparent;
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDepth.ForeColor = System.Drawing.Color.White;
            this.labelDepth.Location = new System.Drawing.Point(25, 173);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(49, 16);
            this.labelDepth.TabIndex = 23;
            this.labelDepth.Text = "Depth";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.BackColor = System.Drawing.Color.Transparent;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResolution.ForeColor = System.Drawing.Color.White;
            this.labelResolution.Location = new System.Drawing.Point(25, 209);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(82, 16);
            this.labelResolution.TabIndex = 27;
            this.labelResolution.Text = "Resolution";
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.BackColor = System.Drawing.Color.Transparent;
            this.labelCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCpu.ForeColor = System.Drawing.Color.White;
            this.labelCpu.Location = new System.Drawing.Point(25, 245);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(39, 16);
            this.labelCpu.TabIndex = 31;
            this.labelCpu.Text = "CPU";
            // 
            // labelInconsistent
            // 
            this.labelInconsistent.AutoSize = true;
            this.labelInconsistent.BackColor = System.Drawing.Color.Transparent;
            this.labelInconsistent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInconsistent.ForeColor = System.Drawing.Color.White;
            this.labelInconsistent.Location = new System.Drawing.Point(25, 281);
            this.labelInconsistent.Name = "labelInconsistent";
            this.labelInconsistent.Size = new System.Drawing.Size(90, 16);
            this.labelInconsistent.TabIndex = 35;
            this.labelInconsistent.Text = "Inconsistent";
            // 
            // filterComboBoxResolution
            // 
            this.filterComboBoxResolution.FormattingEnabled = true;
            this.filterComboBoxResolution.Location = new System.Drawing.Point(180, 205);
            this.filterComboBoxResolution.Name = "filterComboBoxResolution";
            this.filterComboBoxResolution.Size = new System.Drawing.Size(334, 21);
            this.filterComboBoxResolution.TabIndex = 36;
            // 
            // filterComboBoxCpu
            // 
            this.filterComboBoxCpu.FormattingEnabled = true;
            this.filterComboBoxCpu.Location = new System.Drawing.Point(180, 244);
            this.filterComboBoxCpu.Name = "filterComboBoxCpu";
            this.filterComboBoxCpu.Size = new System.Drawing.Size(334, 21);
            this.filterComboBoxCpu.TabIndex = 37;
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.filterCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.filterCheckBox.Checked = true;
            this.filterCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.filterCheckBox.ForeColor = System.Drawing.Color.White;
            this.filterCheckBox.Location = new System.Drawing.Point(180, 280);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(20, 20);
            this.filterCheckBox.TabIndex = 38;
            // 
            // filterButton
            // 
            this.filterButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.filterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filterButton.BorderRadius = 0;
            this.filterButton.ButtonText = "Use filter";
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.DisabledColor = System.Drawing.Color.Gray;
            this.filterButton.Iconcolor = System.Drawing.Color.Transparent;
            this.filterButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("filterButton.Iconimage")));
            this.filterButton.Iconimage_right = null;
            this.filterButton.Iconimage_right_Selected = null;
            this.filterButton.Iconimage_Selected = null;
            this.filterButton.IconMarginLeft = 0;
            this.filterButton.IconMarginRight = 0;
            this.filterButton.IconRightVisible = true;
            this.filterButton.IconRightZoom = 0D;
            this.filterButton.IconVisible = true;
            this.filterButton.IconZoom = 90D;
            this.filterButton.IsTab = false;
            this.filterButton.Location = new System.Drawing.Point(28, 315);
            this.filterButton.Name = "filterButton";
            this.filterButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.filterButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.filterButton.OnHoverTextColor = System.Drawing.Color.White;
            this.filterButton.selected = false;
            this.filterButton.Size = new System.Drawing.Size(555, 48);
            this.filterButton.TabIndex = 39;
            this.filterButton.Text = "Use filter";
            this.filterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterButton.Textcolor = System.Drawing.Color.White;
            this.filterButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laptop_Database.Properties.Resources.CodeTranslation;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 381);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filterCheckBox);
            this.Controls.Add(this.filterComboBoxCpu);
            this.Controls.Add(this.filterComboBoxResolution);
            this.Controls.Add(this.labelInconsistent);
            this.Controls.Add(this.labelCpu);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelDepthFrom);
            this.Controls.Add(this.filterDepth);
            this.Controls.Add(this.labelDepthTo);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelHeightFrom);
            this.Controls.Add(this.filterHeight);
            this.Controls.Add(this.labelHeightTo);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidthFrom);
            this.Controls.Add(this.filterWidth);
            this.Controls.Add(this.labelWidthTo);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelRamFrom);
            this.Controls.Add(this.labelWeightFrom);
            this.Controls.Add(this.labelWeightTo);
            this.Controls.Add(this.filterWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.filterRam);
            this.Controls.Add(this.labelRamTo);
            this.Controls.Add(this.labelRam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filters";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFilter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelRamTo;
        private Bunifu.Framework.UI.BunifuSlider filterRam;
        private System.Windows.Forms.Label labelWeight;
        private Bunifu.Framework.UI.BunifuRange filterWeight;
        private System.Windows.Forms.Label labelWeightTo;
        private System.Windows.Forms.Label labelWeightFrom;
        private System.Windows.Forms.Label labelRamFrom;
        private System.Windows.Forms.Label labelWidthFrom;
        private Bunifu.Framework.UI.BunifuSlider filterWidth;
        private System.Windows.Forms.Label labelWidthTo;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeightFrom;
        private Bunifu.Framework.UI.BunifuSlider filterHeight;
        private System.Windows.Forms.Label labelHeightTo;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelDepthFrom;
        private Bunifu.Framework.UI.BunifuSlider filterDepth;
        private System.Windows.Forms.Label labelDepthTo;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.Label labelInconsistent;
        private System.Windows.Forms.ComboBox filterComboBoxResolution;
        private System.Windows.Forms.ComboBox filterComboBoxCpu;
        private Bunifu.Framework.UI.BunifuCheckbox filterCheckBox;
        private Bunifu.Framework.UI.BunifuFlatButton filterButton;
    }
}