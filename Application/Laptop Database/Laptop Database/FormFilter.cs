using Laptop_Database.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Database
{
    public partial class FormFilter : Form
    {
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
            List<String> resolutions = new List<string> { "" };
            List<String> cpus = new List<string> { "" };

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

            // Resolution
            foreach (String resolution in resolutions)
            {
                filterComboBoxResolution.Items.Add(resolution);
            }

            // CPU
            foreach (String cpu in cpus)
            {
                filterComboBoxCpu.Items.Add(cpu);
            }

            // Inconsistent
            filterCheckBox.Checked = false;
        }

        /// <summary>
        /// Called when button clicked
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

            //needs to be changed
            int? resolutionWidth = null;
            int? resolutionHeight = null;

            //filterComboBoxCpu.SelectedItem.ToString()
            String cpu = null;

            bool inconsistent = filterCheckBox.Checked;

            DatabaseFilter df = new DatabaseFilter(ram, weightLower, weightUpper,
                width, height, depth,
                resolutionWidth, resolutionHeight,
                cpu, inconsistent);

            formMain.currentFilter = df;
            formMain.filterList.Add(df);
            formMain.applyFilter();
            this.Hide();
        }

        #region Autocalled functions (Dont need to change)

        private String ramUnit = "GB";
        private String weightUnit = "Kg";
        private String sizeUnit = "mm";

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
