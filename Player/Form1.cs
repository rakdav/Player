using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Player
{
    public partial class Form1 : Form
    {
        private string path;
        private List<MyMusic> list;

        public Form1()
        {
            InitializeComponent();
            list = new List<MyMusic>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Звуки(*.mp3,*.wav)|*.mp3;*.wav|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    MyMusic music = new MyMusic(openFileDialog1.SafeFileNames[i],
                        openFileDialog1.FileNames[i]); 
            
                    list.Add(music);
                    checkedListBox1.Items.Add(music.Name);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i == checkedListBox1.SelectedIndices[i])
                {
                    sound.SoundLocation = @"" + list[i].PathName;
                    sound.PlaySync();
                }
            }
           
        }
    }
}
