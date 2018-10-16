using System;

namespace Home_Bookkeeper.Finances
{
    [Serializable]
    internal sealed class Category
    {
        private string _categoryName; // Название категории
        private Service.Money _income; // Доход по категории
        private Service.Money _extense; // Расход по категории

        /// <summary>
        /// Создаёт новый экземпляр класса Category
        /// </summary>
        /// <param name="name"></param>
        public Category(string categoryName)
        {
            Name = categoryName;
            Income = new Service.Money();
            Extense = new Service.Money();
        }

        /// <summary>
        /// Создаёт новый экземпляр класса Category
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="income"></param>
        /// <param name="extense"></param>
        public Category(string categoryName, Service.Money income, Service.Money extense)
        {
            Name = categoryName;
            Income = income;
            Extense = extense;
        }

        /// <summary>
        /// Свойство доступа чтения и записи в поле _categoryName
        /// </summary>
        public string Name
        {
            get { return _categoryName; }
            set { if (value != null) _categoryName = value; else throw new ArgumentException("Некорректное входное значение.", "_categoryName"); }
        }

        /// <summary>
        /// Свойство доступа чтения и записи в поле _income
        /// </summary>
        public Service.Money Income
        {
            get => _income;
            set { if (value != null) _income = value; else throw new ArgumentException("Некорректное входное значение.", "_income"); }
        }

        /// <summary>
        /// Свойство доступа чтения и записи в поле _extense
        /// </summary>
        public Service.Money Extense
        {
            get => _extense;
            set { if (value != null) _extense = value; else throw new ArgumentException("Некорректное входное значение.", "_income"); }
        }

        public string GetIncome => Income.Balance;
        public string GetExtense => Extense.Balance;

        public Category Clone()
        {
            Category clone = new Category(Name);
            clone.Extense = Extense.Clone();
            clone.Income = Income.Clone();

            return clone;
        }
    }
}
