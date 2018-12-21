﻿using DaanLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole {
    class Program {
        static void Main(string[] args) {
            DaanLib.Datastructures.LinkedList<int> list = new DaanLib.Datastructures.LinkedList<int>();

            Vector2D v = new Vector2D(5, 10);

            Matrix m = new Matrix(v);

            Console.WriteLine(m);

            Console.WriteLine(Matrix.Identity(5));

            Console.ReadKey();
        }
    }
}