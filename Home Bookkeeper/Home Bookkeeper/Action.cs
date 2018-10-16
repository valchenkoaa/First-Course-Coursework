using System;
using System.Collections.Generic;

namespace Home_Bookkeeper
{
    internal static class Action
    {
        public static void AddAccount(string accountName, string money)
        {
           SaveToCancel();
            if (!DataBase.PersonalAccount.Accounts.Exists(x => x.Name == accountName))
            {
                DataBase.PersonalAccount.Accounts.Add(new Wallet.Account(accountName, money));
                IsChanged();
            }
            else
                throw new DuplicateWaitObjectException(accountName, "Счёт с таким именем уже существует. Введите другое имя.");
        }

        public static void ChangeAccount(string accountName, string newAccountName)
        {
           SaveToCancel();
            if (accountName != "")
            {
                if (DataBase.PersonalAccount.Accounts.Exists(x => x.Name == accountName))
                {
                    if (!DataBase.PersonalAccount.Accounts.Exists(x => x.Name == newAccountName))
                    {
                        int index = -1;
                        foreach (Wallet.Account account in DataBase.PersonalAccount.Accounts)
                        {
                            index++;
                            if (account.Name == accountName)
                            {
                                break;
                            }
                        }
                        DataBase.PersonalAccount.Accounts[index] = new Wallet.Account(newAccountName, DataBase.PersonalAccount.Accounts[index].Balance);
                        foreach (Finances.Transaction transaction in DataBase.PersonalAccount.Transactions)
                            if (transaction.Place == accountName)
                                transaction.Place = newAccountName;
                        IsChanged();
                    }
                    else
                        throw new ArgumentException("Счёт с новым именем уже существует. Введите другое новое имя.", accountName);
                }
                else
                    throw new ArgumentException("Не найдено счёта с указанным именем.", accountName);
            }
        }

        public static void DeleteAccount(string accountName)
        {
           SaveToCancel();
            if (accountName != "")
            {
                if (DataBase.PersonalAccount.Accounts.Exists(x => x.Name == accountName))
                {
                    int index = -1;
                    foreach (Wallet.Account account in DataBase.PersonalAccount.Accounts)
                    {
                        index++;
                        if (account.Name == accountName)
                        {
                            break;
                        }
                    }
                    DataBase.PersonalAccount.Accounts.RemoveAt(index);
                    List<Finances.Transaction> transactions = new List<Finances.Transaction>();
                    foreach (Finances.Transaction transaction in DataBase.PersonalAccount.Transactions)
                        if (transaction.Place == accountName)
                        {
                            transactions.Add(transaction);
                            int indexCat = -1;
                            foreach (Finances.Category category in DataBase.PersonalAccount.Categories)
                            {
                                indexCat++;
                                if (category.Name == transaction.Category)
                                {
                                    break;
                                }
                            }
                            if (transaction.IsIncome)
                                DataBase.PersonalAccount.Categories[index].Income -= transaction;
                            else
                                DataBase.PersonalAccount.Categories[index].Extense -= transaction;
                        }
                    foreach (Finances.Transaction transaction in transactions)
                        DataBase.PersonalAccount.Transactions.Remove(transaction);
                    IsChanged();
                }
                else
                    throw new ArgumentException("Не найдено счёта с указанным именем.", accountName);
            }
        }

        public static void AddCategory(string categoryName)
        {
            SaveToCancel();
            DataBase.BufPersonalAccount = DataBase.PersonalAccount;
            if (!DataBase.PersonalAccount.Categories.Exists(x => x.Name == categoryName))
            {
                DataBase.PersonalAccount.Categories.Add(new Finances.Category(categoryName));
                IsChanged();
            }
            else
                throw new DuplicateWaitObjectException(categoryName, "Такая категория уже существует. Введите другое имя.");
        }

        public static void ChangeCategory(string categoryName, string newCategoryName)
        {
            SaveToCancel();
            if (categoryName != "")
            {
                if (DataBase.PersonalAccount.Categories.Exists(x => x.Name == categoryName))
                {
                    if (!DataBase.PersonalAccount.Categories.Exists(x => x.Name == newCategoryName))
                    {
                        int index = -1;
                        foreach (Finances.Category category in DataBase.PersonalAccount.Categories)
                        {
                            index++;
                            if (category.Name == categoryName)
                            {
                                break;
                            }
                        }
                        DataBase.PersonalAccount.Categories[index] = new Finances.Category(newCategoryName, DataBase.PersonalAccount.Categories[index].Income, DataBase.PersonalAccount.Categories[index].Extense);
                        foreach (Finances.Transaction transaction in DataBase.PersonalAccount.Transactions)
                            if (transaction.Category == categoryName)
                                transaction.Category = newCategoryName;
                        IsChanged();
                    }
                    else
                        throw new ArgumentException("Категория с новым именем уже существует. Введите другое новое имя.", categoryName);
                }
                else
                    throw new ArgumentException("Не найдено указанной категории.", categoryName);
            }
        }

