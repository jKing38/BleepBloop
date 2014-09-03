using System;
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
            //Frequency Of Notes
                                             //Across: Octaves 0-7
            int[,] notes = new int[12, 8] { { 16, 33, 65, 131, 262, 523, 1046, 2093 }, //C
                                            { 17, 35, 69, 139, 277, 554, 1109, 2217 }, //C#
                                            { 18, 37, 73, 147, 294, 587, 1175, 2349 }, //D
                                            { 19, 39, 78, 155, 311, 622, 1244, 2489 }, //D#
                                            { 21, 41, 82, 165, 330, 659, 1328, 2637 }, //E
                                            { 22, 44, 87, 175, 349, 698, 1397, 2794 }, //F
                                            { 23, 46, 92, 185, 370, 740, 1480, 2960 }, //F#
                                            { 24, 49, 98, 196, 392, 784, 1568, 3136 }, //G
                                            { 26, 52, 104, 208, 415, 831, 1661, 3322 },//G# 
                                            { 27, 55, 110, 220, 440, 880, 1760, 3520 },//A
                                            {29, 58, 116, 233, 466, 932, 1865, 3729 }, //A#
                                            { 31, 62, 123, 245, 494, 988, 1975, 3951 } }; //B
            Thread.Sleep(500);
            Beep.BeepBeep(500, notes[0, 5], 500);
            Beep.BeepBeep(500, notes[2, 5], 500);
            Beep.BeepBeep(500, notes[4, 5], 500);
            Beep.BeepBeep(500, notes[5, 5], 500);
            Beep.BeepBeep(500, notes[7, 5], 500);
            Beep.BeepBeep(500, notes[9, 5], 500);
            Beep.BeepBeep(500, notes[11, 5], 500);
            Beep.BeepBeep(500, notes[0, 6], 500);
            //Beep.BeepBeep(500, notes[7, 5], 500);
            //Beep.BeepBeep(500, notes[8, 5], 500);
            //Beep.BeepBeep(500, notes[9, 5], 500);
            
            
        }
    }
}
