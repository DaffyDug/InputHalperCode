public static class InputHelper
{
    public static bool Input(string _text, int _min, int _max, out int inputValue)
    {
        bool result = false;
        Console.WriteLine(_text);
        string InputValue = Console.ReadLine();
        inputValue = int.Parse(InputValue);

        if (inputValue >= _min || inputValue <= _max)
        {
            Console.WriteLine("Твое число " + inputValue);
            result = true;
        }
        else
        {
            Console.WriteLine("Ошибка");
            result = true;
        }
        return result;
    }
}