using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Undertale_Save_Editor
{
    public partial class Form1 : Form
    {
        private string[] savefiletext;
        private string displaysavefile;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displaysavefile = File.ReadAllText(textBox1.Text, Encoding.UTF8);
            richTextBox1.Text = displaysavefile;
            savefiletext = File.ReadAllLines(textBox1.Text, Encoding.UTF8);

            savefilename.Text = File.ReadLines(textBox1.Text).Skip(0).Take(1).First();

            heartShapedBox.Text = File.ReadLines(textBox1.Text).Skip(2).Take(1).First();
            boxOfRiches.Text = File.ReadLines(textBox1.Text).Skip(10).Take(1).First();

            boxslot1.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(12).Take(1).First());
            boxslot2.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(14).Take(1).First());
            boxslot3.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(16).Take(1).First());
            boxslot4.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(18).Take(1).First());
            boxslot5.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(20).Take(1).First());
            boxslot6.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(22).Take(1).First());
            boxslot7.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(24).Take(1).First());
            boxslot8.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(26).Take(1).First());

            boxATK.Text = File.ReadLines(textBox1.Text).Skip(4).Take(1).First();
            boxWPNATK.Text = File.ReadLines(textBox1.Text).Skip(5).Take(1).First();
            boxDF.Text = File.ReadLines(textBox1.Text).Skip(6).Take(1).First();
            boxARMDF.Text = File.ReadLines(textBox1.Text).Skip(7).Take(1).First();

            boxOfLove.Text = File.ReadLines(textBox1.Text).Skip(1).Take(1).First();
            boxOfXP.Text = File.ReadLines(textBox1.Text).Skip(9).Take(1).First();

            boxOfFun.Text = File.ReadLines(textBox1.Text).Skip(35).Take(1).First();
            murderousBox.Text = File.ReadLines(textBox1.Text).Skip(11).Take(1).First();

            knifeBox.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(28).Take(1).First());
            boxBox.SelectedIndex = Int32.Parse(File.ReadLines(textBox1.Text).Skip(29).Take(1).First());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            savefiletext[0] = savefilename.Text;

            savefiletext[12] = boxslot1.SelectedIndex.ToString();
            savefiletext[14] = boxslot2.SelectedIndex.ToString();
            savefiletext[16] = boxslot3.SelectedIndex.ToString();
            savefiletext[18] = boxslot4.SelectedIndex.ToString();
            savefiletext[20] = boxslot5.SelectedIndex.ToString();
            savefiletext[22] = boxslot6.SelectedIndex.ToString();
            savefiletext[24] = boxslot7.SelectedIndex.ToString();
            savefiletext[26] = boxslot8.SelectedIndex.ToString();

            savefiletext[4] = boxATK.Text;
            savefiletext[5] = boxWPNATK.Text;
            savefiletext[6] = boxDF.Text;
            savefiletext[7] = boxARMDF.Text;

            savefiletext[1] = boxOfLove.Text;
            savefiletext[9] = boxOfXP.Text;

            savefiletext[2] = heartShapedBox.Text;
            savefiletext[10] = boxOfRiches.Text;

            savefiletext[35] = boxOfFun.Text;
            savefiletext[11] = murderousBox.Text;

            savefiletext[28] = knifeBox.SelectedIndex.ToString();
            savefiletext[29] = boxBox.SelectedIndex.ToString();



            File.WriteAllLines(textBox1.Text, savefiletext);
            displaysavefile = File.ReadAllText(textBox1.Text, Encoding.UTF8);
            richTextBox1.Text = displaysavefile;
        }
    }
}
