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
        Stopwatch stopWatch;

        public FormAdmin(string id, string name)
        {
            InitializeComponent();

            PopulateForm(id, name);

            stopWatch = new Stopwatch();
        }

        // 5.2.	Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
        private void PopulateForm(string id, string name)
        {
            InputStaffIDKey.Text = id;
            InputStaffNameValue.Text = name;
        }

        // 5.3.	Create a method that will create a new Staff ID and input the staff name from the related text box.The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated. The new staff member must be added to the Dictionary data structure.
        private void CreateStaffRecord()
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

                    MessageBox.Show("New staff id added");
                }
                else
                {
                    MessageBox.Show("Failed to add new staff id");
                }
            }
            catch
            {
                MessageBox.Show("Failed to add new staff id");
            }

            stopWatch.Stop();

            Trace.WriteLine("CreateStaffRecord: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
            Trace.Flush();
        }

        // 5.4.	Create a method that will Update the name of the current Staff ID.
        private void UpdateStaffRecord()
        {
            stopWatch.Restart();

            try
            {
                if (FormGeneral.MasterFile.ContainsKey(int.Parse(InputStaffIDKey.Text)))
                {
                    int key = int.Parse(InputStaffIDKey.Text);
                    FormGeneral.MasterFile[key] = InputStaffNameValue.Text;
                    SaveDictionary();

                    MessageBox.Show("Staff record updated");
                }
                else
                {
                    MessageBox.Show("Failed to update staff record");
                }
            }
            catch
            {
                MessageBox.Show("Failed to update staff record");
            }

            stopWatch.Stop();

            Trace.WriteLine("UpdateStaffRecord: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
            Trace.Flush();
        }

        // 5.5.	Create a method that will Remove the current Staff ID and clear the text boxes.
        private void DeleteStaffRecord()
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

                    MessageBox.Show("Staff record deleted");
                }
                else
                {
                    MessageBox.Show("Failed to delete staff record");
                }
            }
            catch
            {
                MessageBox.Show("Failed to delete staff record");
            }

            stopWatch.Stop();

            Trace.WriteLine("DeleteStaffRecord: " + stopWatch.ElapsedMilliseconds + "ms, " + stopWatch.ElapsedTicks + " Ticks\n---------------------");
            Trace.Flush();
        }

        // 5.6.	Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
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

        // 5.7.	Create a method that will close the Admin GUI when the Alt + L keys are pressed.*/
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
