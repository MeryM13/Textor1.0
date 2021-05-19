using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Textor
{
    class Filework
    {
        public static void CreateFile(ref TextBox notebox, ref bool tbChange, ref string docPath) 
        {
            string NewDocName = Properties.Settings.Default.NewDocName;
            string ProgrammName = Properties.Settings.Default.ProgrammName;
            notebox.Clear();
            docPath = "";
            tbChange = false;
            MainForm.ActiveForm.Text = NewDocName + " — " + ProgrammName;
        }

        public static void OpenFile(ref TextBox notebox, ref bool tbChange, ref string docPath) 
        {
            string ProgrammName = Properties.Settings.Default.ProgrammName;
            OpenFileDialog openDocument = new OpenFileDialog();
            openDocument.Title = "Открыть текстовый документ";
            openDocument.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы (*.*)|*.*";
            if (openDocument.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(openDocument.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file, Encoding.Default);
                notebox.Text = reader.ReadToEnd();
                reader.Close();
                docPath = openDocument.FileName;
                tbChange = false;
                MainForm.ActiveForm.Text = openDocument.SafeFileName + " — " + ProgrammName;
            }
        }

        public static void SaveFile(ref TextBox notebox, ref bool tbChange, ref string docPath) 
        {
            FileStream file = new FileStream(docPath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file, Encoding.Default);
            writer.Write(notebox.Text);
            writer.Close();
            tbChange = false;
        }

        public static void SaveAsFile(ref TextBox notebox, ref bool tbChange, ref string docPath) 
        {
            string ProgrammName = Properties.Settings.Default.ProgrammName;
            SaveFileDialog saveAsDocument = new SaveFileDialog();
            saveAsDocument.Title = "Сохранить документ как...";
            saveAsDocument.FileName = "Текстовый документ";
            saveAsDocument.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы (*.*)|*.*";

            if (saveAsDocument.ShowDialog() == DialogResult.OK) 
            {
                
                FileStream file = new FileStream(saveAsDocument.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file, Encoding.Default);
                writer.Write(notebox.Text); 
                writer.Close(); 
                tbChange = false;
                docPath = saveAsDocument.FileName;
                MainForm.ActiveForm.Text = Path.GetFileName(saveAsDocument.FileName) + " — " + ProgrammName;
            }
            else
            {
                tbChange = true;
                return;
            }
        }
    }
}
