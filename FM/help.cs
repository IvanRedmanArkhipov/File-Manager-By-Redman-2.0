using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    internal class help
    {
        public static void Help()
        {
            Console.Clear();
            Console.WriteLine(" Команды файлового менеджера:");
            Console.WriteLine("");
            Console.WriteLine(" В \"{}\" указано примечание (\"{}\" писать не надо)");
            Console.WriteLine("");
            Console.WriteLine(" help - вызов списка команд");
            Console.WriteLine(" go {папка} - перейти в папку из текущей директории");
            Console.WriteLine(" go to {путь} - перейти по пути");
            Console.WriteLine(" go .. - перейти в верхнюю директорию");
            Console.WriteLine("list {номер листа} - перейти на страницу");
            Console.WriteLine(" copy file {файл} - скопировать файл из текущей директории");
            Console.WriteLine(" copy dir {папка} - скопировать папку из текущей директории");
            Console.WriteLine(" paste - вставить скопированный файл/папку в текущую директорию");
            Console.WriteLine(" del file {файл} - удалить файл из текущей директории");
            Console.WriteLine(" del dir {папка} - удалить папку из текущей директории");
            Console.WriteLine(" create file {файл} - создать файл в текущую директорию");
            Console.WriteLine(" create dir {папка} - создать папку в текущую директорию");
            Console.WriteLine(" rename file {старое название файла} to {новое название файла} - переименовать файл из текущей директории");
            Console.WriteLine(" rename dir {старое название папки} to {новое название папки} - переименовать папку из текущей директории");
            Console.WriteLine(" read {файл} - вывести содержимое текстового файла из текущей директории на экран");
            Console.WriteLine("search {имя файла} - поиск файла в текущей директории (с поиском по подпапкам)");
            Console.WriteLine("");
            Console.WriteLine(" Нажмите любую кнопку, чтобы вернуться");

            line.print(58);

            Console.ReadKey();
        }
    }
}
