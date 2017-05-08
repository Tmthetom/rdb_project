using Laptop_Database.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Laptop_Database
{
    public partial class FormFilter : System.Windows.Forms.Form
    {

        #region Initialization (Components load, Filters values load)

        private FormMain formMain;

        public FormFilter(FormMain formMain)
        {
            this.formMain = formMain;
            InitializeComponent();
            InitializeValues();
        }

        /// <summary>
        /// Load values into filters
        /// </summary>
        private void InitializeValues()
        {
            // Some example data
            int maxRam = 64;
            int maxWeight = 5;
            int maxWidth = 500;
            int maxHeight = 60;
            int maxDepth = 400;
            int maxResolutionWidth = 4096;
            int maxResolutionHeight = 2160;
            List<string> cpus = formMain.laptopList.Select(laptop => laptop.cpu.type).Distinct().ToList();

            // RAM
            filterRam.MaximumValue = maxRam;
            filterRam.Value = filterRam.MaximumValue;
            labelRamTo.Text = filterRam.Value.ToString() + " " + ramUnit;

            // Weight
            filterWeight.MaximumRange = maxWeight;
            filterWeight.RangeMax = filterWeight.MaximumRange;
            filterWeight.RangeMin = 0;
            labelWeightFrom.Text = filterWeight.RangeMin.ToString() + " " + weightUnit;
            labelWeightTo.Text = filterWeight.RangeMax.ToString() + " " + weightUnit;

            // Width
            filterWidth.MaximumValue = maxWidth;
            filterWidth.Value = filterWidth.MaximumValue;
            labelWidthTo.Text = filterWidth.Value.ToString() + " " + sizeUnit;

            // Height
            filterHeight.MaximumValue = maxHeight;
            filterHeight.Value = filterHeight.MaximumValue;
            labelHeightTo.Text = filterHeight.Value.ToString() + " " + sizeUnit;

            // Depth
            filterDepth.MaximumValue = maxDepth;
            filterDepth.Value = filterDepth.MaximumValue;
            labelDepthTo.Text = filterDepth.Value.ToString() + " " + sizeUnit;

            // Resolution width
            filterResolutionWidth.MaximumValue = maxResolutionWidth;
            filterResolutionWidth.Value = filterResolutionWidth.MaximumValue;
            labelResolutionWidthTo.Text = filterResolutionWidth.Value.ToString() + " " + resolutionUnit;

            // Resolution height
            filterResolutionHeight.MaximumValue = maxResolutionHeight;
            filterResolutionHeight.Value = filterResolutionHeight.MaximumValue;
            labelResolutionHeightTo.Text = filterResolutionHeight.Value.ToString() + " " + resolutionUnit;

            // CPU
            foreach (String cpu in cpus)
            {
                filterComboBoxCpu.Items.Add(cpu);
            }

            // Inconsistent
            filterCheckBox.Checked = false;
        }

        #endregion Initialization

        #region Confirm button (Send filter to main form)

        /// <summary>
        /// Send filter to main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            int? ram = null;
            if (filterRam.Value != filterRam.MaximumValue)
                ram = filterRam.Value;

            int? weightLower = null;
            if (filterWeight.RangeMin != 0)
                weightLower = filterWeight.RangeMin;

            int? weightUpper = null;
            if (filterWeight.RangeMax != filterWeight.MaximumRange)
                weightUpper = filterWeight.RangeMax;

            int? width = null;
            if (filterWidth.Value != filterWidth.MaximumValue)
                width = filterWidth.Value;

            int? height = null;
            if (filterHeight.Value != filterHeight.MaximumValue)
                height = filterHeight.Value;

            int? depth = null;
            if (filterDepth.Value != filterDepth.MaximumValue)
                depth = filterDepth.Value;

            int? resolutionWidth = null;
            if (filterResolutionWidth.Value != filterResolutionWidth.MaximumValue)
                resolutionWidth = filterResolutionWidth.Value;

            int? resolutionHeight = null;
            if (filterResolutionHeight.Value != filterResolutionHeight.MaximumValue)
                resolutionHeight = filterResolutionHeight.Value;

            String cpu = null;
            if (!filterComboBoxCpu.SelectedItem.ToString().Equals("any"))
                cpu = filterComboBoxCpu.SelectedItem.ToString();

            bool inconsistent = filterCheckBox.Checked;

            DatabaseFilter df = new DatabaseFilter(ram, weightLower, weightUpper,
                width, height, depth,
                resolutionWidth, resolutionHeight,
                cpu, inconsistent);

            formMain.currentFilter = df;
            formMain.filterList.Add(df);
            formMain.ApplyFilter();
            this.Hide();
        }

        #endregion Filter button

        #region Autocalled functions (Redrawing values when changing filters)

        private String ramUnit = "GB";
        private String weightUnit = "kg";
        private String sizeUnit = "mm";
        private String resolutionUnit = "px";

        private void FilterRam_ValueChanged(object sender, EventArgs e)
        {
            labelRamTo.Text = filterRam.Value.ToString() + " " + ramUnit;
        }

        private void FilterWeight_RangeChanged(object sender, EventArgs e)
        {
            labelWeightFrom.Text = filterWeight.RangeMin.ToString() + " " + weightUnit;
            labelWeightTo.Text = filterWeight.RangeMax.ToString() + " " + weightUnit;
        }

        private void FilterWidth_ValueChanged(object sender, EventArgs e)
        {
            labelWidthTo.Text = filterWidth.Value.ToString() + " " + sizeUnit;
        }

        private void FilterHeight_ValueChanged(object sender, EventArgs e)
        {
            labelHeightTo.Text = filterHeight.Value.ToString() + " " + sizeUnit;
        }

        private void FilterDepth_ValueChanged(object sender, EventArgs e)
        {
            labelDepthTo.Text = filterDepth.Value.ToString() + " " + sizeUnit;
        }

        private void FilterResolutionWidth_ValueChanged(object sender, EventArgs e)
        {
            labelResolutionWidthTo.Text = filterResolutionWidth.Value.ToString() + " " + resolutionUnit;
        }

        private void FilterResolutionHeight_ValueChanged(object sender, EventArgs e)
        {
            labelResolutionHeightTo.Text = filterResolutionHeight.Value.ToString() + " " + resolutionUnit;
        }

        /// <summary>
        /// Called hwn form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFilter_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #endregion Autocalled functions (Dont need to change)
    }
}
