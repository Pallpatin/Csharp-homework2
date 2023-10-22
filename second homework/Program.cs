using System.Numerics;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int tasknumber = 1;
        /*Задание 1
        Объявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B.Заполнить одномерный массив
А числами, введенными с клавиатуры пользователем, а
двумерный массив В случайными числами с помощью
циклов.Вывести на экран значения массивов: массива
А в одну строку, массива В — в виде матрицы.Найти в
данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
произведение всех элементов, сумму четных элементов
массива А, сумму нечетных столбцов массива В*/
        Console.Clear();
        Console.WriteLine("Задание № "+tasknumber++);
        Console.WriteLine("Объявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B.Заполнить одномерный массив\r\nА числами, введенными с клавиатуры пользователем, а\r\nдвумерный массив В случайными числами с помощью\r\nциклов.Вывести на экран значения массивов: массива\r\nА в одну строку, массива В — в виде матрицы.Найти в\r\nданных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее\r\nпроизведение всех элементов, сумму четных элементов\r\nмассива А, сумму нечетных столбцов массива В");
        FirstTask();
        Console.WriteLine("нажмите на любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        /*Задание 2
         Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
Определить сумму элементов массива, расположенных 
между минимальным и максимальным элементами*/
        Console.Clear();
        Console.WriteLine("Задание № " + tasknumber++);
        Console.WriteLine("Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. \r\nОпределить сумму элементов массива, расположенных \r\nмежду минимальным и максимальным элементами");
        SecondTask();
        Console.WriteLine("нажмите на любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        
        /*Задание 3 
         Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. 
Из Википедии:
1
Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется 
символом, находящимся на некотором постоянном числе 
позиций левее или правее него в алфавите. Например, 
в шифре со сдвигом вправо на 3, A была бы заменена на 
D, B станет E, и так далее.
Подробнее тут: https://en.wikipedia.org/wiki/Caesar_
cipher.
Кроме механизма шифровки, реализуйте механизм 
расшифрования*/
        Console.Clear();
        Console.WriteLine("Задание № " + tasknumber++);
        Console.WriteLine("         Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. \r\nИз Википедии:\r\n1\r\nШифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется \r\nсимволом, находящимся на некотором постоянном числе \r\nпозиций левее или правее него в алфавите. Например, \r\nв шифре со сдвигом вправо на 3, A была бы заменена на \r\nD, B станет E, и так далее.\r\nПодробнее тут: https://en.wikipedia.org/wiki/Caesar_\r\ncipher.\r\nКроме механизма шифровки, реализуйте механизм \r\nрасшифрования");
        ThriedTask();
        Console.WriteLine("нажмите на любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        /*Задание 4
         Создайте приложение, которое производит операции 
над матрицами:
■ Умножение матрицы на число;
■ Сложение матриц;
■ Произведение матриц.*/
        Console.Clear();
        Console.WriteLine("Задание № " + tasknumber++);
        Console.WriteLine("         Создайте приложение, которое производит операции \r\nнад матрицами:\r\n■ Умножение матрицы на число;\r\n■ Сложение матриц;\r\n■ Произведение матриц.");
        FourthTask();
        Console.WriteLine("нажмите на любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        /*Задание 5
         * Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать 
его результат. Необходимо поддерживать только две 
операции: + и –.*/
        Console.Clear();
        Console.WriteLine("Задание № " + tasknumber++);
        Console.WriteLine("Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать \r\nего результат. Необходимо поддерживать только две \r\nоперации: + и –.");
        FifthTask();
        Console.WriteLine("нажмите на любую кнопку чтобы продолжить");
        Console.ReadKey(true);
        /*Задание 6
         Пользователь с клавиатуры вводит некоторый текст. 
Приложение должно изменять регистр первой буквы 
каждого предложения на букву в верхнем регистре.
Например, если пользователь ввёл: «today is a good 
day for walking. i will try to walk near the sea».
Результат работы приложения: «Today is a good day 
for walking. I will try to walk near the sea»*/
        Console.Clear();
        Console.WriteLine("Задание № " + tasknumber++);
        Console.WriteLine("Пользователь с клавиатуры вводит некоторый текст. \r\nПриложение должно изменять регистр первой буквы \r\nкаждого предложения на букву в верхнем регистре.\r\nНапример, если пользователь ввёл: «today is a good \r\nday for walking. i will try to walk near the sea».\r\nРезультат работы приложения: «Today is a good day \r\nfor walking. I will try to walk near the sea»");
        SixthTask();
        Console.WriteLine("нажмите на любую кнопку чтобы продолжить");
        Console.ReadKey(true);

        /*Задание 7
         * Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно 
должно быть заменено на набор символов *. По итогам 
работы приложения необходимо показать статистику 
действий. 
Например, если и у нас есть такой текст:
To be, or not to be, that is the question,
Or to take arms against a sea of troubles,
And by opposing end them? To die: to sleep;
No more; and by a sleep to say we end
Devoutly to be wish'd. To die, to sleep
Недопустимое слово: die.
Результат работы:
To be, or not to be, that is the question,
3
Or to take arms against a sea of troubles,
And by opposing end them? To ***: to sleep;
No more; and by a sleep to say we end
Devoutly to be wish'd. To ***, to sleep.
Статистика: 2 замены слова die.*/
        Console.Clear();
        Console.WriteLine("Задание № " + tasknumber++);
        Console.WriteLine("Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно \r\nдолжно быть заменено на набор символов *. По итогам \r\nработы приложения необходимо показать статистику \r\nдействий. \r\nНапример, если и у нас есть такой текст:\r\nTo be, or not to be, that is the question,\r\nOr to take arms against a sea of troubles,\r\nAnd by opposing end them? To die: to sleep;\r\nNo more; and by a sleep to say we end\r\nDevoutly to be wish'd. To die, to sleep\r\nНедопустимое слово: die.\r\nРезультат работы:\r\nTo be, or not to be, that is the question,\r\n3\r\nOr to take arms against a sea of troubles,\r\nAnd by opposing end them? To ***: to sleep;\r\nNo more; and by a sleep to say we end\r\nDevoutly to be wish'd. To ***, to sleep.\r\nСтатистика: 2 замены слова die.");
        SeventhTask();
        Console.WriteLine("нажмите на любую кнопку чтобы продолжить");
        Console.ReadKey(true);
    }
    private static void FirstTask()
    {
        /*Задание 1
        Объявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B.Заполнить одномерный массив
А числами, введенными с клавиатуры пользователем, а
двумерный массив В случайными числами с помощью
циклов.Вывести на экран значения массивов: массива
А в одну строку, массива В — в виде матрицы.Найти в
данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
произведение всех элементов, сумму четных элементов
массива А, сумму нечетных столбцов массива В*/
        int[] A=new int[5];
        for (int i=0; i<A.Length; i++)
        {
            Console.WriteLine($"введите {i}й элемент массива А");
            A[i]=int.Parse(Console.ReadLine());
        }

        float [,] B = new float[3,4];
        Random random = new Random();

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = (random.NextSingle() * 100);
            }
        }
        Console.WriteLine("Массив А :");
        foreach (int i in A) { Console.Write(" "+i); }
        Console.WriteLine();
        Console.WriteLine("Массив B :");
        for (int i = 0; i < B.GetLength(0);i++) 
        {
            for (int j = 0;j < B.GetLength(1); j++)
            {
                Console.Write(" "+B[i,j]);
            }
            Console.WriteLine();
        }
        float max,min,sum,proizv,summchetA,SummNechetStolbB;
        max = A.Max();
        min = A.Min();
        sum = A.Sum();
        proizv = 1;
        summchetA = 0;
        SummNechetStolbB = 0;
        for (int i = 0;i < A.Length; i += 2)
        {
            summchetA += A[i]; 
        }
        foreach (int el in A) proizv *= el;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (max < B[i, j]) max = B[i, j];
                if (min > B[i, j]) min = B[i, j];
                sum += B[i, j];
                proizv *= B[i, j];
                if (i % 2 == 1) SummNechetStolbB += B[i, j];
            }
        }
        Console.WriteLine($"ообщий максимальный элемент это {max}\nообщий минимальный элемент это {min}\nсумма всех элементов обоих массивов {sum}\nпроизведение всех элементов обоих массивов {proizv}\nсумма чётных элементов массива А {summchetA}\nсумма нечётных столбцов массива В {SummNechetStolbB}");
    }
    private static void SecondTask()
    {
        /*Задание 2
         Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
Определить сумму элементов массива, расположенных 
между минимальным и максимальным элементами*/
        int[,] arr = new int[5,5];
        Random random = new Random();
        int min=100, max=-100;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                
                arr[i, j] = random.Next(-100,100);
                Console.Write(" "+arr[i,j]+" ");
                if (min > arr[i, j]) min = arr[i, j];

                if (max < arr[i, j]) max = arr[i, j];

            }
            Console.WriteLine();
        }
        int summ = 0;
        bool flag=false;
        foreach (int el in arr)
        {
            if (el == min || el == max)
            {
                if (flag) break;
                flag = true;
            }
            if(flag) summ+=el;
        }
        Console.WriteLine($"сумма всех элементов между минимальным {min} и максимальным {max} равна {summ}");
    }
    private static void ThriedTask()
    {
        /*Задание 3 
 Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. 
Из Википедии:
1
Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется 
символом, находящимся на некотором постоянном числе 
позиций левее или правее него в алфавите. Например, 
в шифре со сдвигом вправо на 3, A была бы заменена на 
D, B станет E, и так далее.
Подробнее тут: https://en.wikipedia.org/wiki/Caesar_
cipher.
Кроме механизма шифровки, реализуйте механизм 
расшифрования*/

        Console.WriteLine("введите строку для шифрования ");
        string str = Console.ReadLine();
        int num = 5;
        StringBuilder encoded = new StringBuilder();
        foreach(char el in str)
        {
            encoded.Append((char)((int)el+num));
        }
        Console.WriteLine("Зашифрованное сообщение "+encoded.ToString());
        StringBuilder decoded = new StringBuilder();
        foreach (char el in encoded.ToString())
        {
            decoded.Append((char)((int)el - num));
        }
        Console.WriteLine("Расшифрованное сообщение - "+decoded);
    }
    private static void FourthTask()
    {
        /*Задание 4
         Создайте приложение, которое производит операции 
над матрицами:
■ Умножение матрицы на число;
■ Сложение матриц;
■ Произведение матриц.*/
        Console.WriteLine("введите размеры первой матрицы");
        Console.WriteLine("введите ширину матрицы");
        int width1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите высоту матрицы");
        int height1 = Convert.ToInt32(Console.ReadLine());
        int[,] firstmatrix = new int[width1, height1];
        Console.WriteLine("вводите значения первой матрицы");
        for (int i = 0; i < width1; i++)
        {
            for (int j = 0; j < height1; j++)
            {
                firstmatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine();
        }
        int desizion;
        Console.WriteLine("введите 1 для Умножения матрицы на число\nвведите 2 для Сложение матриц\nвведите 3 для Произведение матриц");
        do
        {
            desizion = Convert.ToInt32(Console.ReadLine());
        } while (desizion < 1 || desizion > 3);
        switch (desizion)
        {
            case 1: 
                Console.WriteLine("введите число для умножения матрицы");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < width1; i++)
                {
                    for (int j = 0; j < height1; j++)
                    {
                        firstmatrix[i, j] *= number;
                        Console.Write(" " + firstmatrix[i,j]);
                    }
                    Console.WriteLine();
                }
                break; 
            case 2:
                Console.WriteLine("введите значения второй матрицы");
                int[,]secondmatrix=new int[width1, height1];
                for (int i = 0; i < width1; i++)
                {
                    for (int j = 0; j < height1; j++)
                    {
                        secondmatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < width1; i++)
                {
                    for (int j = 0; j < height1; j++)
                    {
                        firstmatrix[i, j] += secondmatrix[i, j];
                        Console.WriteLine(" " + firstmatrix[i,j]);
                    }
                    Console.WriteLine();
                }
                break; 
            case 3:
                Console.WriteLine("введите количество строк второй матрицы");
                
                int[,] SecondMatrix = new int[width1, height1];
                Console.WriteLine("введите значения второй матрицы");
                for (int i = 0; i < width1; i++)
                {
                    for (int j = 0; j < height1; j++)
                    {
                        SecondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                int[,]result= new int[height1, width1];
                for(int i = 0; i < height1; i++)
                {
                    for(int j = 0;j < height1; j++)
                    {
                        for (int k = 0; k < width1; k++) result[i, j] += firstmatrix[i, k] + SecondMatrix[k, j];
                    }
                }
                Console.WriteLine("зезультирующая матрица:");
                for(int i = 0; i < height1; i++)
                {
                    for (int j = 0; j < width1; j++)
                    {
                        Console.Write(" " + result[i,j]);
                    }
                    Console.WriteLine();
                }
                break;
        }
    }
    private static void FifthTask()
    {
        /*Задание 5
         * Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать 
его результат. Необходимо поддерживать только две 
операции: + и –.*/
        Console.WriteLine("введите арифметическое выражение без пробелов : ");
        string str = Console.ReadLine();
        char sign='+';
        if (str.Contains('+')) sign = '+';
        else if (str.Contains("-")) sign = '-';
        else {
            Console.WriteLine("Ошибка");
        }
        str.IndexOf(sign);
        int value1 = int.Parse(str.Split(sign)[0]);
        int value2 = int.Parse(str.Split(sign)[1]);
        int answer;
        if(sign=='+')answer=value1+value2;
        else answer=value1-value2;
        Console.WriteLine(value1+ " "+sign+" "+value2+" = "+answer);
    }
    private static void SixthTask()
    {
        /*Задание 6
         Пользователь с клавиатуры вводит некоторый текст. 
Приложение должно изменять регистр первой буквы 
каждого предложения на букву в верхнем регистре.
Например, если пользователь ввёл: «today is a good 
day for walking. i will try to walk near the sea».
Результат работы приложения: «Today is a good day 
for walking. I will try to walk near the sea»*/
        Console.WriteLine("Введите текст : ");
        string inputed = Console.ReadLine();
        string[] arr = inputed.Split('.');
        for(int i=0;i<arr.Length;i++)
        {
            arr[i] = arr[i].Trim();
            arr[i]= arr[i][0].ToString().ToUpper() + arr[i].Substring(1);
        }
        for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
    }
    private static void SeventhTask()
    {
        /*Задание 7
         * Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно 
должно быть заменено на набор символов *. По итогам 
работы приложения необходимо показать статистику 
действий. 
Например, если и у нас есть такой текст:
To be, or not to be, that is the question,
Or to take arms against a sea of troubles,
And by opposing end them? To die: to sleep;
No more; and by a sleep to say we end
Devoutly to be wish'd. To die, to sleep
Недопустимое слово: die.
Результат работы:
To be, or not to be, that is the question,
3
Or to take arms against a sea of troubles,
And by opposing end them? To ***: to sleep;
No more; and by a sleep to say we end
Devoutly to be wish'd. To ***, to sleep.
Статистика: 2 замены слова die.*/
        Console.WriteLine("Введите текст");
        StringBuilder inputed = new StringBuilder(Console.ReadLine());
        Console.WriteLine("введите недопустимую строку");
        string unavalible = Console.ReadLine();
        int count = 0;
        int place = inputed.ToString().IndexOf(unavalible);
        string toreplace = new string('*', unavalible.Length);
        while(place != -1)
        {
            count++;
            inputed.Remove(place,unavalible.Length);
            inputed.Insert(place, toreplace);
            place = inputed.ToString().IndexOf(unavalible);
        }
        Console.WriteLine("после изменения получилось ");

        Console.WriteLine(inputed.ToString());
        Console.WriteLine(count+ " замен " +unavalible);




    }
}