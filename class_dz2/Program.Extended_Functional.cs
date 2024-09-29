using System;

namespace leson_02_dz_02_
{
    internal partial class Program
    {
        public class /*Skrypka*/ Extended_Functional : MusicalInstrument
        {
            public string _pfoto = "====================\n|    ######        |\n|   #      #     | |\n|  #        #    | |\n|  #        #    | |\n|   #      #     | |\n|    ######      | |\n|     #  #       | |\n|     #  #       | |\n|     ####       | |\n|      ##        | |\n====================";

            public string _describe_sound = "Скрипка издает нежный и высокий звук";
            public Extended_Functional(string name, string description, string history, string describe_sound, string pfoto = "") : base(name, description, history /*"Скрипка", "Смычковый инструмент с четырьмя струнами.", "Изобретена в XVI веке в Италии."*/)
            {
                _name = name;
                _description = description;
                _history = history;
                _describe_sound = describe_sound;
                _pfoto = pfoto;
            }
            public void Sound()
            {
                base.Sound($"{_describe_sound} \n");
            }
            public void PlaySound(int duration = 5000, int steps = 50, int minFrequency = 150, int maxFrequency = 300)
            {
                for (int i = 0; i < steps; i++)
                {
                    int frequency = minFrequency + (maxFrequency - minFrequency) * i / steps;
                    Console.Beep(frequency, duration / steps);
                }
            }
            public override void Pfoto()
            {
                Console.WriteLine($"Фото {_name}"); ;
                Console.WriteLine(_pfoto);
            }
            public void OverrideDescription(string name, string description, string history, string pfoto, string describe_sound)
            {
                _name = name;
                _description = description;
                _history = history;
                _pfoto = pfoto;
                _describe_sound = describe_sound;
            }
            public /*static*/ void ShowInsrtument(Extended_Functional skrypka)
            {
                void Line() => Console.WriteLine("==========================================================================================================");

                Line();
                skrypka.Show();
                skrypka.Desc();
                skrypka.History();
                skrypka.Sound();
                Line();
                skrypka.Pfoto();
                Line();
            }
        }
    }
}
