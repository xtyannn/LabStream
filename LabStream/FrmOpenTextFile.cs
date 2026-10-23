using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;

            if (string.IsNullOrEmpty(path)) return;

            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }
        }

        private void FrmOpenTextFile_Load(object sender, EventArgs e)
        {

        }
    }
}