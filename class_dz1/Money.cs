using System;

namespace leson_02_dz_02_
{
    public class Money
    {
        private int _integer_part;
        private int _fractional_part;
        public float _total_amount;
        public Money(int integer_part = 0, int fractional_part = 0)
        {
            Exception(fractional_part);
            _integer_part = integer_part;
            _fractional_part = fractional_part;
            _total_amount = (((float)integer_part * 100) + (float)fractional_part) / 100;
        }
        public void Exception(int fractional_part)
        {
            if (fractional_part < 0)
            {
                throw new ArgumentException("Дробная часть не может быть меньше 0");
            }
            if (fractional_part >= 100)
            {
                throw new ArgumentException("Дробная часть  не может быть больше 100");
            }
        }
        public void SetAmountMoney(int integer_part = 0, int fractional_part = 0)
        {
            Exception(fractional_part);
            _integer_part = integer_part;
            _fractional_part = fractional_part;
            _total_amount = (((float)integer_part * 100) + (float)fractional_part) / 100;
        }
        public void ShowAmountMoney()
        {
            Console.WriteLine(_total_amount);
        }
        public void MinusMoney(int integer_part, int fractional_part)
        {
            Exception(fractional_part);

            int общая_сума_копеек = (integer_part * 100) + fractional_part;

            int общая_сума_копеек_2_ = (_integer_part * 100) + _fractional_part;

            _total_amount = (((float)общая_сума_копеек_2_ / 100) - ((float)общая_сума_копеек) / 100);

            _integer_part = (общая_сума_копеек_2_ - общая_сума_копеек) / 100;
            _fractional_part = (общая_сума_копеек_2_ - общая_сума_копеек) % 100;

        }
        public void PlusMoney(int integer_part, int fractional_part)
        {
            Exception(fractional_part);

            int общая_сума_копеек = (integer_part * 100) + fractional_part;

            int общая_сума_копеек_2_ = (_integer_part * 100) + _fractional_part;

            _total_amount = (((float)общая_сума_копеек_2_ / 100) + ((float)общая_сума_копеек) / 100);

            _integer_part = (общая_сума_копеек_2_ + общая_сума_копеек) / 100;
            _fractional_part = (общая_сума_копеек_2_ + общая_сума_копеек) % 100;
        }
    }
}
