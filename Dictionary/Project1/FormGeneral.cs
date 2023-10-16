﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Test
{
    public partial class FormGeneral : Form
    {
        public FormGeneral()
        {
            InitializeComponent();
        }

        // 4.1.	Create a Dictionary data structure with a TKey of type integer and a TValue of type string, name the new data structure “MasterFile”.
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();

        // 4.2.	Create a method that will read the data from the .csv file into the Dictionary data structure when the GUI loads.
        private void ReadData()
        {
            StreamReader reader = new StreamReader(File.OpenRead("MalinStaffNamesV2.csv"));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] separate = line.Split(',');
                string staffDetails = separate[0] + " " + separate[1];
                // Mobile number is a key and staff name (first and last is the value)

            }
        }

        // 4.3.	Create a method to display the Dictionary data into a non-selectable display only list box(ie read only).
        private void DisplayDictionaryData()
        {
            ListBoxDictionary.Items.Clear();


        }

        // 4.4.	Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box.This method must use a text box input and update as each character is entered.The list box must reflect the filtered data in real time.

        // 4.5.	Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box. This method must use a text box input and update as each number is entered.The list box must reflect the filtered data in real time.

        // 4.6.	Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box. Utilise a keyboard shortcut.

        // 4.7.	Create a method for the Staff ID text box which will clear the contents and place the focus into the text box. Utilise a keyboard shortcut.

        // 4.8.	Create a method for the filtered and selectable list box which will populate the two text boxes when a staff record is selected.Utilise the Tab and keyboard keys.

        // 4.9.	Create a method that will open the Admin GUI when the Alt + A keys are pressed. Ensure the General GUI sends the currently selected Staff ID and Staff Name to the Admin GUI for Update and Delete purposes and is opened as modal.Create modified logic to open the Admin GUI to Create a new user when the Staff ID 77 and the Staff Name is empty.Read the appropriate criteria in the Admin GUI for further information.

        // 4.10.	Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience. Make all methods private and ensure the Dictionary is static and public.

        private void GeneralForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.A)
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                formAdmin.TopMost = true;
                formAdmin.Activate();
            }
            /*if (e.Alt && e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }
            if (e.Alt && e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }
            if (e.Alt && e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }*/
            if (e.Alt && e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }
        }

        private void InputStaffKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            //Add regex here later
        }
    }
}
