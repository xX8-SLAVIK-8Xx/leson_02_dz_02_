using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leson_02_dz_02_
{
    internal partial class Program
    {
        struct DecimalNumber
        {
            public int _value { get; set; }
            public DecimalNumber(int value)
            {
                _value = value;
            }            
            public string ToBinary()
            {
                return Convert.ToString(_value, 2);
            }           
            public string ToOctal()
            {
                return Convert.ToString(_value, 8);
            }            
            public string ToHexadecimal()
            {
                return Convert.ToString(_value, 16).ToUpper();
            }
        }
             
        public static void Line() => Console.WriteLine("==========================================================================================================");
        static void Main(string[] args)
        {
            var warehouse = new List<Product>();
            int integer_number;
            int fractional_number;
            string name_produkt;
            int counter = 0;
            bool _flag_true_false = true;
            while (_flag_true_false)
            {

                try
                {
                    Console.Clear();
                    Line();
                    Console.WriteLine("Класы и методы находятся в (Обозреватель решений (всё сложенно по папкам ))");
                    Line();
                    Console.WriteLine("Выбор домашней работы                                           :\n" +
                                      "1)Задание 1 (ООП) Запрограммируйте класс Money                  :\n" +
                                      "2)Задание 2 (ООП) Создать базовый  класс Музыкальный инструмент :\n" +
                                      "3)Задание 3 (Структуры)  Создайте  структуру «Десятичное число» :\n" +
                                      "4)Exit                                                          :");
                    Line();
                    action action = (action)int.Parse(Console.ReadLine());
                    switch (action)
                    {
                        case Program.action.Dz1:
                            while (true)
                            {
                                try
                                {
                                    bool flag_exit = true;
                                    Console.Clear();
                                    Line();
                                    Console.WriteLine();
                                    Console.WriteLine("   /=====================================\\ \n  / --------------------------------------\\\n / ########################################\\ \n/   # |оптовый склад пищевой продукции| #   \\\n    #     [ ]       ||         [ ]      #\n    #####################################");
                                    Console.WriteLine();
                                    Line();
                                    Console.WriteLine("1)Добавиь новый товар :");
                                    Console.WriteLine("2)Посмотреть склад    :");
                                    Console.WriteLine("3)Exit                :");
                                    Line();
                                    Action_three_elements action_three___elements = (Action_three_elements)int.Parse(Console.ReadLine());
                                    switch (action_three___elements)
                                    {   //Да тут с названием enume надо мне поработать :( 
                                        case Action_three_elements.action_one:
                                            bool flag_true_false = true;
                                            while (flag_true_false)
                                            {
                                                try
                                                {                                               
                                                    Console.Clear();
                                                    Line();
                                                    Console.Write("Наиминование продукта                : ");
                                                    name_produkt = Console.ReadLine();
                                                    
                                                    Console.Write("Укажите ценау продукта целая часть   : ");
                                                    integer_number = int.Parse(Console.ReadLine());
                                                    
                                                    Console.Write("Укажите ценау продукта дробная часть : ");
                                                    fractional_number = int.Parse(Console.ReadLine());                                                    
                                                    var produkt = new Product(name_produkt, integer_number, fractional_number);
                                                    warehouse.Add(produkt);
                                                    Line();
                                                    Console.WriteLine("Товар добавлен на склад              :");
                                                    Line();
                                                    Console.WriteLine("1)Добавиь новый товар :");
                                                    Console.WriteLine("2)Exit                :");
                                                    Line();
                                                    var action_ = int.Parse(Console.ReadLine());
                                                    if (action_ == 2) { flag_true_false = false; }
                                                    else { continue; }                                                    
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                    Console.ReadLine();
                                                    continue;
                                                }
                                            }
                                            break;
                                        case Action_three_elements.action_two:
                                            bool flag_true_false2 = true;
                                            while (flag_true_false2)
                                            {
                                                try
                                                {                                                
                                                    Console.Clear();
                                                    Line();
                                                    if (counter == 0) { Console.WriteLine("Склад пуст:"); }
                                                    else { Console.WriteLine("Склад     :"); }
                                                    Line();
                                                    counter = 0;
                                                    foreach (var item in warehouse)
                                                    {
                                                        ++counter;
                                                        Console.WriteLine($"Index    : №{counter}");
                                                        item.ShowProduct();
                                                        Line();
                                                    }
                                                    Console.WriteLine("1)Снизить   цену товара  :\n" +
                                                                      "2)Увеличить цену товара  :\n" +
                                                                      "3)Удалить товар          :\n" +
                                                                      "4)Exit                   :");
                                                    Action_three_elements action_three_elements = (Action_three_elements)int.Parse(Console.ReadLine());
                                                    switch (action_three_elements)
                                                    {
                                                        case Action_three_elements.action_one:
                                                            //снизить цену
                                                            try
                                                            {
                                                                Console.Write("Укажите Index товара                 : ");
                                                                int index_item = int.Parse(Console.ReadLine());
                                                                index_item -= 1;
                                                                Console.Write("Минус от цены продукта целая часть   : ");
                                                                integer_number = int.Parse(Console.ReadLine());
                                                                Console.Write("Минус от цены продукта дробная часть : ");
                                                                fractional_number = int.Parse(Console.ReadLine());
                                                                var produkt = warehouse[index_item];
                                                                produkt.ReducePriceMinus(integer_number, fractional_number);
                                                                warehouse[index_item] = produkt;
                                                                Console.WriteLine("Цена сниженна : ");
                                                                Console.ReadLine();

                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine(ex.Message);
                                                                Console.ReadLine();
                                                                continue;
                                                            }
                                                            break;
                                                        case Action_three_elements.action_two:
                                                            //добавить цену
                                                            try
                                                            {
                                                                Console.Write("Укажите Index товара : ");
                                                                int index_item_ = int.Parse(Console.ReadLine());
                                                                index_item_ -= 1;
                                                                Console.WriteLine();
                                                                Console.Write("Пдюс к цене продукта целая часть     : ");
                                                                integer_number = int.Parse(Console.ReadLine());
                                                                Console.WriteLine();
                                                                Console.Write("Пдюс к цене продукта дробная часть : ");
                                                                fractional_number = int.Parse(Console.ReadLine());
                                                                Console.WriteLine();
                                                                var produkt_ = warehouse[index_item_];
                                                                produkt_.IncreasePricePlus(integer_number, fractional_number);
                                                                warehouse[index_item_] = produkt_;
                                                                Console.WriteLine("Цена увеличена  : ");
                                                                Console.ReadLine();
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine(ex.Message);
                                                                Console.ReadLine();
                                                                continue;
                                                            }
                                                            break;
                                                        case Action_three_elements.action_three:
                                                            //удалить товар из списка 
                                                            try
                                                            {
                                                                Console.Write("Укажите Index товара : ");
                                                                int index_item__ = int.Parse(Console.ReadLine());
                                                                index_item__ -= 1;
                                                                Console.WriteLine();
                                                                warehouse.RemoveAt(index_item__);
                                                                Console.WriteLine("Товар удалён   : ");
                                                                Console.ReadLine();
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine(ex.Message);
                                                                Console.ReadLine();
                                                                continue;
                                                            }
                                                            break;
                                                        default:
                                                            flag_true_false2 = false;
                                                            break;
                                                }
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                    Console.ReadLine();
                                                    continue;
                                                }
                                            }    
                                            break;
                                        case Action_three_elements.action_three:
                                            flag_exit = false;
                                            break;
                                        default:
                                            flag_exit = false;
                                            break;
                                    }
                                    if (flag_exit == false) { break; }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    Console.ReadLine();
                                    continue;
                                }

                                //var money = new Money();
                                //    money.ShowAmountMoney();
                                //    money.SetAmountMoney(100, 10);
                                //    money.ShowAmountMoney();
                                //    money.MinusMoney(200, 20);
                                //    money.ShowAmountMoney();
                                //    money.PlusMoney(100, 45);
                                //    money.ShowAmountMoney();
                                //    money.PlusMoney(100, 5);
                                //    money.ShowAmountMoney();
                                //    money.PlusMoney(000, 6);
                                //    money.ShowAmountMoney();

                                //    var product = new Product("Пицца", 100, 10);
                                //    product.ShowProduct();
                                //    product.ReducePriceMinus(100, 10);
                                //    product.ShowProduct();
                                //    product.IncreasePricePlus(100, 10);
                                //    product.ShowProduct();
                                //    product.ShowProduct();
                                //    Console.ReadLine();
                            }
                            break;
                        case Program.action.Dz2:
                            //эта правильная реализация 
                            //======================================================================================================================================================
                            string pfoto_skrypka = "====================\n|    ######        |\n|   #      #     | |\n|  #        #    | |\n|  #        #    | |\n|   #      #     | |\n|    ######      | |\n|     #  #       | |\n|     #  #       | |\n|     ####       | |\n|      ##        | |\n====================";
                            string sound_skrypka = "Скрипка издает нежный и высокий звук";
                            string name_skrypka = "Скрипка";
                            string description_skrypka = "Смычковый инструмент с четырьмя струнами.";
                            string history_skrypka = "Изобретена в XVI веке в Италии.";
                            // int musik_skrypka = 5000; int steps = 50; int minFrequency = 150; int maxFrequency = 300; для функции        
                            var skrypka = new Extended_Functional(name_skrypka, description_skrypka, history_skrypka, sound_skrypka, pfoto_skrypka);
                            //======================================================================================================================================================


                            var Trombone = new Trombone();
                            var Ukulele = new Ukulele();
                            var Violoncello = new Violoncello();
                            bool _ttrue_false = true;
                            while (_ttrue_false)
                            {
                                Console.Clear();
                                try
                                {
                                    //эта правильная реализация
                                    //===============================================================================================================================================
                                    skrypka.ShowInsrtument(skrypka);
                                    //Skrypka.Show();
                                    //Skrypka.Desc();
                                    //Skrypka.History();
                                    //Skrypka.Sound();
                                    //Line();
                                    //Skrypka.Pfoto();                    
                                    //Line();
                                    //===============================================================================================================================================

                                    //остальное я эксперементировал :)
                                    Trombone.Show();
                                    Trombone.Desc();
                                    Trombone.History();
                                    Trombone.Sound();
                                    Line();
                                    Trombone.Pfoto();
                                    //Trombone.PlaySound();//звук
                                    Line();
                                    Ukulele.Show();
                                    Ukulele.Desc();
                                    Ukulele.History();
                                    Ukulele.Sound();
                                    Line();
                                    Ukulele.Pfoto();
                                    // Ukulele.PlaySound(); //звук
                                    Line();
                                    Violoncello.Show();
                                    Violoncello.Desc();
                                    Violoncello.History();
                                    Violoncello.Sound();
                                    Line();
                                    Violoncello.Pfoto();
                                    //Violoncello.PlaySound(); //звук                   
                                    Line();
                                    Violoncello.OverrideDescription("", "", "", "", "");
                                    Violoncello.Show();
                                    Violoncello.Desc();
                                    Violoncello.History();
                                    Violoncello.Sound();
                                    Line();
                                    Console.WriteLine("Включить звук  :");
                                    Console.WriteLine("1)Скрипка      :\n" +
                                                      "2)Тромбон      :\n" +
                                                      "3)Укулеле      :\n" +
                                                      "4)Виолончель   :\n" +
                                                      "5)Exit         :");
                                    Line();
                                    Musik musik = (Musik)int.Parse(Console.ReadLine());
                                    switch (musik)
                                    {
                                        case Musik.Skrypka:
                                            skrypka.PlaySound();
                                            break;
                                        case Musik.Trombone:
                                            Trombone.PlaySound();
                                            break;
                                        case Musik.Ukulele:
                                            Ukulele.PlaySound();
                                            break;
                                        case Musik.Violoncello:
                                            Violoncello.PlaySound();
                                            break;
                                        default:
                                            _ttrue_false = false;
                                            break;
                                    }
                                }
                                catch
                                {
                                    continue;
                                }
                            }
                            break;
                            break;
                        case Program.action.Dz3:
                            Console.Clear();
                            Line();
                            Console.Write("Введите десятичное число       : ");
                            int input = int.Parse(Console.ReadLine());
                            DecimalNumber num = new DecimalNumber(input);
                            Console.WriteLine("Двоичное представление         : " + num.ToBinary());
                            Console.WriteLine("Восьмеричное представление     : " + num.ToOctal());
                            Console.WriteLine("Шестнадцатеричное представление: " + num.ToHexadecimal());
                            Line();
                            Console.ReadLine();
                            
                            break;
                        default:
                            _flag_true_false = false;
                            break;
                    }
                }
                catch (Exception)
                {
                    continue;
                };
                //

            }
        }
    }
}
