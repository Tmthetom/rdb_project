using Laptop_Database.Database;
using Laptop_Database.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Database
{
    public partial class FormMain : System.Windows.Forms.Form
    {

        #region Initialization (Components load)

        public DatabaseFilter currentFilter = null;
        public List<DatabaseFilter> filterList = new List<DatabaseFilter>();
        private List<Laptop> laptopList;
        private BindingList<Laptop> listBinding;

        public FormMain()
        {
            InitializeComponent();
            dataGridView_Search.AutoGenerateColumns = false;
        }

        #endregion Initialization (Components load)

        #region Search tab (Table, Filters)

        /// <summary>
        /// Called, when selected top filter changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopSearch_onItemSelected(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        /// <summary>
        /// Open new custom filte Form. Called, when custom filter button clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomFilter_Click(object sender, EventArgs e)
        {
            FormFilter formFilter = new FormFilter(this);
            formFilter.Show();
        }

        /// <summary>
        /// Use selected filter on dataGridView
        /// </summary>
        public void ApplyFilter()
        {
            if (currentFilter != null && laptopList != null)
            {
                var source = new BindingSource();
                listBinding = new BindingList<Laptop>(laptopList);

                if (currentFilter.ram != null)
                    listBinding = new BindingList<Laptop>(listBinding.Where(laptop => laptop.ram.size <= currentFilter.ram).ToList());

                if (currentFilter.weightLower != null)
                    listBinding = new BindingList<Laptop>(listBinding.Where(laptop => laptop.weight >= currentFilter.weightLower).ToList());

                if (currentFilter.weightUpper != null)
                    listBinding = new BindingList<Laptop>(listBinding.Where(laptop => laptop.weight <= currentFilter.weightUpper).ToList());

                if (currentFilter.width != null)
                    listBinding = new BindingList<Laptop>(listBinding.Where(laptop => laptop.width <= currentFilter.width).ToList());

                if (currentFilter.height != null)
                    listBinding = new BindingList<Laptop>(listBinding.Where(laptop => laptop.height <= currentFilter.height).ToList());

                if (currentFilter.depth != null)
                    listBinding = new BindingList<Laptop>(listBinding.Where(laptop => laptop.depth <= currentFilter.depth).ToList());

                if (currentFilter.resolutionWidth != null)
                    listBinding = new BindingList<Laptop>(listBinding.Where(laptop => laptop.display.width <= currentFilter.resolutionWidth).ToList());

                if (currentFilter.resolutionHeight != null)
                    listBinding = new BindingList<Laptop>(listBinding.Where(laptop => laptop.display.height <= currentFilter.resolutionHeight).ToList());

                if (currentFilter.cpu != null)
                    listBinding = new BindingList<Laptop>(listBinding.Where(laptop => laptop.cpu.type.Equals(currentFilter.cpu)).ToList());

                //inconsistent, not implemented
                //listBinding = new BindingList<Laptop>(listBinding);

                source.DataSource = listBinding;
                dataGridView_Search.DataSource = source;
            }
        }

        #endregion Search tab (Table, Filters)

        #region Import tab (Drag&Drop, OpenFileDialog)

        /// <summary>
        /// Called when new file loaded through DragAndDrop or OpenFile in Add (Menu)
        /// </summary>
        /// <param name="filePath"></param>
        void FileLoaded(string filePath)
        {
            String extension = filePath.Substring(filePath.LastIndexOf("."), filePath.Length - filePath.LastIndexOf("."));
            switch (extension)
            {
                case ".xml":
                    laptopList = DataParser.XML.Parse(filePath);
                    break;
                case ".json":
                    laptopList = DataParser.JSON.Parse(filePath);
                    break;
                case ".csv":
                    laptopList = DataParser.CSV.Parse(filePath);
                    break;
                default:
                    break;
            }
            listBinding = new BindingList<Laptop>(laptopList);

            var source = new BindingSource()
            {
                DataSource = listBinding
            };
            dataGridView_Search.DataSource = source;
        }

        /// <summary>
        /// When called, runs another thread with data import
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        /// <summary>
        /// Called, when another thread finished
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //ShowNumberOfAddedRows(numberOfNewRows);
        }

        #endregion Import tab (Drag&Drop, OpenFileDialog)

        #region User Interface (Animations, transitions, effects, formating, ...)

        #region Tabs (Main menu buttons and their hovers, clicks and more)

        private Color color_Button_Normal = SystemColors.Highlight;
        private Color color_Button_Hover = SystemColors.HotTrack;
        private Color color_Button_Actual = Color.SkyBlue;

        #region Search button
        private void Button_SearchHover(object sender, EventArgs e)
        {
            pictureBox_Search.BackColor = color_Button_Hover;
        }

        private void Button_SearchLeave(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                Buttons_Click();
                pictureBox_Search.BackColor = color_Button_Actual;
            }
            else
            {
                pictureBox_Search.BackColor = color_Button_Normal;
            }
        }

        private void Button_SearchClick(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            Buttons_Click();
            pictureBox_Search.BackColor = color_Button_Actual;
        }
        #endregion Search button

        #region Add button
        private void Button_AddHover(object sender, EventArgs e)
        {
            pictureBox_Add.BackColor = color_Button_Hover;
        }

        private void Button_AddLeave(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                Buttons_Click();
                pictureBox_Add.BackColor = color_Button_Actual;
            }
            else
            {
                pictureBox_Add.BackColor = color_Button_Normal;
            }
        }

        private void Button_AddClick(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            Buttons_Click();
            pictureBox_Add.BackColor = color_Button_Actual;
        }
        #endregion Add button

        #region About button
        private void Button_AboutHover(object sender, EventArgs e)
        {
            pictureBox_About.BackColor = color_Button_Hover;
        }

        private void Button_AboutLeave(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                Buttons_Click();
                pictureBox_About.BackColor = color_Button_Actual;
            }
            else
            {
                pictureBox_About.BackColor = color_Button_Normal;
            }
        }

        private void Button_AboutClick(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
            Buttons_Click();
            pictureBox_About.BackColor = color_Button_Actual;
        }
        #endregion About button

        #region Buttons Click

        private void Buttons_Click()
        {
            pictureBox_Search.BackColor = color_Button_Normal;
            pictureBox_Add.BackColor = color_Button_Normal;
            pictureBox_About.BackColor = color_Button_Normal;
        }

        #endregion Buttons Click

        #endregion Tabs (Main menu buttons and their hovers, clicks and more)

        #region Search tab (Coloring, Formating)

        #region Inconsistency (Coloring)

        private Color inconsistentRow = Color.FromArgb(245, 245, 245);
        private Color inconsistentCell = Color.FromArgb(220, 220, 220);

        /// <summary>
        /// When data binding complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_Search_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            foreach (DataGridViewRow dgvr in grid.Rows)
            {
                Laptop laptop = dgvr.DataBoundItem as Laptop;
                if (laptop != null)
                {
                    if (laptop.weight == 3)
                        dgvr.DefaultCellStyle.BackColor = inconsistentRow;
                }
            }
        }
        #endregion Inconsistency (Coloring)

        #region Cell formating
        /// <summary>
        /// Cell formating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_Search_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            {
                string[] props = col.DataPropertyName.Split('.');
                PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);
                object val = propInfo.GetValue(row.DataBoundItem, null);
                for (int i = 1; i < props.Length; i++)
                {
                    propInfo = val.GetType().GetProperty(props[i]);
                    val = propInfo.GetValue(val, null);
                }
                e.Value = val;
            }

        }
        #endregion Cell formating

        #endregion Search tab (Coloring, Formating)

        #region Add (Drag&Drop, AddedRows)

        private Color leaveColor = Color.Transparent;
        private Color dragColor = Color.SkyBlue;

        /// <summary>
        /// When panel clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragAndDrop_Click(object sender, EventArgs e)
        {
            // Show file dialog
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileLoaded(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// When file enter panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragAndDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;  // Enable DragAndDrop
            panel_Add_DragAndDrop.BackColor = dragColor;
        }


        /// <summary>
        /// When file leave panel without drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragAndDrop_DragLeave(object sender, EventArgs e)
        {
            panel_Add_DragAndDrop.BackColor = leaveColor;
        }

        /// <summary>
        /// When file drop into panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragAndDrop_DragDrop(object sender, DragEventArgs e)
        {
            // Save file path
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            openFileDialog.FileName = filePaths[0];
            FileLoaded(openFileDialog.FileName);
            panel_Add_DragAndDrop.BackColor = leaveColor;
        }

        /// <summary>
        /// Show number of added rows in Add tab, after data insert.
        /// </summary>
        /// <param name="rows">Number of new added rows</param>
        private void ShowNumberOfAddedRows(int rows)
        {
            if (rows >= 2)  // For two and more rows
            {
                label_NumberOfAdded.Text = "Added " + rows + " new rows.";
            }
            else if (rows == 1)  // For one row
            {
                label_NumberOfAdded.Text = "Added " + rows + " new row.";
            }
            else  // For zero rows
            {
                label_NumberOfAdded.Text = "No rows added (rows are same, or there are no rows).";
            }
        }

        #endregion Add (Drag&Drop, AddedRows)

        #endregion

    }
}
