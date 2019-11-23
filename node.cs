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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Tree temp = new Tree();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadDictionary()
        {
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"E:\New folder\4th semester\DSA\DSA\spell corector\spell corector\WORDS.txt");
            while ((line = file.ReadLine()) != null)
            {
                temp.InsertData(line);
            }

            file.Close();
            
        }
