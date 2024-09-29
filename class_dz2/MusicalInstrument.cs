using System;

namespace leson_02_dz_02_
{
    internal partial class Program
    {
        public class MusicalInstrument
        {
            public string _name { get; set; }
            public string _description { get; set; }
            public string _history { get; set; }

            public MusicalInstrument(string name, string description, string history)
            {
                _name = name;
                _description = description;
                _history = history;
            }
            public void OverrideDescription(string name, string description, string history)
            {
                _name = name;
                _description = description;
                _history = history;
            }
            public virtual void PlaySound()
            {
                Console.WriteLine("Вставить звук");
            }
            public virtual void Pfoto()
            {
                Console.WriteLine("Вставить фото");
            }
            public void Sound(string text_name_sound)
            {
                Console.Write($"Звук музыкального инструмента        : {text_name_sound}");
            }
            public void Show()
            {
                Console.WriteLine($"Название инструмента                 : {_name}");
            }
            public void Desc()
            {
                Console.WriteLine($"Описание                             : {_description}");
            }
            public void History()
            {
                Console.WriteLine($"История                              : {_history}");
            }
        }
    }
}
