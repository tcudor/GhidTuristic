using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhidTuristic
{   
    
    public partial class Form1 : Form
    {
        string resultPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));

        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Hide();
            
            axWindowsMediaPlayer1.URL = resultPath+"/Audio/mixkit-cinematic-tunnel-reverb-woosh-1486.wav";
            Play();
        }

        public void Play()
        {
           
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex - 1 >= 0 ) ?
                             tabControl1.SelectedIndex - 1 : tabControl1.SelectedIndex;
            axWindowsMediaPlayer1.URL = resultPath+"/Audio/mixkit-cinematic-whoosh-fast-transition-1492.wav";
            Play();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                             tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
            axWindowsMediaPlayer1.URL = resultPath+"/Audio/mixkit-cinematic-whoosh-fast-transition-1492.wav";
            Play();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.valceaturistica.ro/atractii-turistice-valcea/gradina-zoologica-ramnicu-valcea/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.valceaturistica.ro/atractii-turistice-valcea/salina-ocnele-mari/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://turismistoric.ro/parcul-zavoi-din-ramnicu-valcea-o-promenada-cu-gust-istoric/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ghidulmuzeelor.cimec.ro/id.asp?k=663");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.muzee-valcea.ro/index.php?f=muzee&m=6");
        }
    }
}
