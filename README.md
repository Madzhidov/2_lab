# File-Reader git project

Задачи данного проекта:
  - Чтение (*Reader.cs*);
  - Запись (*Reader.cs*);
  - Получение метаданных (*Reader.cs*);
  - Подсчет слов-палиндромов (*Reader.cs*);
  - Смена папки файла (*Reader.cs*);
  - Шифрование (*Crypto.cs*);
  - Дешифрование (*Crypto.cs*).
  
	текстового файла

## Перечень всех классов и методов с их описанием:

- Reader.cs
  - public static string Read(string path) - *Чтение файла*
  - public static void  Write(string path, string data, string method) - *Запись строки в файл*
  - public static System.Collections.Generic.List<string> GetFileInfo(string path) - *Получение метаданных о файле*
  - public static int Palindrom(string path) - *Подсчет слов палиндромов в файле*
  - public static void MoveFile(string path, string newPath) - *Изменение папки файла*
- Crypto.cs
  -  public static void Encode(string Path, string pKey, string method) - "Кодирование/декодирование файла с помощью XOR"
	
## Методы отдельных функций:

1. Reader.Write(string path, string data, string Method);

Method принимает значения:
  - "a" - добавление строки в конец файла;
  - "n" - перезапись файла или запись в новый файл.
  
```csharp
Reader.Write(@"C:\test.txt", "Example text", "a");
Reader.Write(@"C:\test.txt", "Example text", "n");
```

2. Reader.Encode(string path, string key, string Method);

Method принимает значения:
  - "e" - режим шифрования;
  - "d" - режим дешифрования.
  
```csharp
Crypto.Encode(@"C:\test.txt", "Example key", "e");
Crypto.Encode(@"C:\test.txt", "Example key", "d");
```

## Reader.cs примеры

```csharp
//Чтение
string Path = @"C:\sample.txt";
string data = Reader.Read(Path);

//Запись в файл
string Path = @"C:\sample.txt";
string data = "example";
Reader.Write(Path, data, "n");
```