using System;

namespace Home_Bookkeeper.Wallet
{
    [Serializable]
    /// <summary>
    /// Любой счёт
    /// </summary>
    internal sealed class Account
    {
        private string _name; // Название счёта
        private Service.Money _amount; // Баланс

        public Account() { }

        public Account(string name, string amount)
        {
            Name = name;
            Amount = new Service.Money(amount);
        }

        public string Name
        {
            get => _name;
            set { if (value != null) _name = value; else throw new ArgumentException("Некорректное входное значение.", "_name"); }
        }

        public Service.Money Amount
        {
            get => _amount;
            set { if (value != null) _amount = value; else throw new ArgumentException("Некорректное входное значение.", "_amount"); }
        }

        public string Balance
        {
            get { return _amount.Balance;}
        }

        public Account Clone()
        {
            Account clone = new Account();
            clone.Amount = Amount.Clone();
            clone.Name = (string)Name.Clone();

            return clone;
        }
    }
}
