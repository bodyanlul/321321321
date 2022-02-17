using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace tf9ik
{
    public partial class Form1 : Form
    {
        private string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            TextEditor.Clear();
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            // Чтение текстового файла
            try
            {
                var Reader = new System.IO.StreamReader(
                openFileDialog1.FileName, Encoding.GetEncoding(1251));
                TextEditor.Text = Reader.ReadToEnd();
                fileName = openFileDialog1.FileName;
                this.Text = fileName;
                Reader.Close();
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                MessageBox.Show(Ситуация.Message + "\nНет такого файла",
                         "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            { // отчет о других ошибках
                MessageBox.Show(Ситуация.Message,
                     "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var Writer = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false,
                                        System.Text.Encoding.GetEncoding(1251));
                    Writer.Write(TextEditor.Text);
                    Writer.Close();
                }
                catch (Exception Ситуация)
                { // отчет о других ошибках
                    MessageBox.Show(Ситуация.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void CutBtn_Click(object sender, EventArgs e)
        {
            TextEditor.Cut();
        }

        private void PasteBtn_Click(object sender, EventArgs e)
        {
            TextEditor.Paste();
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            TextEditor.Copy();
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            TextEditor.Undo();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            TextEditor.Redo();
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = fileName;
            
                try
                {
                    var Writer = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false,
                                        System.Text.Encoding.GetEncoding(1251));
                    Writer.Write(TextEditor.Text);
                    Writer.Close();
                }
                catch (Exception Ситуация)
                { // отчет о других ошибках
                    MessageBox.Show(Ситуация.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
        }

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor.Clear();
        }

        private void ВыделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor.SelectAll();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор языкового процесса.\n\nРазработали студенты группы АВТ-913:" +
                "\nВолков Богдан" +
                "\nГорбунцов Леонид" +
                "\nХафаев Максим");
        }

        private void ВызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\User.DESKTOP-Q2FT676\\source\\repos\\tf9ik\\chm.chm");
        }
    }
}
