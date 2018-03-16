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

namespace File_Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Files2Convert.DragDrop += new
           System.Windows.Forms.DragEventHandler(this.Files2Convert_DragDrop);
            this.Files2Convert.DragEnter += new
           System.Windows.Forms.DragEventHandler(this.Files2Convert_DragEnter);
        }

        private void Files2Convert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Files2Convert_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Files2Convert_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                Files2Convert.Items.Add(s[i]);
        }

        private void ConvertB_Click(object sender, EventArgs e)
        {
       
         int length = System.Convert.ToInt32(System.Convert.ToDouble(Files2Convert.Items.Count.ToString()));
         
         //FilenumTB.Text = "Processing file 0 of" + length;            
         Application.DoEvents();
            for (int i=0;i<length;i++)
            {
                FilenumTB.Text = "Processing file " + (i+1) + " of " + length;
                Application.DoEvents();
                ConvertFile(i);

            }
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show("Complete","", buttons);
        
        }

        private void ConvertFile(int i)
        {
            String Filename = (String)Files2Convert.Items[i];
            int FilenameL = Filename.Length;
            String input = File.ReadAllText(Filename);
            int pos=0;
            int stop = 0;
            int end;
            string line;
            string RamanS;
            string DarkS;
            int k = 1;

            while (k != -1)
            {
                pos = k;
                k = Filename.IndexOf("\\", k + 1);
            }
            string name = Filename.Substring(pos + 1, FilenameL - pos - 1);
            string path = Filename.Substring(0, pos);
            string newPath = path + "\\Processed\\" + name;

            System.IO.Directory.CreateDirectory(path + "\\Processed\\");
            pos = input.IndexOf("\n192;");

            end = input.IndexOf("\n1985;");
            
            while (pos < end )
            {
                for (int j = 0; j < 3; j++)
                {
                    pos = input.IndexOf(";", pos) + 1;
                }
                stop = input.IndexOf(";", pos);
                RamanS = input.Substring(pos, stop-pos);

                for (int j = 0; j < 4; j++)
                {
                    pos = input.IndexOf(";", pos) + 1;

                }
                stop = input.IndexOf(";", pos);
                DarkS = input.Substring(pos, stop - pos-2);

                //line = RamanS + "\t" + DarkS + "\r\n";
                line = RamanS + "\t" + DarkS;     

                using (StreamWriter sw = File.AppendText(newPath))
                {
                    sw.WriteLine(line);
                }
                pos = input.IndexOf("\n",pos);
                int b = 0;
            }
            


            int a = 0;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            Files2Convert.Items.Clear();
        }






    }
}
