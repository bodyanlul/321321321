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
using System.Text.RegularExpressions;

namespace tf9ik
{
    public partial class Form1 : Form
    {
        private List<Stack<string>> stackState = new List<Stack<string>>();
        private List<Stack<string>> backstackState = new List<Stack<string>>();
        private List<string> oldStr = new List<string>();
        private List<string> Path = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            this.UndoBtn.Enabled = false;
            this.ReturnBtn.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewList_Click(object sender, EventArgs e)
        {
            PageNew();
            stackState.Add(new Stack<string>());
            backstackState.Add(new Stack<string>());
            oldStr.Add("");
            Path.Add(null);
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
        }
        private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewList_Click(sender, e);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            ResultWindow.Font = new Font("Arial", 14);
        }

        private int PageNew(string namePage = "Новый файл")
        {
            var NewText = new RichTextBox();
            NewText.Location = new System.Drawing.Point(0, 0);
            NewText.Multiline = true;
            NewText.Name = "textEnter";
            NewText.Size = new System.Drawing.Size(972, 278);
            NewText.TabIndex = 9;
            NewText.TextChanged += new System.EventHandler(this.TextEnter_TextChanged);
            NewText.Font = new Font("Arial", 14);

            TabPage myTabPage = new TabPage(namePage);
            myTabPage.Controls.Add(NewText);
            tabControl1.TabPages.Add(myTabPage);

            return tabControl1.TabPages.Count - 1;
        }

        private void TextEnter_TextChanged(object sender, EventArgs e)
        {
            RichTextBox textBox = (RichTextBox)sender;
            stackState[tabControl1.SelectedIndex].Push(oldStr[tabControl1.SelectedIndex]);
            oldStr[tabControl1.SelectedIndex] = textBox.Text;
            int pos = textBox.SelectionStart;

            this.UndoBtn.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UndoBtn.Enabled = true;
            this.ReturnBtn.Enabled = true;

            if (tabControl1.SelectedIndex == -1)
            {
                return;
            }

            if (backstackState[tabControl1.SelectedIndex].Count == 0)
            {
                this.ReturnBtn.Enabled = false;
            }

            if (stackState[tabControl1.SelectedIndex].Count == 0)
            {
                this.UndoBtn.Enabled = false;
            }

        }
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile_Click(sender, e);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            var fileContent = string.Empty;

            openFile.InitialDirectory = "./";
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Path.Add(openFile.FileName);

                string[] name = openFile.FileName.Split(new char[] { '\\' });

                stackState.Add(new Stack<string>());
                backstackState.Add(new Stack<string>());

                tabControl1.SelectedIndex = PageNew(name[name.Length - 1]);

