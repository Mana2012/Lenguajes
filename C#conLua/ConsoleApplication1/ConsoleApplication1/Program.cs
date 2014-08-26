using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaInterface;

namespace ConsoleApplication1{

    class Program{
        static void Main(string[] args){

//Comienzo de codigo Lua
            Lua lua = new Lua();
            lua["num0"] = 91;
            lua["num1"] = 28;
            lua["suma"] = "Suma           = ";
            lua["resta"] = "Resta          = ";
            lua["mult"] = "Multiplicacion = ";
            lua["div"] = "Division       = ";
            double num0 = (double)lua["num0"];
            double num1 = (double)lua["num1"];
            string suma = (string)lua["suma"];
            string resta = (string)lua["resta"];
            string mult = (string)lua["mult"];
            string div = (string)lua["div"];
            Console.WriteLine(" \n    Hola a Todos \n\n Bienvenidos a Lua \n");
            Console.WriteLine("Numero 1:    " + num0);
            Console.WriteLine("Numero 2:    " + num1 + "\n");
            Console.WriteLine(suma + num0 + " + " + num1 + " = " + (num0 + num1));
            Console.WriteLine(resta + num0 + " - " + num1 + " = " + (num0 - num1));
            Console.WriteLine(mult + num0 + " * " + num1 + " = " + (num0 * num1));
            Console.WriteLine(div + num0 + " / " + num1 + " = " + (num0 / num1));
            Console.ReadLine();

        }
    }
}
