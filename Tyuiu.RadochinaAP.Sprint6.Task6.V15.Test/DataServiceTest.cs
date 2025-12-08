using System.IO;
using Tyuiu.RadochinaAP.Sprint6.Task6.V15.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Путь к тестовому файлу (в папке проекта)
            string path = @"C:\DataSprint6\InPutFileTask6V15.txt";
            Directory.CreateDirectory(@"C:\DataSprint6");

            // Создаем тестовый файл с правильным содержанием
            string[] testLines = {
                "Первая строка текста",
                "Вторая строка здесь",
                "Третья строка документа",
                "",
                "Строка с пробелами   ",
                "Еще одна строка теста"
            };

            File.WriteAllLines(path, testLines);

            // Выполняем метод
            string res = ds.CollectTextFromFile(path);
            string wait = "текста здесь документа пробелами теста";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void FileNotFound()
        {
            DataService ds = new DataService();
            string path = @"C:\NonExistentFolder\NonexistentFile.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "Файл не найден";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void EmptyFile()
        {
            DataService ds = new DataService();
            string tempPath = Path.Combine(Path.GetTempPath(), "TestEmptyFile.txt");

            try
            {
                File.WriteAllText(tempPath, "");
                string result = ds.CollectTextFromFile(tempPath);
                Assert.AreEqual("", result);
            }
            finally
            {
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
            }
        }

        [TestMethod]
        public void SingleLineFile()
        {
            DataService ds = new DataService();
            string tempPath = Path.Combine(Path.GetTempPath(), "TestSingleLine.txt");

            try
            {
                File.WriteAllText(tempPath, "Hello World");
                string result = ds.CollectTextFromFile(tempPath);
                Assert.AreEqual("World", result);
            }
            finally
            {
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
            }
        }

        [TestMethod]
        public void MultipleLinesFile()
        {
            DataService ds = new DataService();
            string tempPath = Path.Combine(Path.GetTempPath(), "TestMultipleLines.txt");

            try
            {
                string[] lines = {
                    "Первая строка текста",
                    "Вторая строка здесь",
                    "Третья строка документа"
                };

                File.WriteAllLines(tempPath, lines);
                string result = ds.CollectTextFromFile(tempPath);
                Assert.AreEqual("текста здесь документа", result);
            }
            finally
            {
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
            }
        }

        [TestMethod]
        public void TestWithSpecialCharacters()
        {
            DataService ds = new DataService();
            string tempPath = Path.Combine(Path.GetTempPath(), "TestSpecialChars.txt");

            try
            {
                string[] lines = {
                    "Строка с, запятой!",
                    "Еще одна? строка",
                    "Последняя: строка теста."
                };

                File.WriteAllLines(tempPath, lines);
                string result = ds.CollectTextFromFile(tempPath);
                Assert.AreEqual("запятой! строка теста.", result);
            }
            finally
            {
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
            }
        }

        [TestMethod]
        public void LinesWithExtraSpaces()
        {
            DataService ds = new DataService();
            string tempPath = Path.Combine(Path.GetTempPath(), "TestSpaces.txt");

            try
            {
                string[] lines = {
                    "   Строка   с   пробелами   ",
                    "\tСтрока\tс\tтабуляцией\t",
                    "Смешанные  \t  пробелы  \t"
                };

                File.WriteAllLines(tempPath, lines);
                string result = ds.CollectTextFromFile(tempPath);
                Assert.AreEqual("пробелами табуляцией пробелы", result);
            }
            finally
            {
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
            }
        }

        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V15.txt";
            Directory.CreateDirectory(@"C:\DataSprint6");

            // Создаем файл если не существует
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Тестовый файл");
            }

            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists, $"Файл должен существовать: {path}");
        }

        [TestMethod]
        public void MixedLanguages()
        {
            DataService ds = new DataService();
            string tempPath = Path.Combine(Path.GetTempPath(), "TestMixed.txt");

            try
            {
                string[] lines = {
                    "English text here",
                    "Русский текст здесь",
                    "Mixed текст text"
                };

                File.WriteAllLines(tempPath, lines);
                string result = ds.CollectTextFromFile(tempPath);
                Assert.AreEqual("here здесь text", result);
            }
            finally
            {
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
            }
        }

        [TestMethod]
        public void EmptyLinesInFile()
        {
            DataService ds = new DataService();
            string tempPath = Path.Combine(Path.GetTempPath(), "TestEmptyLines.txt");

            try
            {
                string[] lines = {
                    "Первая строка",
                    "",
                    "   ",
                    "\t",
                    "Вторая строка"
                };

                File.WriteAllLines(tempPath, lines);
                string result = ds.CollectTextFromFile(tempPath);
                Assert.AreEqual("строка строка", result);
            }
            finally
            {
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
            }
        }
    }
}
