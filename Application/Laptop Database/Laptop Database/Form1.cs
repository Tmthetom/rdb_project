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
    public partial class Form : System.Windows.Forms.Form
    {
        private List<Laptop> laptopList;

        public Form()
        {
            InitializeComponent();
            dataGridView_Search.AutoGenerateColumns = false;
        }

        void FileLoaded(string filePath)
        {
            String extension = filePath.Substring(filePath.LastIndexOf("."), filePath.Length-filePath.LastIndexOf("."));
            switch (extension)
            {
                case ".xml":
                    laptopList = DataParser.XML.Parse(filePath);
                    break;
                case ".json":
                    break;
                case ".csv":
                    laptopList = DataParser.CSV.Parse(filePath);
                    break;
                default:
                    break;
            }
            var source = new BindingSource();
            source.DataSource = laptopList;
            dataGridView_Search.DataSource = source;
        }

        #region User Interface

        #region Menu

        Color color_Button_Normal = SystemColors.Highlight;
        Color color_Button_Hover = SystemColors.HotTrack;
        Color color_Button_Actual = Color.CornflowerBlue;

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

        #endregion Menu

        #region Add

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
            panel_Add_DragAndDrop.BackColor = Color.GreenYellow;
        }


        /// <summary>
        /// When file leave panel without drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragAndDrop_DragLeave(object sender, EventArgs e)
        {
            panel_Add_DragAndDrop.BackColor = Color.Transparent;
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
            panel_Add_DragAndDrop.BackColor = Color.Transparent;
        }

        #endregion Add

        private void dataGridView_Search_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        #endregion

    }
}
