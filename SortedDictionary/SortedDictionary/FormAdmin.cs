using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Dictionary
{
    public partial class FormAdmin : Form
    {
		// Student Riley, id 30002737, Date: 09/10/2023
        // Assessment Task 3

        /// <summary>
        /// Sorted Dictionary Admin Form
        /// </summary>
		
		public FormAdmin(string id, string name)
        {
            InitializeComponent();

            PopulateForm(id, name);

            stopWatch = new Stopwatch();
        }
		
		// Create stopwatch
        Stopwatch stopWatch;

        // 7.2.	Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
        private void PopulateForm(string id, string name)
        {
            InputStaffIDKey.Text = id;
            InputStaffNameValue.Text = name;
        }

        // 7.3.	Create a method that will create a new Staff ID and input the staff name from the related text box. The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated. The new staff member must be added to the SortedDictionary data structure.
        private void CreateStaffRecord()
        {
            var confirmResult = MessageBox.Show("Create new staff record?", "Confirm Create", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Random random = new Random();
                int newId;

                stopWatch.Restart();

                try
                {
                    do
                        newId = random.Next(770000000, 779999999);
                    while (FormGeneral.MasterFile.ContainsKey(newId));

                    if (!string.IsNullOrEmpty(InputStaffNameValue.Text))
                    {
                        FormGeneral.MasterFile.Add(newId, InputStaffNameValue.Text);
                        SaveDictionary();

                        InputStaffIDKey.Text = newId.ToString();

                        StatusStripLabel.Text = "New staff record added";
                    }
                    else
                    {
                        StatusStripLabel.Text = "Failed to add new staff record";
                    }
                }
                catch
                {
                    StatusStripLabel.Text = "Failed to add new staff record";
                }

                stopWatch.Stop();

                Trace.WriteLine("CreateStaffRecord: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
                Trace.Flush();
            }
        }

        // 7.4.	Create a method that will Update the name of the current Staff ID.
        private void UpdateStaffRecord()
        {
            var confirmResult = MessageBox.Show("Update current staff record?", "Confirm Update", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                stopWatch.Restart();

                try
                {
                    if (FormGeneral.MasterFile.ContainsKey(int.Parse(InputStaffIDKey.Text)))
                    {
                        int key = int.Parse(InputStaffIDKey.Text);
                        FormGeneral.MasterFile[key] = InputStaffNameValue.Text;
                        SaveDictionary();

                        StatusStripLabel.Text = "Staff record updated";
                    }
                    else
                    {
                        StatusStripLabel.Text = "Failed to update staff record";
                    }
                }
                catch
                {
                    StatusStripLabel.Text = "Failed to update staff record";
                }

                stopWatch.Stop();

                Trace.WriteLine("UpdateStaffRecord: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
                Trace.Flush();
            }
        }

        // 7.5.	Create a method that will Remove the current Staff ID and clear the text boxes.
        private void DeleteStaffRecord()
        {
            var confirmResult = MessageBox.Show("Delete current staff record?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                stopWatch.Restart();

                try
                {
                    if (FormGeneral.MasterFile.ContainsKey(int.Parse(InputStaffIDKey.Text)))
                    {
                        int key = int.Parse(InputStaffIDKey.Text);
                        FormGeneral.MasterFile.Remove(key);
                        SaveDictionary();

                        InputStaffIDKey.Text = string.Empty;
                        InputStaffNameValue.Text = string.Empty;

                        StatusStripLabel.Text = "Staff record deleted";
                    }
                    else
                    {
                        StatusStripLabel.Text = "Failed to delete staff record";
                    }
                }
                catch
                {
                    StatusStripLabel.Text = "Failed to delete staff record";
                }

                stopWatch.Stop();

                Trace.WriteLine("DeleteStaffRecord: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
                Trace.Flush();
            }
        }

        // 7.6.	Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
        private void SaveDictionary()
        {
            stopWatch.Restart();

            using (var writer = new StreamWriter("MalinStaffNamesV2.csv"))
            {
                foreach (var kvp in FormGeneral.MasterFile)
                {
                    writer.WriteLine(kvp.Key + "," + kvp.Value);
                }
            }

            stopWatch.Stop();

            Trace.WriteLine("SaveDictionary: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
            Trace.Flush();
        }

        // 7.7.	Create a method that will close the Admin GUI when the Alt + L keys are pressed.
        private void CloseAdminGUI()
        {
            this.Close();
        }

        private void FormAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                CreateStaffRecord();
				
				e.Handled = true;
				e.SuppressKeyPress = true;
            }
            if (e.Alt && e.KeyCode == Keys.U)
            {
                UpdateStaffRecord();
				
				e.Handled = true;
				e.SuppressKeyPress = true;
            }
            if (e.Alt && e.KeyCode == Keys.D)
            {
                DeleteStaffRecord();
				
				e.Handled = true;
				e.SuppressKeyPress = true;
            }
            if (e.Alt && e.KeyCode == Keys.L)
            {
                CloseAdminGUI();
				
				e.Handled = true;
				e.SuppressKeyPress = true;
            }
        }
    }
}
