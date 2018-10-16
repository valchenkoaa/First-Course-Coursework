using System;
using System.Collections.Generic;

namespace Home_Bookkeeper.Wallet
{
    [Serializable]
    /// <summary>
    /// Класс описывающий лицевой счёт пользователя
    /// Содержит описание полей названия счёта, его номера и служебной информации о нём
    /// </summary>
    internal sealed class PersonalAccount
    {
        private List<Account> _accounts; // Список счетов
        private List<Finances.Transaction> _transactions; // Список транзакций по счёту
        private List<Finances.Category> _categories; // Список категорий

        /// <summary>
        /// Создаёт новый экземпляр объекта
        /// </summary>
        public PersonalAccount()
        {
            Accounts = new List<Account>();
            Transactions = new List<Finances.Transaction>();
            Categories = new List<Finances.Category>();
        }

        /// <summary>
        /// Свойство доступа к чтению и записи поля _accounts
        /// </summary>
        public List<Account> Accounts
        {
            get { return _accounts; }
            set { _accounts = value; }
        }

        /// <summary>
        /// Свойство доступа к чтению и записи поля _transactions
        /// </summary>
        public List<Finances.Transaction> Transactions
        {
            get { return _transactions; }
            set { _transactions = value; }
        }

        /// <summary>
        /// Свойство доступа к чтению и записи поля _categories
        /// </summary>
        public List<Finances.Category> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        public PersonalAccount Clone()
        {
            PersonalAccount clone = new PersonalAccount();
            foreach (Account account in Accounts)
                clone.Accounts.Add(account.Clone());
            foreach (Finances.Category category in Categories)
                clone.Categories.Add(category.Clone());
            foreach (Finances.Transaction transaction in Transactions)
                clone.Transactions.Add(transaction.Clone());

            return clone;
        }
    }
}
