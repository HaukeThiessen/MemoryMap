using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMap
{
    
        public partial class Form1 : Form
        {
            string memReport = "";
            public Form1()
            {
                InitializeComponent();
            }

            private void BtnOpen_Click(object sender, EventArgs e)
            {
                memReportPathBrowserDialog.ShowDialog();
                string path = memReportPathBrowserDialog.SelectedPath;
                if (!File.Exists(path))
                {
                
                }
            string searchPattern = tb_searchPattern.Text;
            Program.StatType type = Program.StatType.BASELINE;
            if (rb_TypeBaseline.Checked == true)
            {
                type = Program.StatType.BASELINE;
            }
            else if (rb_TypeDiff.Checked == true)
            {
                type = Program.StatType.DIFF;
            } 
            else
            {
                type = Program.StatType.VALUE;
            }
            OutputLog.Text = Program.Parse(path, searchPattern, type);
            //// Open the stream and read it back.
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        memReport += s;
            //    }
            //}

            ////Check every line for relevant information
            //Console.WriteLine("Memreport:   " + memReport);
            //Regex RexTextureGroup = new Regex(@"[1-9][0-9]*  -  TEXTUREGROUP.+? ", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            //MatchCollection matches = RexTextureGroup.Matches(memReport);
            //if (matches.Count >= 1)
            //{
            //    foreach (Match match in matches)
            //    {
            //        OutputLog.Text += match.ToString() + "\n";
            //        string[] separator = { " - " };
            //        string[] result = match.ToString().Split(separator, StringSplitOptions.None);
            //        float value;
            //        float.TryParse(result[0], out value);
            //        result[0] = (value / 1048576).ToString();
            //        //Table1.Rows.Add({result[0], result[1]});
            //    }

            //}
            //else
            //{
            //    OutputLog.Text += memReport;
            //}

        }
        }
    }
