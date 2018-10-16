using System;

namespace Home_Bookkeeper.Finances
{
    [Serializable]
    internal class Transaction : IEquatable<Transaction>
    {
        private Service.Money _ammount; // Сумма
        private string _category; // Категория
        private string _article; // Статья
        private DateTime _date; // Дата
        private string _place; // Место, списания/зачисления
        private bool _isIncome; // Приход/расход

        public Transaction() { }

        /// <summary>
        /// Вызывается наследуюмыми классами для создания экземпляра класса 
        /// </summary>
        /// <param name="ammount"></param> размер операции
        /// <param name="category"></param> статья операции
        /// <param name="date"></param> дата операции
        public Transaction(string ammount, string category, string article, string place, DateTime date, bool income)
        {
            Ammount = new Service.Money(ammount);
            Category = category;
            Article = article;
            Place = place;
            Date = date;
            IsIncome = income;
        }

        /// <summary>
        /// Свойство вывода в строку суммы транзакции
        /// </summary>
        public string Money
        {
            get => _ammount.Balance;
        }

        public string IncomeOrExtense
        {
            get { if (IsIncome) return "Доход"; else return "Расход"; }
        }

        /// <summary>
        /// Свойство чтения и записи поля _income
        /// </summary>
        public bool IsIncome
        {
            get => _isIncome;
            set => _isIncome = value;
        }
        
        /// <summary>
        /// Свойство чтения и записи поля _ammount
        /// </summary>
        public Service.Money Ammount
        {
            get { return _ammount; }
            set { if (value != null) _ammount = value; else throw new ArgumentException("Некорректное входное значение.", "_ammount"); }
        }

        /// <summary>
        /// Свойство чтения и записи поля _article
        /// </summary>
        public string Article
        {
            get { return _article; }
            set { if (value != null) _article = value; else throw new ArgumentException("Некорректное входное значение.", "_article"); }
        }

        /// <summary>
        /// Свойство чтения и записи поля _category
        /// </summary>
        public string Category
        {
            get { return _category; }
            set { if (value != null) _category = value; else throw new ArgumentException("Некорректное входное значение.", "_article"); }
        }

        /// <summary>
        /// Свойство чтения и записи поляю _date
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { if (value != null) _date = value; else throw new ArgumentException("Некорректное входное значение.", "_date"); }
        }

        /// <summary>
        /// Свойство чтения и записи поляю _place
        /// </summary>
        public string Place
        {
            get { return _place; }
            set { if (value != null) _place = value; else throw new ArgumentException("Некорректное входное значение.", "_place"); }
        }

        public Transaction Clone()
        {
            Transaction clone = new Transaction();
            clone.Ammount = Ammount.Clone();
            clone.Article = (string)Article.Clone();
            clone.Category = (string)Category.Clone();
            clone.Date = new DateTime(Date.Year, Date.Month, Date.Day);
            clone.IsIncome = IsIncome;
            clone.Place = (string)Place.Clone();

            return clone;
        }

        #region Operators
        /// <summary>
        /// Операция бинарного вычитания двух объектов Transaction
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public static Transaction operator -(Transaction one, Transaction two)
        {
            one.Ammount -= two.Ammount;
            return one;
        }

        public override bool Equals(object obj)
        {
            if (obj is Transaction)
                return Equals((Transaction)obj);
            return false;
        }

        public bool Equals(Transaction other)
        {
            if (Money == other.Money && _article == other._article && _category == other._category && _date == other._date && _place == other._place && _isIncome == other._isIncome)
                return true;
            return false;
        }
        #endregion
    }
}