        public static void DeleteCategory(string categoryName)
        {
           SaveToCancel();
            if (categoryName != "")
            {
                if (DataBase.PersonalAccount.Categories.Exists(x => x.Name == categoryName))
                {
                    int index = -1;
                    foreach (Finances.Category category in DataBase.PersonalAccount.Categories)
                    {
                        index++;
                        if (category.Name == categoryName)
                        {
                            break;
                        }
                    }
                    DataBase.PersonalAccount.Categories.RemoveAt(index);
                    List<Finances.Transaction> transactions = new List<Finances.Transaction>();
                    foreach (Finances.Transaction transaction in DataBase.PersonalAccount.Transactions)
                        if (transaction.Category == categoryName)
                            transactions.Add(transaction);
                    foreach (Finances.Transaction transaction in transactions)
                    {
                        int indexAcc = -1;
                        foreach (Wallet.Account account in DataBase.PersonalAccount.Accounts)
                        {
                            indexAcc++;
                            if (account.Name == transaction.Place)
                            {
                                break;
                            }
                        }
                        if (transaction.IsIncome)
                            DataBase.PersonalAccount.Accounts[indexAcc].Amount -= transaction;
                        else
                            DataBase.PersonalAccount.Accounts[indexAcc].Amount += transaction;
                        DataBase.PersonalAccount.Transactions.Remove(transaction);
                    }
                    IsChanged();
                }
                else
                    throw new ArgumentException("Не найдено указанной категории.", categoryName);
            }
        }
        
        public static void AddTransaction(string accountName, string categoryName, string articleName, string money, DateTime dateTime, bool income)
        {
           SaveToCancel();
            if (DataBase.PersonalAccount.Accounts.Exists(x => x.Name == accountName))
            {
                int indexPlace = -1;
                foreach (Wallet.Account account in DataBase.PersonalAccount.Accounts)
                {
                    indexPlace++;
                    if (account.Name == accountName)
                    {
                        break;
                    }
                }
                if (DataBase.PersonalAccount.Categories.Exists(x => x.Name == categoryName))
                {
                    int index = -1;
                    foreach (Finances.Category category in DataBase.PersonalAccount.Categories)
                    {
                        index++;
                        if (category.Name == categoryName)
                        {
                            break;
                        }
                    }
                    Finances.Transaction thisTransaction = new Finances.Transaction(money, categoryName, articleName, accountName, dateTime, income);
                    if (thisTransaction.IsIncome)
                    {
                        DataBase.PersonalAccount.Accounts[indexPlace].Amount += thisTransaction;
                        DataBase.PersonalAccount.Categories[index].Income += thisTransaction;
                    }
                    else
                    {
                        DataBase.PersonalAccount.Accounts[indexPlace].Amount -= thisTransaction;
                        DataBase.PersonalAccount.Categories[index].Extense += thisTransaction;
                    }

                    DataBase.PersonalAccount.Transactions.Add(thisTransaction);
                    IsChanged();
                }
                else
                    throw new ArgumentException("Не найдено указанной категории.", categoryName);
            }
            else
                throw new ArgumentException("Не найдено счёта с указанным именем.", accountName);
        }

