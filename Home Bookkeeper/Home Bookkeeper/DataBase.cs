using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Home_Bookkeeper
{
    internal static class DataBase
    {
        private static string _fileName; // Имя файла
        private static bool _isSave = true; // Сохранён ли файл
        private static bool _isCancel = true; // Была ли отмена действия
        private static Wallet.PersonalAccount _personalAccount = new Wallet.PersonalAccount(); // Главный класс
        private static Wallet.PersonalAccount _bufPersonalAccount = new Wallet.PersonalAccount(); // Вспомогательный объект
        private static FileStream fileStream; // Стрим файла
        private static BinaryFormatter binaryFormatter = new BinaryFormatter(); // Бинарный форматтер

        /// <summary>
        /// Свойство, определяющее свойства доступа к полю _fileName
        /// </summary>
        private static string FileName
        {
            get => _fileName;
            set { if (value != null) _fileName = value; else throw new System.ArgumentException("Некорректное входное значение.", "_fileName"); }
        }

        /// <summary>
        /// Свойство доступа к полю _personalAccount
        /// </summary>
        public static Wallet.PersonalAccount PersonalAccount
        {
            get => _personalAccount;
            set { if (value != null) _personalAccount = value; else throw new System.ArgumentException("Некорректное входное значение.", "_personalAccount"); }
        }

        /// <summary>
        /// Свойство доступа к полю _bufPersonalAccount
        /// </summary>
        public static Wallet.PersonalAccount BufPersonalAccount
        {
            get => _bufPersonalAccount;
            set => _bufPersonalAccount = value.Clone();
        }

        /// <summary>
        /// Свойство доступа к полю _isSave
        /// </summary>
        public static bool IsSave
        {
            get => _isSave;
            set => _isSave = value;
        }

        /// <summary>
        /// Свойство доступа к полю _isCancel
        /// </summary>
        public static bool IsCancel
        {
            get => _isCancel;
            set => _isCancel = value;
        }

        /// <summary>
        /// Обнуляет файловый поток
        /// </summary>
        private static void NullFileStream()
        {
            fileStream.Close();
            fileStream = new FileStream(_fileName, FileMode.OpenOrCreate);
        }

        /// <summary>
        /// Записывает в файл объект класса PersonalAccount
        /// </summary>
        /// <param name="personalAccount"></param> объект класса PersonalAccount
        private static void Serialize()
        {
            if (!(IsSave == true))
                IsSave = !IsSave;
            binaryFormatter.Serialize(fileStream, PersonalAccount);
            NullFileStream();
        }

        /// <summary>
        /// Читает из файла объект класса PersonalAccount
        /// </summary>
        /// <returns>Wallet.PersonalAccount</returns>
        private static void Deserialize()
        {
            PersonalAccount = (Wallet.PersonalAccount)binaryFormatter.Deserialize(fileStream);
            NullFileStream();
        }

        /// <summary>
        /// Создаёт новый файл с указанным именем
        /// </summary>
        /// <param name="fileName"></param> имя файла
        /// <returns>Wallet.PersonalAccount</returns>
        public static void MakeFile(string fileName)
        {
            FileName = fileName;
            fileStream = new FileStream(_fileName, FileMode.Create);
            PersonalAccount = new Wallet.PersonalAccount();
            Serialize();
        }

        /// <summary>
        /// Открывает файл для чтения
        /// </summary>
        /// <param name="fileName"></param> имя открытого файла
        /// <returns>Wallet.PersonalAccount</returns>
        public static void OpenFile(string fileName)
        {
            FileName = fileName;
            if (fileStream != null)
                fileStream.Close();
            fileStream = new FileStream(_fileName, FileMode.Open);
            Deserialize();
        }

        /// <summary>
        /// Сохраняем объект в файл
        /// </summary>
        /// <param name="personalAccount"></param> сохраняемый объект
        public static void SaveFile()
        {
            if (_fileName == null)
                throw new System.SystemException("Нет файла для сохранения!");
            Serialize();
        }

        /// <summary>
        /// Сохраняем в новый файл, в указанное место
        /// </summary>
        /// <param name="personalAccount"></param> сериализуемый объект
        /// <param name="fileName"></param> файл, в который сериализуется объект
        public static void SaveFile(string fileName)
        {
            if (_fileName == null)
                throw new System.SystemException("Нет файла для сохранения");
            FileName = fileName;
            fileStream = new FileStream(_fileName, FileMode.Create);
            Serialize();
        }
    }
}
