using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    enum FSIMode //пронумеровываем для удобства
    {
        DirectoryInfo = 1,
        File = 2
    }
    class layer
    {
        public FileSystemInfo[] Content//список всех файлов и папок
        {
            get;//чтение из поля
            set;//записи в поле
        }
        
        public int SelectedIndex//выделенный индекс
        {
            get;
            set;
        }

        public void Draw()//метод рисовки
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < Content.Length; i++)
            {
                if (i == SelectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;//выделенный индекс в красный
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (Content[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine((i + 1) + "." + Content[i].Name);//нумеровка
            }
        }
    }
    class Program
    {
        static FileSystemInfo[] Combine(DirectoryInfo[] di, FileInfo[] fi)
        { // Объединяет папки и файлы
            FileSystemInfo[] fsi = new FileSystemInfo[di.Length + fi.Length];
            for (int i = 0; i < di.Length; ++i) // Берем все папки и добавляем их в fsi. И только потом добавляем файлы
                fsi[i] = di[i];
            for (int i = 0; i < fi.Length; ++i)
                fsi[i + di.Length] = fi[i];
            return fsi; // Возвращаем скомбинированный fsi
        }
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\asus-\source\repos\test");//первоначальная директория
            layer l = new layer//создаем слой 
            {
                Content = Combine(dir.GetDirectories(),dir.GetFiles()),
                SelectedIndex = 0
            };
            Stack<layer> history = new Stack<layer>();//в стэке будем хранить слои
            
            history.Push(l);//первоначальную директорию закидываем в стэк
            bool esc = false;
            FSIMode curMode = FSIMode.DirectoryInfo;//текущее состояние в начале будет папкой
            while (!esc)
            {
                if (curMode == FSIMode.DirectoryInfo)
                    history.Peek().Draw();//рисуем последний слой 
                l = history.Peek();//начальную директорию = последний слой
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();//читаем с клавиш
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.Backspace://кнопка назад
                        if (curMode == FSIMode.DirectoryInfo)
                        {

                            if (history.Count > 1)
                            {
                                history.Pop();//возвращаемся назад
                            }
                        }
                        else
                        {
                            //если это папка возвращаемся в папку с этим файлом
                            curMode = FSIMode.DirectoryInfo;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;

                    case ConsoleKey.Enter://кнопка Enter
                        
                        if (history.Peek().Content.Length == 0)//если пуст внутренний контент
                            break;
                        int index = history.Peek().SelectedIndex;
                        FileSystemInfo fsi = history.Peek().Content[index];
                        if (fsi.GetType() == typeof(DirectoryInfo))
                        {
                            //проверяем под выбранный индекс чем является папка или файл. Если папка, то открываем под новый слой и рисуем по новому
                            DirectoryInfo d = fsi as DirectoryInfo;

                            history.Push(new layer
                            {
                                Content = Combine(d.GetDirectories(),d.GetFiles()),
                                SelectedIndex = 0
                            });
                        }
                        else
                        {
                            //условие если это файл. Используем потокового читателя, чтобы прочитать информацию и переписать всё то, что написано в файле
                            curMode = FSIMode.File;
                            using (FileStream fs = new FileStream(fsi.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }
                        break;

                    case ConsoleKey.UpArrow://кнопка вверх
                        if (history.Peek().SelectedIndex > 0)
                        {
                            history.Peek().SelectedIndex--;
                        }
                        break;

                    case ConsoleKey.Delete://кнопка удалить
                        //условие когда кнопка не работает
                        if (curMode == FSIMode.File || l.Content.Length == 0)
                        { 
                            break;
                        }
                        //условие если это выбранный объект это файл
                        if (l.Content[l.SelectedIndex].GetType() == typeof(FileInfo))
                        {
                            l.Content[l.SelectedIndex].Delete();
                        }
                        //или папка
                        else 
                            (l.Content[l.SelectedIndex] as DirectoryInfo).Delete(true);
                        history.Pop();//возвращаемся на предыдущий слой
                        if (history.Count == 0)//если больше нет слоев , то возвращаемся на первоначальный
                            dir = new DirectoryInfo(@"C:\Users\asus-\source\repos\test");
                        else //или предыдущий
                            dir = new DirectoryInfo(history.Peek().Content[history.Peek().SelectedIndex].FullName);

                        //перерисовываем с уже удаленным объектом
                        history.Push(new layer
                        {
                            Content = Combine(dir.GetDirectories(), dir.GetFiles()),
                            SelectedIndex = Math.Min(l.SelectedIndex, l.Content.Length - 2)
                        });
                        
                        break;
                    case ConsoleKey.F4: //переименование
                        if(curMode==FSIMode.File || l.Content.Length == 0)
                        {
                            //условие, когда кнопка не будет работать
                            break;
                        }
                        string fullname = l.Content[l.SelectedIndex].FullName;//полное имя выбранного объекта
                        string path = fullname.Remove(fullname.Length - l.Content[l.SelectedIndex].Name.Length);//путь к выбранному объекту
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Enter new name: ");
                        string newname = Console.ReadLine();//новое имя для объекта
                        
                        while(newname.Length==0 || Directory.Exists(path + newname))
                        {

                            Console.WriteLine("This directory is exist, Create new one: ");
                            newname = Console.ReadLine();
                        }
                        if (l.Content[l.SelectedIndex].GetType()== typeof (DirectoryInfo))
                        {  
                            //процесс переименовки папки
                            new DirectoryInfo(fullname).MoveTo(path + newname);
                            history.Peek().Content[l.SelectedIndex] = new DirectoryInfo(path + newname) ;

                        }
                        else
                        {
                            //процесс переименовки файла
                            new FileInfo(fullname).MoveTo(path + newname);
                            history.Peek().Content[l.SelectedIndex] = new FileInfo(path + newname);
                        }
                        break;

                    case ConsoleKey.DownArrow://кнопка вниз
                        if (history.Peek().Content.Length - 1 > history.Peek().SelectedIndex)
                        {
                            history.Peek().SelectedIndex++;
                        }
                        break;

                    case ConsoleKey.Escape://кнопка выхода из программы
                        esc = true;
                        break;
                }
            }
        }
    }
}