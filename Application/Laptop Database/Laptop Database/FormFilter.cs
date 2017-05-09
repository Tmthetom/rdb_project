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

        int maxRam;
        int maxWeight;
        int maxWidth;
        int maxHeight;
        int maxDepth;
        int maxResolutionWidth;
        int maxResolutionHeight;
        List<string> cpus = new List<string>();


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
            // Load values for filters
            Dictionary<string, int> dict = formMain.connector.getMaxValues();

            maxRam = dict["ram_size"];
            maxWeight = dict["weight"];
            maxWidth = dict["width"];
            maxHeight = dict["height"];
            maxDepth = dict["depth"];
            maxResolutionWidth = dict["display_width"];
            maxResolutionHeight = dict["display_height"];

            cpus = formMain.connector.getDistinctValues()["cpu_type"];

            // RAM
            filterRam.MaximumValue = maxRam;

            // Weight
            filterWeight.MaximumRange = maxWeight;

            // Width
            filterWidth.MaximumValue = maxWidth;

            // Height
            filterHeight.MaximumValue = maxHeight;

            // Depth
            filterDepth.MaximumValue = maxDepth;

            // Resolution width
            filterResolutionWidth.MaximumValue = maxResolutionWidth;

            // Resolution height
            filterResolutionHeight.MaximumValue = maxResolutionHeight;

            // CPU
            foreach (String cpu in cpus)
                filterComboBoxCpu.Items.Add(cpu);

            if (formMain.currentFilter == null) {
                ResetFilter();
            }
            else {
                LoadFilter();
            }
        }

        private void ResetFilter() {
            // RAM
            filterRam.Value = filterRam.MaximumValue;

            // Weight
            filterWeight.RangeMax = filterWeight.MaximumRange;
            filterWeight.RangeMin = 0;

            // Width
            filterWidth.Value = filterWidth.MaximumValue;

            // Height
            filterHeight.Value = filterHeight.MaximumValue;

            // Depth
            filterDepth.Value = filterDepth.MaximumValue;

            // Resolution width
            filterResolutionWidth.Value = filterResolutionWidth.MaximumValue;

            // Resolution height
            filterResolutionHeight.Value = filterResolutionHeight.MaximumValue;

            // CPU
            filterComboBoxCpu.SelectedIndex = 0;

            // Inconsistent
            filterCheckBox.Checked = false;

            LoadText();
        }

        private void LoadFilter()
        {
            DatabaseFilter filter = formMain.currentFilter;

            // RAM
            filterRam.Value = (filter.ram.HasValue) ? (int)filter.ram : filterRam.MaximumValue;

            // Weight
            filterWeight.RangeMin = (filter.weightLower.HasValue) ? (int)filter.weightLower : 0;
            filterWeight.RangeMax = (filter.weightUpper.HasValue) ? (int)filter.weightUpper : filterWeight.MaximumRange;

            // Width
            filterWidth.Value = (filter.width.HasValue) ? (int)filter.width : filterWidth.MaximumValue;

            // Height
            filterHeight.Value = (filter.height.HasValue) ? (int)filter.height : filterHeight.MaximumValue;

            // Depth
            filterDepth.Value = (filter.depth.HasValue) ? (int)filter.depth : filterDepth.MaximumValue;

            // Resolution width
            filterResolutionWidth.Value = (filter.resolutionWidth.HasValue) ? (int)filter.resolutionWidth : filterResolutionWidth.MaximumValue;

            // Resolution height
            filterResolutionHeight.Value = (filter.resolutionHeight.HasValue) ? (int)filter.resolutionHeight : filterResolutionHeight.MaximumValue;

            // CPU
            filterComboBoxCpu.SelectedIndex = (!String.IsNullOrEmpty(filter.cpu)) ? cpus.IndexOf(filter.cpu) : 0;

            // Inconsistent
            filterCheckBox.Checked = filter.inconsistent;

            LoadText();
        }

        private void LoadText()
        {
            // RAM
            labelRamTo.Text = filterRam.Value.ToString() + " " + ramUnit;

            // Weight
            labelWeightFrom.Text = filterWeight.RangeMin.ToString() + " " + weightUnit;
            labelWeightTo.Text = filterWeight.RangeMax.ToString() + " " + weightUnit;

            // Width
            labelWidthTo.Text = filterWidth.Value.ToString() + " " + sizeUnit;

            // Height
            labelHeightTo.Text = filterHeight.Value.ToString() + " " + sizeUnit;

            // Depth
            labelDepthTo.Text = filterDepth.Value.ToString() + " " + sizeUnit;

            // Resolution width
            labelResolutionWidthTo.Text = filterResolutionWidth.Value.ToString() + " " + resolutionUnit;

            // Resolution height
            labelResolutionHeightTo.Text = filterResolutionHeight.Value.ToString() + " " + resolutionUnit;
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

        /// <summary>
        /// Reset all values into default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetFilter();
        }

        #endregion Autocalled functions (Dont need to change)

    }
}
