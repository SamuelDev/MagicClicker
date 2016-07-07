using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Scripting
{
    public static class Scripting
    {
        internal static void LoadScript(string FilePath, ListBox PointList, RichTextBox NoteBox)
        {
            NoteBox.Clear();
            PointList.Items.Clear();
            //foreach (string line in File.ReadAllLines(@"C:\Downloads\Test.txt"))
            foreach (string line in File.ReadAllLines(FilePath))
            {
                if (line.StartsWith("//"))
                {
                    NoteBox.AppendText(line.Trim('/'));
                }
                else
                {
                    PointList.Items.Add(line);
                }
            }
        }

        internal static void SaveScript(string FilePath, ListBox PointList, RichTextBox NoteBox)
        {
            StreamWriter outFile = new StreamWriter(FilePath);
            //StreamWriter outFile = new StreamWriter(@"C:\Downloads\Test.txt");
            foreach (string s in NoteBox.Lines)
            {
                outFile.WriteLine("//" + s);
            }
            foreach (string s in PointList.Items)
            {
                outFile.WriteLine(s);
            }
            outFile.Close();
        }
    }
}
