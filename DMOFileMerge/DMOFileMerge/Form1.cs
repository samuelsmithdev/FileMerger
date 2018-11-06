using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DMOFileMerge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> MergeFileList;

        public string outputFilePath;

        public void outputFileLocation_btn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string outputFilePath = Path.GetFullPath(folderBrowserDialog1.SelectedPath);
                
            }
        }

        public void appendTextToFile()
        {
            //File writes to here
            string path = folderBrowserDialog1.SelectedPath;
            string outputFile = path + "\\" + outputFileNameTextBox.Text + ".txt";

            try
            {
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.


                    const int chunkSize = 2 * 1024; // 2KB
                    var inputFiles = MergeFileList;
                    using (var output = File.Create(outputFile))
                    {
                        foreach (var file in inputFiles)
                        {
                            using (var input = File.OpenRead(file))
                            {
                                var buffer = new byte[chunkSize];
                                int bytesRead;
                                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    output.Write(buffer, 0, bytesRead);
                                }

                            }

                        }

                    }

                    // This text is always added, making the file longer over time
                    // if it is not deleted.
                    string appendText = Environment.NewLine;
                    File.AppendAllText(outputFile, appendText, Encoding.UTF8);

                    // Open the file to read from.
                    string readText = File.ReadAllText(outputFile);
                    Console.WriteLine(readText);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            appendTextToFile();
        }

        //form handler
        private void Preview_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            var form1 = new Form1();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //TAKE DROPPED ITEMS AND STORE IN ARRAY
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            MergeFileList = new List<String>();

            //LOOP THROUGH ALL DROPPED ITEMS AND DISPLAY THEM
            foreach (string file in droppedFiles)
            {
                string filename = GetFileName(file);
                listBox1.Items.Add(filename);
                string filepath = GetFilePath(file);
                MergeFileList.Add(filepath);
                //text files enter list correctly after breakpoint test
            }
        }

        private string GetFilePath(string path)
        {
            return Path.GetFullPath(path);
        }

        //GET FILENAME 
        public string GetFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }


        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        // handle the selected change if you wish and get the full path from the selectedIndex.
        private void MergeFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check to make sure there is a selected item
            if (listBox1.SelectedIndex > -1)
            {
                string fullPath = MergeFileList[listBox1.SelectedIndex];

                // remove the item from the list
                MergeFileList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        public void MoveUp()
        {
            MoveItem(-1);
        }

        public void MoveDown()
        {
            MoveItem(1);
        }

        //MOVE ITEM METHOD
        public void MoveItem(int direction)
        {
            // Checking selected item
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox1.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox1.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox1.SelectedItem;

            // Removing removable element
            listBox1.Items.Remove(selected);
            // Insert it in new position
            listBox1.Items.Insert(newIndex, selected);
            // Restore selection
            listBox1.SetSelected(newIndex, true);
        }

        //REMOVE
        public void removeItemFromListBox()
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeItemFromListBox();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        
    }
}

