namespace Home_Bookkeeper.Service
{
    /// <summary>
    /// Интерфейс наследуется объектами, нуждающимися в проверке правильности числового ввода строкой
    /// </summary>
    internal interface ICorrect
    {
        /// <summary>
        /// Проверка правильности ввода
        /// </summary>
        /// <param name="input"></param> входная строка на проверку
        /// <returns>bool true/false</returns>
        bool IsValid(string input);
        /// <summary>
        /// Проверка строки на содержание только чисел
        /// </summary>
        bool IsOnlyDigits(string input);
    }
}
