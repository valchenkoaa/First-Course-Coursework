using System;

namespace Home_Bookkeeper.Service
{
    [Serializable]
    /// <summary>
    /// Объект денег
    /// </summary>
    internal sealed class Money : ICorrect
    {
        private int _wholePart; // Целая часть баланса
        private int _decimalPart; // Часть после запятой

        /// <summary>
        /// Создаёт пустой экземмпляр класса Money
        /// </summary>
        public Money() { }

        /// <summary>
        /// Создаёт экземпляр класса Money
        /// </summary>
        /// <param name="wholePart"></param> целая часть суммы
        /// <param name="decimalPart"></param> часть после запятой суммы
        public Money(string input)
        {
            if (IsValid(input))
            {
                string[] inputs = input.Split(',');
                bool statusWhole = int.TryParse(inputs[0], out int output);
                WholePart = output;
                bool statucDecimal = int.TryParse(inputs[1], out output);
                DecimalPart = output;
                if (!statusWhole || !statucDecimal)
                    throw new ArgumentException("Строка, содержащая денежный тип должна состоять из цифр и запятой (***,**).");
            }
        }

        /// <summary>
        /// Свойство, определяющее правила вывода полей _wholePark, _decimalPark
        /// </summary>
        public string Balance => String.Format("{0},{1:00}", _wholePart, _decimalPart);

        /// <summary>
        /// Свойство определяющее правила записи в целой части в поле
        /// </summary>
        private int WholePart
        {
            get { return _wholePart; }
            set { if (value >= 0) _wholePart = value; else throw new ArgumentException("Некорректное входное значение.", "_wholePart"); }
        }

        /// <summary>
        /// Свойство определяющее правила записи в дробной части в поле
        /// </summary>
        private int DecimalPart
        {
            get { return _decimalPart; }
            set { if (value >= 0) _decimalPart = CheckDecimal(value); else throw new ArgumentException("Некорректное входное значение.", "_decimalPart"); }
        }

        #region Service
        /// <summary>
        /// Рекурсивное выделение целых частей из дробной
        /// </summary>
        /// <param name="input"></param> проверяемая дробная часть
        /// <returns>int input</returns>
        private int CheckDecimal(int input)
        {
            if (input >= 100)
            {
                WholePart += input / 100;
                return CheckDecimal(input % 100);
            }
            else
                return input;
        }

        /// <summary>
        /// Перевод к значению для арифметических операций
        /// </summary>
        /// <param name="money"></param> экземпляр для перевода
        /// <returns>int _decimalPart</returns>
        private int ToDecimal()
        {
            return WholePart * 100 + DecimalPart;
        }

        /// <summary>
        /// Проверяет правильность ввода строки
        /// </summary>
        /// <param name="input"></param> входная строка на проверку
        /// <returns>bool true/false</returns>
        public bool IsValid(string input)
        {
            if (!IsOnlyDigits(input))
                return false;

            string[] inputs = input.Split(',');
                if (inputs.Length == 2)
                    return true;
                else
                    throw new ArgumentException("Некорректно заданы входные данные.", "input");
        }

        /// <summary>
        /// Проверяет входную строку на содецржание только цифр
        /// </summary>
        /// <param name="input"></param> строка на проверку
        /// <returns>bool true/false</returns>
        public bool IsOnlyDigits(string input)
        {
            input = input.Replace(",", "");

            foreach (char digit in input)
                if (!((Int32.TryParse(digit.ToString(), out int result))))
                    return false;

            return true;
        }

        /// <summary>
        /// Клонирование объекта
        /// </summary>
        /// <returns></returns>
        public Money Clone()
        {
            Money clone = new Money();
            clone.DecimalPart = DecimalPart;
            clone.WholePart = WholePart;

            return clone;
        }
        #endregion Service

        #region Operators
        /// <summary>
        /// Переопределение бинарной операции сложения для экземпляра класса Money и Transaction
        /// </summary>
        /// <param name="money"></param> экземпляр класса Money
        /// <param name="transaction"></param> экземпляр класса Transaction
        /// <returns>Money output</returns>
        public static Money operator +(Money money, Finances.Transaction transaction)
        {
            Money output = new Money();
            output.DecimalPart = money.ToDecimal() + transaction.Ammount.ToDecimal();

            return output;
        }

        /// <summary>
        /// Переопределение бинарной операции вычитания для экземпляра класса Money и Transaction
        /// </summary>
        /// <param name="money"></param> экземпляр класса Money
        /// <param name="transaction"></param>экземпляр класса Transaction
        /// <returns>Money output</returns>
        public static Money operator -(Money money, Finances.Transaction transaction)
        {
            if (money.ToDecimal() >= transaction.Ammount.ToDecimal())
            {
                Money output = new Money();
                output.DecimalPart = money.ToDecimal() - transaction.Ammount.ToDecimal();

                return output;
            }
            else
                throw new ArithmeticException("Операция не может быть выполнена. Отрицательный результат при выполнении операции.");
        }

        /// <summary>
        /// Переопределение бинарной операции вычитания для экземпляров класса Money 
        /// </summary>
        /// <param name="one"></param> уменьшаемое
        /// <param name="two"></param>вычитаемое
        /// <returns>Money output</returns>
        public static Money operator -(Money one, Money two)
        {
            if (one.ToDecimal() >= two.ToDecimal())
            {
                Money output = new Money();
                output.DecimalPart = one.ToDecimal() - two.ToDecimal();
                return output;
            }
            else
                throw new ArithmeticException("Операция не может быть выполнена. Отрицательный результат при выполнении операции.");
        }
        #endregion
    }
}
