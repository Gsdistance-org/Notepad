using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Notepad : Form
    {
        //dialogs
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private FontDialog FontDialog;
        //dialogs
        public Notepad()
        {
            InitializeComponent();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void worlspacefolderBrowser_HelpRequest(object sender, EventArgs e)
        {

        }

        private void load_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void save_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void fontselector_Apply(object sender, EventArgs e)
        {

        }

        private void Savecurfile_Click(object sender, EventArgs e)
        {

        }

        private void Loadcurfile_Click(object sender, EventArgs e)
        {
            openFile.OpenFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(null);
        }

        private void textfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openfile()
        {
            try
            {
                openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textfield.Text = File.ReadAllText(openFileDialog.FileName);
                    filelabel.Text = openFileDialog.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Error opening the file!");
            }
            finally
            {
                openFileDialog = null;
            }
        }

        private void savefileas()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.textfield.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "All files (*.*) | *.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, this.textfield.Text);
                        filelabel.Text = saveFileDialog.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("The text field is empty");
                }


            }
            catch
            {

            }
            finally
            {

            }
        }

        private void savefile()
        {
            try
            {
                if(!string.IsNullOrEmpty(this.textfield.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text file (*.txt) | *.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, this.textfield.Text);
                        filelabel.Text = saveFileDialog.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("The text field is empty");
                }

                
            }
            catch
            {

            }
            finally
            {

            }
        }

        //create a newfile
        private void newfile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.textfield.Text))
                {
                    MessageBox.Show("Save the file first!");
                }
                else
                {
                    this.textfield.Text = string.Empty;
                    filelabel.Text = "Untitled";
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newfile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefileas();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backimage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
