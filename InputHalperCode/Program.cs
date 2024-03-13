using System;
using System.Text;
public static class InputHelper
{
    public static bool Input(StringBuilder _text, int _min, int _max, out int inputValue)
    {
        bool result = false;
        Console.WriteLine(_text);

        int.TryParse(Console.ReadLine(), out inputValue);

        if (inputValue >= _min || inputValue <= _max)
        {
            Console.WriteLine("Твое число " + inputValue);
            result = true;
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
        return result;
    }
}
