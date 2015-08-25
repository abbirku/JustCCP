using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace JustCCP_part_1_view
{
    public partial class JustCCP : Form
    {
        string fileName = "";
        string sourceFile = "";
        string destinationPath = "";
        string destinationFile = "";
        List<string> filelist;
        byte[] buffer;

        public JustCCP()
        {
            InitializeComponent();
            filelist = new List<string>();
            buffer = new byte[1024];
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            string filePath = "";
            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            string[] files = Directory.GetFiles(fbd.SelectedPath);
            System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///only for a single file
            ///
            /*OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a file";
            if(dialog.ShowDialog()==DialogResult.OK){
                string fname = dialog.FileName;
                MessageBox.Show(fname);
            }*/

            ///THis is for multiple file

            /*OpenFileDialog x = new OpenFileDialog();
            x.Multiselect = true;
            x.ShowDialog();
            string[] result = x.FileNames;

            foreach (string y in result)
                MessageBox.Show(y, "Selected Item", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void copyPage_Click(object sender, EventArgs e)
        {

        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] fileName = openFile.FileNames;
                for (int i = 0; i < fileName.Length; i++)
                {
                    filelist.Add(fileName[i]);
                }
            }
        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                destinationPath = fbd.SelectedPath;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            //how many files are there
            int length = filelist.Count;
            string process;
            //the file name variable
            string file = "";
            long fileLength = 0;
            long totalByte = 0;
            int currentBlockSize = 0;
            double percentage = 0;

            try {
                for (int i = 0; i < length; i++)
                {
                    //getting a file path
                    process = filelist[i];
                    //making an array from its path
                    char[] arr = new char[process.Length];


                    //this converts the string to character array
                    StringReader sr = new StringReader(process);
                    sr.Read(arr, 0, process.Length);

                    //this loop extract the specific file name from the filelist
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j].Equals('\\'))
                        {
                            file = "";
                        }
                        else
                        {
                            file += arr[j].ToString();
                        }
                    }

                    //assining the file into the fileName
                    fileName = file;

                    //getting source path
                    char[] arr2 = new char[process.Length - (fileName.Length + 1)];
                    StringReader sr2 = new StringReader(process);
                    sr2.Read(arr2, 0, process.Length - (fileName.Length + 1));
                    string sourcePath = new string(arr2);

                    //if the directory exists then copy
                    if (Directory.Exists(destinationPath) && (Directory.Exists(sourcePath)))
                    {
                        //copy machanism
                        destinationFile = Path.Combine(destinationPath, fileName);
                        sourceFile = process;

                        FileStream source = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                        fileLength = source.Length;
                        FileStream dest = new FileStream(destinationFile, FileMode.CreateNew, FileAccess.Write);

                        //presentprogressBar.Value = 0;
                        while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            totalByte += currentBlockSize;
                            //Console.WriteLine("Present block size = " + String.Format("{0:0.00}", (totalByte / 1024)));
                            percentage = (double)totalByte * 100 / fileLength;
                            //Console.WriteLine("Pecentage = " + String.Format("{0:0.00}", percentage) + "%");
                            dest.Write(buffer, 0, buffer.Length);
                            //Console.Clear();
                            presentprogressBar.Value = (int)percentage;
                        }

                        

                        totalByte = 0;
                        currentBlockSize = 0;
                        percentage = 0;

                        MessageBox.Show("done");
                        presentprogressBar.Value = 0;
                        dest.Close();
                    }
                    else
                    {
                        MessageBox.Show("Destination does not exists.");
                    }
                }
            }catch(Exception exc){
                MessageBox.Show(exc.Message.ToString());
            }
        }
    }
}
