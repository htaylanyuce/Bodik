using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
 

namespace dilmenBurakhan
{
   

    public partial class Form1 : Form
    {
        Button formb2;
        Form f2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;



            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                comboBox1.Items.Add(oneFontFamily.Name.ToString());
            }
            comboBox1.SelectedItem = "Arial";

            for (int i = 6; i <= 24; i++)
            {
                comboBox2.Items.Add(i);
            }
            comboBox2.SelectedItem = 6;

            comboBox3.Items.Add(FontStyle.Bold);
            comboBox3.Items.Add(FontStyle.Italic);
            comboBox3.Items.Add(FontStyle.Regular);
            comboBox3.Items.Add(FontStyle.Underline);

            comboBox3.SelectedItem = FontStyle.Regular;

            richTextBox1.AppendText(Environment.NewLine + DateTime.Today + " Hello");




        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            FontFamily fontFamily = new FontFamily(comboBox1.SelectedItem.ToString());
             

             richTextBox1.Font = new Font(fontFamily, richTextBox1.Font.Size);


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(comboBox2.SelectedItem.ToString()),richTextBox1.Font.Style);


        }

        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBox3.SelectedItem.ToString().Equals("Bold"))
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size , FontStyle.Bold);
            }
            else if (comboBox3.SelectedItem.ToString().Equals("Regular"))
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
            }
            else if (comboBox3.SelectedItem.ToString().Equals("Italic"))
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
            }
            else if (comboBox3.SelectedItem.ToString().Equals("Underline"))
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = richTextBox1.ForeColor;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = MyDialog.Color;
                button2.ForeColor = MyDialog.Color;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = richTextBox1.ForeColor;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = MyDialog.Color;
                button3.BackColor = MyDialog.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBox1.LoadFile(openFile1.FileName);
            }
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionCharOffset = -3;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionCharOffset = 3;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool CloseCancel()
        {
   
            
            const string message = "Programı kapatmak istediğinize emin misiniz?";
            const string caption = "Form3";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
 
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new Form();
            Label l2 = new Label();
            l2.Location = new Point(0, 25);
            l2.Text = "AranacakOge:";
            
            TextBox t2 = new TextBox();
           
            t2.Location = new Point(150, 25);
            t2.Size = new System.Drawing.Size(70, 20);

            CheckBox c2 = new CheckBox();
            c2.Location = new Point(150, 50);
            Label l3 = new Label();
            l3.Location = new Point(170, 50);
            c2.Text = "buyukkucukduyarlılık:";

            formb2 = new Button();

            formb2.Text = "BUL";
            formb2.Location = new Point(150,70);

            f2.Controls.Add(t2);
            f2.Controls.Add(c2);
            f2.Controls.Add(l2);
            f2.Controls.Add(l3);
            f2.Controls.Add(formb2);


            f2.ShowDialog(); // Shows Form2
            f2.Location = new Point(300, 300);
            f2.FormBorderStyle = FormBorderStyle.FixedDialog;
            f2.MaximizeBox = false;

          
        }
        private void formb2_Click(object sender, EventArgs e)
        {
             

        }

    }
}
