using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using LuaInterface;
using System.IO;

namespace WF1{

    public partial class Form2 : Form{

        public Form2(){
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e){
            Lua name = new Lua();
            //name = this.textBox1.Text
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e){
            
            
            //hierba = Image.load("C:\\Users\\DELL\\Documents\\Visual Studio 2012\\Projects\\WF1\\music.jpe");
            //screen: blit(500, 500, hierba)
        }
    }
}