        public static void ChangeTransaction(Finances.Transaction oldTransaction, string newAccountName, string newCategoryName, string newArticleName, string newMoney, DateTime newDateTime, bool newIncome)
        {
           SaveToCancel();
            if (DataBase.PersonalAccount.Transactions.Contains(oldTransaction))
            {
                if (DataBase.PersonalAccount.Accounts.Exists(x => x.Name == oldTransaction.Place))
                {
                    int indexPlace = -1;
                    foreach (Wallet.Account account in DataBase.PersonalAccount.Accounts)
                    {
                        indexPlace++;
                        if (account.Name == oldTransaction.Place)
                        {
                            break;
                        }
                    }
                    if (DataBase.PersonalAccount.Categories.Exists(x => x.Name == oldTransaction.Category))
                    {
                        int index = -1;
                        foreach (Finances.Category category in DataBase.PersonalAccount.Categories)
                        {
                            index++;
                            if (category.Name == oldTransaction.Category)
                            {
                                break;
                            }
                        }
                        int indexTran = -1;
                        foreach (Finances.Transaction tran in DataBase.PersonalAccount.Transactions)
                        {
                            indexTran++;
                            if (tran.Equals(oldTransaction))
                            {
                                break;
                            }
                        }
                        Finances.Transaction thisTransaction = new Finances.Transaction(newMoney, newCategoryName, newArticleName, newAccountName, newDateTime, newIncome);
                        if (oldTransaction.IsIncome)
                        {
                            DataBase.PersonalAccount.Accounts[indexPlace].Amount -= oldTransaction;
                            DataBase.PersonalAccount.Categories[index].Income -= oldTransaction;
                        }
                        else
                        {
                            DataBase.PersonalAccount.Accounts[indexPlace].Amount += oldTransaction;
                            DataBase.PersonalAccount.Categories[index].Extense -= oldTransaction;
                        }
                        if (thisTransaction.IsIncome)
                        {
                            DataBase.PersonalAccount.Accounts[indexPlace].Amount += thisTransaction;
                            DataBase.PersonalAccount.Categories[index].Income += thisTransaction;
                        }
                        else
                        {
                            DataBase.PersonalAccount.Accounts[indexPlace].Amount -= thisTransaction;
                            DataBase.PersonalAccount.Categories[index].Extense += thisTransaction;
                        }

                        DataBase.PersonalAccount.Transactions[indexTran] = thisTransaction;
                        IsChanged();
                    }
                    else
                        throw new ArgumentException("Не найдено указанной категории.", oldTransaction.Category);
                }
                else
                    throw new ArgumentException("Не найдено счёта с указанным именем.", oldTransaction.Place);
            }
            else
                throw new ArgumentException("Не найдена указанная транзакция.");
        }

        public static void DeleteTransaction(string accountName, string categoryName, string articleName, string money, DateTime dateTime, bool income)
        {
            SaveToCancel();
            Finances.Transaction oldTransaction = new Finances.Transaction(money, categoryName, articleName, accountName, dateTime, income);
            if (DataBase.PersonalAccount.Transactions.Contains(oldTransaction))
            {
                if (DataBase.PersonalAccount.Accounts.Exists(x => x.Name == accountName))
                {
                    int indexPlace = -1;
                    foreach (Wallet.Account account in DataBase.PersonalAccount.Accounts)
                    {
                        indexPlace++;
                        if (account.Name == accountName)
                        {
                            break;
                        }
                    }
                    int indexTran = -1;
                    foreach (Finances.Transaction tran in DataBase.PersonalAccount.Transactions)
                    {
                        indexTran++;
                        if (tran.Equals(oldTransaction))
                        {
                            break;
                        }
                    }
                    int index = -1;
                    foreach (Finances.Category category in DataBase.PersonalAccount.Categories)
                    {
                        index++;
                        if (category.Name == oldTransaction.Category)
                        {
                            break;
                        }
                    }
                    if (oldTransaction.IsIncome)
                        DataBase.PersonalAccount.Accounts[indexPlace].Amount -= oldTransaction;
                    else
                        DataBase.PersonalAccount.Accounts[indexPlace].Amount += oldTransaction;
                    if (oldTransaction.IsIncome)
                        DataBase.PersonalAccount.Categories[index].Income -= oldTransaction;
                    else
                        DataBase.PersonalAccount.Categories[index].Extense -= oldTransaction;
                    DataBase.PersonalAccount.Transactions.RemoveAt(indexTran);
                    IsChanged();
                }
            }
            else
                throw new ArgumentException("Не найдена указанная транзакция.");
        }

        public static void CancelAction()
        {
            if (!DataBase.IsCancel)
            {
                DataBase.PersonalAccount = DataBase.BufPersonalAccount.Clone();
                DataBase.BufPersonalAccount = new Wallet.PersonalAccount();
                DataBase.IsCancel = true;
            }
            else
                throw new SystemException("Нет действий для отмены!");
        }

        private static void IsChanged()
        {
            DataBase.IsSave = false;
            DataBase.IsCancel = false;
        }

        private static void SaveToCancel()
        {
            DataBase.BufPersonalAccount = DataBase.PersonalAccount.Clone();
        }
    }
}
