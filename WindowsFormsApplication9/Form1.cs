using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;//method 1 only wav
using WMPLib;//method 2 windows media player lib

//https://www.nuget.org/packages/WMPLib
//https://docs.microsoft.com/en-us/windows/win32/wmp/creating-the-windows-media-player-control-programmatically
//https://docs.microsoft.com/en-us/windows/win32/wmp/using-the-windows-media-player-control-with-microsoft-visual-studio
//https://stackoverflow.com/questions/10594574/playing-a-mp3-file-at-button-click-event-in-windows-form
//https://www.aspsnippets.com/questions/155928/Play-MP3-file-from-Folder-Directory-on-Button-Click-using-C-and-VBNet-in-Windows-Application/
//https://stackoverflow.com/questions/18372355/how-can-i-perform-a-short-delay-in-c-sharp-without-using-sleep

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }
        /*method 1 object
        SoundPlayer obj = new SoundPlayer(@"C:\Users\WUSC SRILANKA\Downloads\Music\piano2.wav");
        */
       

        //method 2 object
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();        
          
 
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*method 1 play
            obj.Play();
            //SystemSounds.Asterisk.Play();
            */  
          
            //method 2
            
            wplayer.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //method 2
            wplayer.controls.stop();       


            /*method 1 stop
              obj.Stop();*/
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            //method 2 pause no pause in method 1 
            wplayer.controls.pause();
          //  await Task.Delay(3000);//delay command must be use with async
           // wplayer.controls.play();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        public void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //openFileDialog1.InitialDirectory = "c:\\";     
            string filepath = @""+openFileDialog1.FileName+"";
            wplayer.URL = filepath;
            wplayer.controls.stop();
        }
        
    }
}
