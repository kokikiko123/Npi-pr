using System;
using System.Collections.Generic;

namespace TodoListApp
{
    class Program
    {
        static List<TodoItem> tasks = new List<TodoItem>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- To-Do List ---");
                Console.WriteLine("1. Добавить задачу");
                Console.WriteLine("2. Показать все задачи");
                Console.WriteLine("3. Отметить как выполненное");
                Console.WriteLine("4. Удалить задачу");
                Console.WriteLine("5. Выход");
                Console.Write("Выберите опцию: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ShowTasks();
                        break;
                    case "3":
                        MarkTaskDone();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Введите описание задачи: ");
            string description = Console.ReadLine();
            tasks.Add(new TodoItem { Id = nextId++, Description = description, IsDone = false });
            Console.WriteLine("Задача добавлена!");
        }

        static void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст.");
                return;
            }

            foreach (var task in tasks)
            {
                string status = task.IsDone ? "[x]" : "[ ]";
                Console.WriteLine($"{task.Id}. {status} {task.Description}");
            }
        }

        static void MarkTaskDone()
        {
            Console.Write("Введите ID задачи для отметки как выполненной: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var task = tasks.Find(t => t.Id == id);
                if (task != null)
                {
                    task.IsDone = true;
                    Console.WriteLine("Задача отмечена как выполненная.");
                }
                else
                {
                    Console.WriteLine("Задача не найдена.");
                }
            }
            else
            {
                Console.WriteLine("Неверный формат ID.");
            }
        }

        static void DeleteTask()
        {
            Console.Write("Введите ID задачи для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var task = tasks.Find(t => t.Id == id);
                if (task != null)
                {
                    tasks.Remove(task);
                    Console.WriteLine("Задача удалена.");
                }
                else
                {
                    Console.WriteLine("Задача не найдена.");
                }
            }
            else
            {
                Console.WriteLine("Неверный формат ID.");
            }
        }
    }

    class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
git remote add origin https://github.com/kokikiko123/Npi-pr.git
git add .
    git commit -m "init"
git push -u origin master