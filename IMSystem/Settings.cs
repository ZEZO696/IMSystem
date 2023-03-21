using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IMSystem
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                textBoxUsername.Enabled = false;
                textBoxPassword.Enabled = false;
                textBoxPassword.Text = "";
                textBoxUsername.Text = "";
            }
            else
            {
                textBoxPassword.Enabled = true;
                textBoxUsername.Enabled = true;
            }
        }

        private void saveBtnSettings_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isCB.Checked)
            {
                if (textBoxServer.Text != "" && textBoxDatabase.Text != "")
                {
                    s = "Data Source=" + textBoxServer.Text + ";Initial Catalog=" + textBoxDatabase.Text + ";Integrated Security=true;";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Message saved successfully", "Information....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login logObj = new Login();
                        mainClass.showWindow(logObj, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue.....");
                }
            }
            else
            {
                if (textBoxServer.Text != "" && textBoxDatabase.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "")
                {
                    s = "Data Source=" + textBoxServer.Text + ";Initial Catalog=" + textBoxDatabase.Text + ";User ID= " + textBoxUsername.Text + ";Password" + textBoxPassword.Text + ";";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Message saved successfully", "Information....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login logObj = new Login();
                        mainClass.showWindow(logObj, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue.....");
                }
            }
        }
    }
}
