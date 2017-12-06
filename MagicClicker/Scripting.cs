using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Scripting
{
    public static class Scripting
    {
        internal static void LoadScript(string FilePath, ListBox PointList, RichTextBox NoteBox, NumericUpDown Delay, NumericUpDown Variance, NumericUpDown Offset, NumericUpDown LoopCount)
        {
            NoteBox.Clear();
            PointList.Items.Clear();
            //foreach (string line in File.ReadAllLines(@"C:\Downloads\Test.txt"))
            foreach (string line in File.ReadAllLines(FilePath))
            {
                if (line.StartsWith("//"))
                {
                    NoteBox.AppendText(line.Trim('/') + '\n');
                }
                else if (line.StartsWith("delay:"))
                {
                    Delay.Value = Convert.ToDecimal(line.Split(':')[1]);
                }
                else if (line.StartsWith("var:"))
                {
                    Variance.Value = Convert.ToDecimal(line.Split(':')[1]);
                }
                else if (line.StartsWith("offset:"))
                {
                    Offset.Value = Convert.ToDecimal(line.Split(':')[1]);
                }
                else if (line.StartsWith("count:"))
                {
                    LoopCount.Value = Convert.ToDecimal(line.Split(':')[1]);
                }
                else
                {
                    PointList.Items.Add(line);
                }
            }
        }

        internal static void SaveScript(string FilePath, ListBox PointList, RichTextBox NoteBox, NumericUpDown Delay, NumericUpDown Variance, NumericUpDown Offset, NumericUpDown LoopCount)
        {
            StreamWriter outFile = new StreamWriter(FilePath);
            //StreamWriter outFile = new StreamWriter(@"C:\Downloads\Test.txt");
            foreach (string s in NoteBox.Lines)
            {
                outFile.WriteLine("//" + s);
            }

            // Saving the values of tertiary numeric boxes
            outFile.WriteLine("delay:" + Delay.Value);
            outFile.WriteLine("var:" + Variance.Value);
            outFile.WriteLine("offset:" + Offset.Value);
            outFile.WriteLine("count:" + LoopCount.Value);

            foreach (string s in PointList.Items)
            {
                outFile.WriteLine(s);
            }
            outFile.Close();
        }
    }
}
