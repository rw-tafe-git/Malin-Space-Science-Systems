using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dictionary
{
    public partial class FormGeneral : Form
    {
		// Student Riley, id 30002737, Date: 09/10/2023
        // Assessment Task 3

        /// <summary>
        /// Sorted Dictionary General Form
        /// </summary>
		
        public FormGeneral()
        {
            InitializeComponent();
        }

        // Create trace listener and stopwatch
        TextWriterTraceListener traceListener = new TextWriterTraceListener(File.Create("TraceFile.txt"));
        Stopwatch stopWatch;

        // 6.1.	Create a SortedDictionary data structure with a TKey of type integer and a TValue of type string, name the new data structure “MasterFile”.
        public static SortedDictionary<int, string> MasterFile = new SortedDictionary<int, string>();

        // 6.2.	Create a method that will read the data from the .csv file into the SortedDictionary data structure when the GUI loads.
        private void FormGeneral_Load(object sender, EventArgs e)
        {
            Trace.Listeners.Add(traceListener);
            stopWatch = new Stopwatch();

            LoadDictionaryData();
            DisplayDictionaryData();
        }

        private void LoadDictionaryData()
        {
            MasterFile.Clear();
            string filePath = "MalinStaffNamesV2.csv";

            stopWatch.Restart();

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] splitLine = line.Split(',');
                int staffID = int.Parse(splitLine[0]);
                string staffName = splitLine[1];
                MasterFile.Add(staffID, staffName);
            }

            stopWatch.Stop();

            Trace.WriteLine("LoadDictionaryData: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
            Trace.Flush();
        }

        // 6.3.	Create a method to display the SortedDictionary data into a non-selectable display only list box (ie read only).
        private void DisplayDictionaryData()
        {
            ListBoxDictionary.Items.Clear();

            foreach(var staffData in MasterFile)
            {
                ListBoxDictionary.Items.Add(staffData);
            }
        }

        // 6.4.	Create a method to filter the Staff Name data from the SortedDictionary into a second filtered and selectable list box. This method must use a text box input and update as each character is entered. The list box must reflect the filtered data in real time.
        private void InputStaffName_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxFiltered.Focused)
                return;

            try
            {
                stopWatch.Restart();

                /*ListBoxFiltered.Items.Clear();
                foreach (var kvp in MasterFile)
                {
                    if (kvp.Key.ToString().StartsWith(InputStaffName.Text))
                    {
                        ListBoxFiltered.Items.Add("[" + kvp.Key + ", " + kvp.Value + "]");
                    }
                }*/

                string staffNameTextBox = InputStaffName.Text.ToLower();
                var filteredList = MasterFile.Where(kvp => kvp.Value.ToLower().Contains(staffNameTextBox)).ToList();
                ListBoxFiltered.DataSource = filteredList;

                stopWatch.Stop();

                Trace.WriteLine("InputStaffName_TextChanged: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
                Trace.Flush();
            }
            catch
            {

            }
        }

        // 6.5.	Create a method to filter the Staff ID data from the SortedDictionary into the second filtered and selectable list box. This method must use a text box input and update as each number is entered. The list box must reflect the filtered data in real time.
        private void InputStaffKey_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxFiltered.Focused)
                return;

            try
            {
                stopWatch.Restart();

                /*ListBoxFiltered.Items.Clear();
                foreach (var kvp in MasterFile)
                {
                    if (kvp.Key.ToString().StartsWith(InputStaffKey.Text))
                    {
                        ListBoxFiltered.Items.Add("[" + kvp.Key + ", " + kvp.Value + "]");
                    }
                }*/

                string staffIDTextBox = InputStaffKey.Text;
                var filteredList = MasterFile.Where(kvp => kvp.Key.ToString().Contains(staffIDTextBox)).ToList();
                ListBoxFiltered.DataSource = filteredList;

                stopWatch.Stop();

                Trace.WriteLine("InputStaffKey_TextChanged: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
                Trace.Flush();
            }
            catch
            {

            }
        }

        // 6.6.	Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box. Utilise a keyboard shortcut.
        private void ClearStaffName()
        {
            InputStaffName.Text = string.Empty;
            InputStaffName.Focus();
        }

        // 6.7.	Create a method for the Staff ID text box which will clear the contents and place the focus into the text box. Utilise a keyboard shortcut.
        private void ClearStaffKey()
        {
            InputStaffKey.Text = string.Empty;
            InputStaffKey.Focus();
        }

        // 6.8.	Create a method for the filtered and selectable list box which will populate the two text boxes when a staff record is selected. Utilise the Tab and keyboard keys.
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox currentListBox;
            currentListBox = (ListBox)sender;

            if (!currentListBox.Focused)
                return;

            if (currentListBox.SelectedItem != null)
            {
                string line = currentListBox.SelectedItem.ToString();
                string[] splitLine = line.Split(',');
                string staffID = splitLine[0].TrimStart('[');
                string staffName = splitLine[1].TrimEnd(']').TrimStart(' ');
                InputStaffKey.Text = staffID;
                InputStaffName.Text = staffName;
            }
        }

        private void ListBox_EnterFocus(object sender, EventArgs e)
        {
            ListBox currentListBox;
            currentListBox = (ListBox)sender;

            if (currentListBox.SelectedItem != null)
            {
                string line = currentListBox.SelectedItem.ToString();
                string[] splitLine = line.Split(',');
                string staffID = splitLine[0].TrimStart('[');
                string staffName = splitLine[1].TrimEnd(']').TrimStart(' ');
                currentListBox.Focus();
                InputStaffKey.Text = staffID;
                InputStaffName.Text = staffName;
            }
        }

        // 6.9.	Create a method that will open the Admin GUI when the Alt + A keys are pressed. Ensure the General GUI sends the currently selected Staff ID and Staff Name to the Admin GUI for Update and Delete purposes and is opened as modal. Create modified logic to open the Admin GUI to Create a new user when the Staff ID 77 and the Staff Name is empty. Read the appropriate criteria in the Admin GUI for further information.
        private void OpenAdminGUI()
        {
            FormAdmin formAdmin = new FormAdmin(InputStaffKey.Text, InputStaffName.Text);
            formAdmin.Show();
            formAdmin.TopMost = true;
            formAdmin.Activate();
        }

        private void GeneralForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.A)
            {
                OpenAdminGUI();
				
				e.Handled = true;
				e.SuppressKeyPress = true;
            }
            if (e.Alt && e.KeyCode == Keys.K)
            {
                ClearStaffKey();
				
				e.Handled = true;
				e.SuppressKeyPress = true;
            }
            if (e.Alt && e.KeyCode == Keys.V)
            {
                ClearStaffName();
				
				e.Handled = true;
				e.SuppressKeyPress = true;
            }
            if (e.Alt && e.KeyCode == Keys.Q)
            {
                Application.Exit();
				
				e.Handled = true;
				e.SuppressKeyPress = true;
            }
        }

        private void InputStaffKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/

            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b]"))
            {
                e.Handled = true;
            }
        }

        private void InputStaffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }
    }
}
