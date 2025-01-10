
### Шаги по созданию C# проекта с использованием терминала:

1. **Открой Visual Studio Code**:
   - Запусти Visual Studio Code.

2. **Открой терминал в VSCode**:
   - Нажми `Ctrl+` или выбери "Terminal" -> "New Terminal" в меню.

3. **Перейди в папку для проекта**:
   - В терминале перейди в папку, где ты хочешь создать новый проект, с помощью команды `cd путь/к/папке`.

4. **Создай новое консольное приложение**:
   - Введи команду `dotnet new console -n MyFirstApp`, чтобы создать новое консольное приложение. `MyFirstApp` — это имя твоего проекта, ты можешь заменить его на любое другое.

5. **Открой проект в VSCode**:
   - Перейди в папку проекта с помощью команды `cd MyFirstApp`.
   - Введи команду `code .`, чтобы открыть текущую папку в Visual Studio Code.

### Пример кода для файла `Program.cs`:
```csharp
using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

### Запуск проекта:
- В терминале введи команду `dotnet run`, чтобы запустить проект.
- В консоли появится сообщение "Hello, World!".

### Итоговая структура файлов проекта:
```
MyFirstApp/
│
├── bin/
├── obj/
│
├── Program.cs
└── MyFirstApp.csproj
```
