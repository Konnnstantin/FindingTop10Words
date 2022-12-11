{
    var DicTop10 = new Dictionary<string, int>();
    var text = new StreamReader("C:\\Users\\user\\Desktop\\Text1.txt");

    while (!text.EndOfStream)
    {
        var array = text.ReadLine().Split(" - :>,.?!()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in array)
        {
            if (DicTop10.ContainsKey(word))
            {
                DicTop10.TryGetValue(word, out int value);
                var keys = value + 1;
                DicTop10.Remove(word);
                DicTop10.Add(word, keys);
            }
            else
            {
                DicTop10.Add(word, 1);
            }
        }
    }
    var result = DicTop10.OrderBy(_ => _.Value); //Сортировка по возрастнаию значения использования слов
    var result1 = DicTop10.OrderBy(_ => _.Key);//Сортировка по алфавиту
    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
}