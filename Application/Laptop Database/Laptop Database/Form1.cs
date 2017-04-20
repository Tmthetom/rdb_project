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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
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
        #endregion

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
        #endregion

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
        #endregion

        #region Buttons Click

        private void Buttons_Click()
        {
            pictureBox_Search.BackColor = color_Button_Normal;
            pictureBox_Add.BackColor = color_Button_Normal;
            pictureBox_About.BackColor = color_Button_Normal;
        }

        #endregion

        #endregion

        #endregion


    }
}
