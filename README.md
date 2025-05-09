# Описание
Эта C# библиотека создана для исправления опечаток из-за неправильной раскладки.

У всех же было что писали "ghbdtn", вместо "привет".

С этой простой библиотекой можно подавать строку в функцию и получить «расшифрованный» вариант.

Библиотека не содержит лишних методов и работает стабильно в обе стороны, так же учитывая регистр. Другие символы не учитываются и остаются как есть.

# Устанока

Для клонирования репозитория:
```
git clone https://github.com/clay1299/KeybordTranslator.git
```

Для скачивания dll файла [тут](https://github.com/clay1299/KeybordTranslator/releases/download/v.1.0/KeybordTranslator.dll)

# Документация по библиотеке
### Есть всего 2 метода ```En2Ru``` и ```Ru2En```
_Что делает каждый понятно по названию_

Функция принимает на вход строку ```string``` и возвращает ее «расшифрованную» версию

## Пример использования

``` C#
using KeybordTranslator;

class Program
{
    public static void Main(string[] args)
    {
        string enError = "Ghbdtn Lheu!"; //Привет Друг!
        string ruError = "руддщ"; //hello

        Translator tr = new Translator();

        Console.WriteLine(tr.En2Ru(enError));//<------ возвращает строку
        Console.WriteLine(tr.Ru2En(ruError));

    }
}
```
В консоль получаем это:

![image](https://github.com/user-attachments/assets/9811e139-c3c7-4008-8c29-8b18018d6bf8)


