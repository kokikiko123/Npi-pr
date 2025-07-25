# ToDo List - Консольное приложение на C#

## Краткое описание
Это простое консольное приложение для управления задачами (ToDo List), реализованное на C#. Программа позволяет добавлять задачи, отмечать их как выполненные, просматривать список всех задач и удалять ненужные задачи. Все данные автоматически сохраняются в текстовый файл и загружаются при следующем запуске приложения.

## Инструкции по запуску

1. Убедитесь, что у вас установлен [.NET SDK](https://dotnet.microsoft.com/download) (версии 5.0 или выше)
2. Склонируйте репозиторий или создайте файл `Program.cs` с приведенным кодом
3. Откройте терминал в папке с проектом
4. Скомпилируйте и запустите приложение:

```bash
dotnet run
```

5. Следуйте инструкциям в консоли для работы с приложением

## Реализованные функции

- ✅ Добавление новых задач через консольный ввод
- ✅ Отображение всех задач с номерами и статусами выполнения
- ✅ Отметка задач как выполненных по номеру
- ✅ Удаление задач по номеру
- ✅ Интуитивное меню с номерами опций
- ✅ Автоматическое сохранение задач в файл `tasks.txt`
- ✅ Автоматическая загрузка задач из файла при запуске
- ✅ Проверка корректности ввода пользователя
- ✅ Обработка ошибок файловых операций

## Пример работы приложения

```
Меню ToDo List:
1 - Добавить задачу
2 - Показать все задачи
3 - Отметить задачу как выполненную
4 - Удалить задачу
5 - Сохранить и выйти
Выберите опцию: 1
Введите новую задачу: Купить молоко
Задача добавлена!

Меню ToDo List:
1 - Добавить задачу
2 - Показать все задачи
3 - Отметить задачу как выполненную
4 - Удалить задачу
5 - Сохранить и выйти
Выберите опцию: 1
Введите новую задачу: Сделать домашнее задание
Задача добавлена!

Меню ToDo List:
1 - Добавить задачу
2 - Показать все задачи
3 - Отметить задачу как выполненную
4 - Удалить задачу
5 - Сохранить и выйти
Выберите опцию: 2

Список задач:
1. [ ] Купить молоко
2. [ ] Сделать домашнее задание

Меню ToDo List:
1 - Добавить задачу
2 - Показать все задачи
3 - Отметить задачу как выполненную
4 - Удалить задачу
5 - Сохранить и выйти
Выберите опцию: 3

Список задач:
1. [ ] Купить молоко
2. [ ] Сделать домашнее задание
Введите номер выполненной задачи: 1
Задача отмечена как выполненная!

Меню ToDo List:
1 - Добавить задачу
2 - Показать все задачи
3 - Отметить задачу как выполненную
4 - Удалить задачу
5 - Сохранить и выйти
Выберите опцию: 2

Список задач:
1. [x] Купить молоко
2. [ ] Сделать домашнее задание

Меню ToDo List:
1 - Добавить задачу
2 - Показать все задачи
3 - Отметить задачу как выполненную
4 - Удалить задачу
5 - Сохранить и выйти
Выберите опцию: 4

Список задач:
1. [x] Купить молоко
2. [ ] Сделать домашнее задание
Введите номер задачи для удаления: 1
Задача удалена!

Меню ToDo List:
1 - Добавить задачу
2 - Показать все задачи
3 - Отметить задачу как выполненную
4 - Удалить задачу
5 - Сохранить и выйти
Выберите опцию: 2

Список задач:
1. [ ] Сделать домашнее задание

Меню ToDo List:
1 - Добавить задачу
2 - Показать все задачи
3 - Отметить задачу как выполненную
4 - Удалить задачу
5 - Сохранить и выйти
Выберите опцию: 5
Задачи сохранены в файл!
```

Файл `tasks.txt` после работы приложения:
```
[ ] Сделать домашнее задание
```
