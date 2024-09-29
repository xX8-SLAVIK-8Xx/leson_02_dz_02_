﻿using System;

namespace leson_02_dz_02_
{
    internal partial class Program
    {
        public class Ukulele : MusicalInstrument
        {
            public string _pfoto = string.Empty;
            public string _describe_sound = string.Empty;
            public void OverrideDescription(string name, string description, string history, string pfoto, string describe_sound)
            {
                _name = name;
                _description = description;
                _history = history;
                _pfoto = pfoto;
                _describe_sound = describe_sound;
            }
            public Ukulele() : base("Укулеле", "Небольшая четырёхструнная гавайская гитара.", "Появилась в XIX веке на Гавайях.")
            {
            }
            public void Sound()
            {
                base.Sound("Укулеле издает яркий и весёлый звук.\n");
            }
            public override void PlaySound()
            {
                int duration = 5000;
                int steps = 50;
                int minFrequency = 400;
                int maxFrequency = 800;
                for (int i = 0; i < steps; i++)
                {
                    int frequency = minFrequency + (maxFrequency - minFrequency) * i / steps;
                    Console.Beep(frequency, duration / steps);
                }
            }
            public override void Pfoto()
            {
                Console.WriteLine("Фото");
                Console.WriteLine("====================\r\n|    ######        |\r\n|   #      #     | |\r\n|  #        #    | |\r\n|  #   ##   #    | |\r\n|   #  ##  #     | |\r\n|    ######      | |\r\n|     #  #       | |\r\n|     #  #       | |\r\n|     #  #       | |\r\n|      ##        | |\r\n====================\r\n");
            }
        }
    }
}
