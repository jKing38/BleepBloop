﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BleepBloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Note mynote = new Note();
            Thread.Sleep(500);
            //C Major Scale
            //mynote.Play("C,5", "quarter", "pp");
            //mynote.Play("D,5", "quarter", "p");
            //mynote.Play("E,5", "quarter", "mp");
            //mynote.Play("F,5", "quarter", "mf");
            //mynote.Play("G,5", "quarter", "f");
            //mynote.Play("A,5", "quarter", "ff");
            //mynote.Play("B,5", "quarter", "f");
            //mynote.Play("C,6", "quarter", "pp");


            //Tetris
            mynote.Play("F,5", "quarter", "mp");
            mynote.Play("C,5", "eigth", "mp");
            mynote.Play("C#,5", "eigth", "mp");
            mynote.Play("D#,5", "eigth", "mp");
            mynote.Play("F,5", "sixteenth", "mp");
            mynote.Play("D#,5", "sixteenth", "mp");
            mynote.Play("C#,5", "eigth", "mp");
            mynote.Play("C,5", "eigth", "mp");
            mynote.Play("A#,4", "quarter", "mp");
            mynote.Play("A#,4", "eigth", "mp"); 
            mynote.Play("C#,5", "eigth", "mp");
            mynote.Play("F,5", "quarter", "mp");
            mynote.Play("D#,5", "eigth", "mp");
            mynote.Play("C#,5", "eigth", "mp");
            mynote.Play("C,5", "dotquarter", "mp");
            mynote.Play("C#,5", "eigth", "mp");
            mynote.Play("D#,5", "quarter", "mp");
            mynote.Play("F,5", "quarter", "mp");
            mynote.Play("C#,5", "quarter", "mp");
            mynote.Play("A#,4", "quarter", "mp");
            mynote.Play("A#,4", "half", "mp");
        }
    }
}
