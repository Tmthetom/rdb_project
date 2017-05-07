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
        public FormFilter()
        {
            InitializeComponent();
            InitializeValues();
        }

        /// <summary>
        /// Load values into filters
        /// </summary>
        private void InitializeValues()
        {
            // Some example data
            int maxRam = 16;
            int maxWeight = 5;
            int maxWidth = 30;
            int maxHeight = 25;
            int maxDepth = 5;
            List<String> resolutions = new List<string> { "" };
            List<String> cpus = new List<string> { "" };

            // RAM
            filterRam.MaximumValue = maxRam;
            filterRam.Value = filterRam.MaximumValue;

            // Weight
            filterWeight.MaximumRange = maxWeight;
            filterWeight.RangeMax = filterWeight.MaximumRange;
            filterWeight.RangeMin = 0;

            // Width
            filterWidth.MaximumValue = maxWidth;
            filterWidth.Value = filterWidth.MaximumValue;

            // Height
            filterHeight.MaximumValue = maxHeight;
            filterHeight.Value = filterHeight.MaximumValue;

            // Depth
            filterDepth.MaximumValue = maxDepth;
            filterDepth.Value = filterDepth.MaximumValue;

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
            this.Hide();
        }

        #region Autocalled functions (Dont need to change)

        private String ramUnit = "GB";
        private String weightUnit = "Kg";
        private String sizeUnit = "cm";

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