                var fileStream = openFile.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    oldStr.Add(fileContent);
                    this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text = fileContent;
                }
            }
        }
        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "txt files (*.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string sting = this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text;
                Path[tabControl1.SelectedIndex] = saveFile.FileName;
                FileStream file = File.Create(saveFile.FileName);
                byte[] info = new UTF8Encoding(true).GetBytes(sting);

                string[] name = saveFile.FileName.Split(new char[] { '\\' });

                this.tabControl1.TabPages[tabControl1.SelectedIndex].Text = name[name.Length - 1];

                file.Write(info, 0, info.Length);
                file.Close();
            }
        }

        private void CutBtn_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == -1)
            {
                return;
            }

            RichTextBox box = (RichTextBox)tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"];
            box.Cut();
        }

        private void PasteBtn_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == -1)
            {
                return;
            }

            RichTextBox box = (RichTextBox)tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"];
            box.Paste();
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1)
            {
                return;
            }

            RichTextBox box = (RichTextBox)tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"];
            box.Copy();
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1)
            {
                return;
            }

            this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].TextChanged -= TextEnter_TextChanged;
            backstackState[tabControl1.SelectedIndex].Push(this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text);
            this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text = stackState[tabControl1.SelectedIndex].Pop();
            this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].TextChanged += TextEnter_TextChanged;

            oldStr[tabControl1.SelectedIndex] = this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text;

            this.ReturnBtn.Enabled = true;

            if (stackState[tabControl1.SelectedIndex].Count == 0)
            {
                this.UndoBtn.Enabled = false;
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1)
            {
                return;
            }

            this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].TextChanged -= TextEnter_TextChanged;
            string str = backstackState[tabControl1.SelectedIndex].Pop();
            stackState[tabControl1.SelectedIndex].Push(this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text);
            this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text = str;
            this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].TextChanged += TextEnter_TextChanged;

            oldStr[tabControl1.SelectedIndex] = this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text;

            this.UndoBtn.Enabled = true;

            if (backstackState[tabControl1.SelectedIndex].Count == 0)
            {
                this.ReturnBtn.Enabled = false;
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path[this.tabControl1.SelectedIndex] == null)
            {
                СохранитьКакToolStripMenuItem_Click(sender, e);
            }
            else
            {
                string sting = this.tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text;
                FileStream file = File.Create(Path[tabControl1.SelectedIndex]);
                byte[] info = new UTF8Encoding(true).GetBytes(sting);
                file.Write(info, 0, info.Length);
                file.Close();
            }
        }

        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedIndex == -1)
            {
                return;
            }

            string message = "Сохранить файл - " + this.tabControl1.TabPages[tabControl1.SelectedIndex].Text + "?";
            string caption = "TextNode";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                СохранитьToolStripMenuItem_Click(sender, e);
            }
            this.tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"].Text = "";
        }

        private void ВыделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox box = (RichTextBox)tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"];
            box.SelectAll();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор языкового процесса.\n\nРазработали студенты группы АВТ-913:" +
                "\nВолков Богдан" +
                "\nГорбунцов Леонид" +
                "\nХафаев Максим"+
                "\nПоливода Михаил");
        }

        private void ВызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\User.DESKTOP-Q2FT676\\Desktop\\321321321-main\\tf9ik\\chm.chm");
        }

        private void Valid_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1)
            {
                return;
            }

            RichTextBox box = (RichTextBox)tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"];
            box.Enabled = false;
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$";
            char[] separators = new char[] { ' ', ',', ':', ';', '?', '/', '!'};
            int count = 0;

            this.ResultWindow.Text = "Найденные email:\n";
            string[] text = box.Lines;

            for (int i = 0; i < text.Length; ++i)
            {
                //MatchCollection matchColl=null;
                Regex regex = new Regex(pattern, RegexOptions.Singleline);
                var splitedString = text[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < splitedString.Length; j++)
                {
                    MatchCollection matchColl = regex.Matches(splitedString[j]);
                    foreach (Match match in matchColl)
                    {
                        ++count;
                        this.ResultWindow.Text += count + ". " + match.Value;
                        this.ResultWindow.Text += " Строка: " + (i + 1);
                        this.ResultWindow.Text += "\n";
                    }
                }
                
               

            }
            if (count == 0)
            {
                this.ResultWindow.Text += "Не найдено";
            }
            box.Select(0, 0);
            box.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1)
            {
                return;
            }
            RichTextBox box = (RichTextBox)tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"];
            Automat auto = new Automat();
            char[] separators = new char[] { ' ', ',', ':', ';', '?', '/', '!' };
            string[] text = box.Lines;
            int count = 0;
            for (int i = 0; i < text.Length; ++i)
            {
                var splitedString = text[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < splitedString.Length; j++)
                {
                    var matches = new List<string>();
                    var check = auto.checkEmail(splitedString[j]);
                    var splited = check.Split(' ');
                    matches.Add(splitedString[j]);
                    
                    foreach (var match in matches)
                    {
                        ++count;
                        this.ResultWindow.Text += count + ". " + match;
                        this.ResultWindow.Text += " Строка: " + (i + 1);
                        this.ResultWindow.Text += "\n";
                        this.ResultWindow.Text += check;
                        this.ResultWindow.Text += "\n";
                    }
                }
            }
        }

        private void АвтоматToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void сканерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1)
            {
                return;
            }
            this.ResultWindow.Text = "";
            RichTextBox box = (RichTextBox)tabControl1.TabPages[tabControl1.SelectedIndex].Controls["textEnter"];
            Scanner scanner = new Scanner();
            List<ScanResult> scanResults = scanner.Scan(box.Text);
            foreach (ScanResult scanResult in scanResults)
            {
                if(scanResult.NumberString == 0)
                {
                    this.ResultWindow.Text += (scanResult.NumberString + 1).ToString() + ":" + (scanResult.Position - scanResult.PositionString+1).ToString();
                    this.ResultWindow.Text += " ";
                    this.ResultWindow.Text += scanResult.Value.ToString();
                    this.ResultWindow.Text += " ";
                    this.ResultWindow.Text += scanResult.ElementCode.ToString();
                    this.ResultWindow.Text += "\n";
                    if (scanResult.ElementCode == 7)
                    {
                        this.ResultWindow.Text += "\n";
                    }
                }
                else
                {
                    this.ResultWindow.Text += (scanResult.NumberString + 1).ToString() + ":" + (scanResult.Position - scanResult.PositionString).ToString();
                    this.ResultWindow.Text += " ";
                    this.ResultWindow.Text += scanResult.Value.ToString();
                    this.ResultWindow.Text += " ";
                    this.ResultWindow.Text += scanResult.ElementCode.ToString();
                    this.ResultWindow.Text += "\n";
                    if (scanResult.ElementCode == 7)
                    {
                        this.ResultWindow.Text += "\n";
                    }
                }
                
            }
        }

        private void грамматикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
