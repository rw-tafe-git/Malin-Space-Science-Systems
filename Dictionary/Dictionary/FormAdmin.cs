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

namespace Test
{
    public partial class FormAdmin : Form
    {
        public FormAdmin(string id, string name)
        {
            InitializeComponent();

            PopulateForm(id, name);

            //saveClose.Width = statusStrip1.Length;
        }

        private void FormAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                
            }
            if (e.Alt && e.KeyCode == Keys.U)
            {
                
            }
            if (e.Alt && e.KeyCode == Keys.D)
            {
               DeleteStaffRecord();
            }
            if (e.Alt && e.KeyCode == Keys.L)
            {
                CloseAdminGUI();
            }
        }

        // 5.2.	Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
        private void PopulateForm(string id, string name)
        {
            InputStaffIDKey.Text = id;
            InputStaffNameValue.Text = name;
        }

        // 5.3.	Create a method that will create a new Staff ID and input the staff name from the related text box.The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated. The new staff member must be added to the Dictionary data structure.
        private void CreateStaffID()
        {
            
        }

        // 5.4.	Create a method that will Update the name of the current Staff ID.
        private void UpdateStaffName()
        {

        }

        // 5.5.	Create a method that will Remove the current Staff ID and clear the text boxes.
        private void DeleteStaffRecord()
        {
            int key = int.Parse(InputStaffIDKey.Text);
            FormGeneral.MasterFile.Remove(key);
            SaveDictionary();
        }

        // 5.6.	Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
        private void SaveDictionary()
        {
            using (var writer = new StreamWriter("@MalinStaffNamesV2.csv"))
            {
                //saveClose.Step = FormGeneral.MasterFile.Count / 100;
                //saveClose.Maximum = FormGeneral.MasterFile.Count;

                foreach(var kvp in FormGeneral.MasterFile)
                {
                    writer.WriteLine(kvp.Key + "," + kvp.Value);
                    //saveClose.PerformStep();
                }
            }
        }

        // 5.7.	Create a method that will close the Admin GUI when the Alt + L keys are pressed.*/
        private void CloseAdminGUI()
        {
            this.Close();
        }
    }
}
