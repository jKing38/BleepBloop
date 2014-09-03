using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BleepBloop
{
    public class Note
    {
        int[,] notesArray = new int[12, 8] { { 16, 33, 65, 131, 262, 523, 1046, 2093 },    //C
                                             { 17, 35, 69, 139, 277, 554, 1109, 2217 },    //C#
                                             { 18, 37, 73, 147, 294, 587, 1175, 2349 },    //D
                                             { 19, 39, 78, 155, 311, 622, 1244, 2489 },    //D#
                                             { 21, 41, 82, 165, 330, 659, 1328, 2637 },    //E
                                             { 22, 44, 87, 175, 349, 698, 1397, 2794 },    //F
                                             { 23, 46, 92, 185, 370, 740, 1480, 2960 },    //F#
                                             { 24, 49, 98, 196, 392, 784, 1568, 3136 },    //G
                                             { 26, 52, 104, 208, 415, 831, 1661, 3322 },   //G# 
                                             { 27, 55, 110, 220, 440, 880, 1760, 3520 },   //A
                                             { 29, 58, 116, 233, 466, 932, 1865, 3729 },   //A#
                                             { 31, 62, 123, 245, 494, 988, 1975, 3951 } }; //B

        Dictionary<string, int> notes = new Dictionary<string, int>()
        {
            {"C", 0},
            {"C#", 1},
            {"D", 2},
            {"D#", 3},
            {"E", 4},
            {"F", 5},
            {"F#", 6},
            {"G", 7},
            {"G#", 8},
            {"A", 9},
            {"A#", 10},
            {"B", 11},
        };

        Dictionary<string, int> volume = new Dictionary<string, int>()
        {
            {"pp", 100},
            {"p", 200},
            {"mp", 300},
            {"mf", 400},
            {"f", 500},
            {"ff", 600}
        };

        Dictionary<string, int> noteLengths = new Dictionary<string, int>()
        {
            {"whole", 2000},
            {"half", 1000},
            {"quarter", 500},
            {"eigth", 250},
            {"sixteenth", 125}
        };

        public void Play(string noteCode, string length, string volume)
        {
            string[] result = noteCode.Split(',');
            int notelength = GetNoteLength(length);
            int volumeLevel = GetVolume(volume);
            int octave, frequency;
            string noteName = result[0];

            if (int.TryParse(result[1], out octave))
            {
                frequency = GetFrequency(noteName, octave);
                Beep.BeepBeep(volumeLevel, frequency, notelength);
            }
            else
            {
                throw new Exception("Not Valid Octave");
            }

        }
        public int GetFrequency(string note, int octave)
        {
            if (notes.ContainsKey(note))
            {
                return notesArray[notes[note], octave];
            }
            else
            {
                throw new Exception("Not Valid Note Name");
            }
        }
        public int GetVolume(string noteVolume)
        {
            if (volume.ContainsKey(noteVolume))
            {
                return volume[noteVolume.ToLower()];
            }
            else
            {
                throw new Exception("Not Valid Note Volume");
            }
        }
        public int GetNoteLength(string noteLength)
        {
            if (noteLengths.ContainsKey(noteLength))
            {
                return noteLengths[noteLength.ToLower()];
            }
            else
            {
                throw new Exception("Not Valid Note Length");
            }
        }
    }
}
