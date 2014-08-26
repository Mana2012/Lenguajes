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

    public partial class Form1 : Form{

        String Texto1;
        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
        }

        private void btn1_Click(object sender, EventArgs e){
            Texto1 = tBox1.Text;
            StreamWriter escrito = File.CreateText("C:\\Users\\DELL\\Documents\\Visual Studio 2012\\Projects\\WF1\\LuaEjemplo.txt");
            escrito.Write(Texto1.ToString());
            escrito.Close();       

            Lua m_lua = new Lua();
            m_lua["tBox1"] = this.tBox1;
            m_lua.DoFile("C:\\Users\\DELL\\Documents\\Visual Studio 2012\\Projects\\WF1\\LuaEjemplo.txt");
            m_lua.Close();

        }

        private void button1_Click(object sender, EventArgs e){
            this.tBox1.Text = "";
            this.tBox1.Focus();
        }
    }
}
