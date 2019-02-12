using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    enum FSIMode
    {
        DirectoryInfo = 1,
        File = 2
    }
    class layer
    {
        public FileSystemInfo[] Content
        {
            get;
            set;
        }
     
        public int SelectedIndex
        {
            get;
            set;
        }

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < Content.Length; i++)
            {
                if (i == SelectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
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
                Console.WriteLine((i + 1) + "." + Content[i].Name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\asus-\Downloads");
            layer l = new layer
            {
                Content = dir.GetFileSystemInfos(),
                SelectedIndex = 0
            };
            Stack<layer> history = new Stack<layer>();
            l.Draw();
            history.Push(l);
            bool esc = false;
            FSIMode curMode = FSIMode.DirectoryInfo;
            while (!esc)
            {
                if (curMode == FSIMode.DirectoryInfo)
                    history.Peek().Draw();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.Backspace:
                        if (curMode == FSIMode.DirectoryInfo)
                        {

                            if (history.Count > 1)
                            {
                                history.Pop();
                            }
                        }
                        else
                        {
                            curMode = FSIMode.DirectoryInfo;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;

                    case ConsoleKey.Enter:
                        if (history.Peek().Content.Length == 0)
                            break;
                        int index = history.Peek().SelectedIndex;
                        FileSystemInfo fsi = history.Peek().Content[index];
                        if (fsi.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo d = fsi as DirectoryInfo;

                            history.Push(new layer
                            {
                                Content = d.GetFileSystemInfos(),
                                SelectedIndex = 0
                            });
                        }
                        else
                        {
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



                    case ConsoleKey.UpArrow:
                        if (history.Peek().SelectedIndex > 0)
                        {
                            history.Peek().SelectedIndex--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (history.Peek().Content.Length - 1 > history.Peek().SelectedIndex)
                        {
                            history.Peek().SelectedIndex++;
                        }
                        break;

                    case ConsoleKey.Escape:
                        esc = true;
                        break;

                    
                        

                }
            }
        }
    }
}