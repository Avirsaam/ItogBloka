
Console.Clear();

const int shortWordLetterCount = 3;
String [] array = {"hello", "2", "world", ":-)"};
int shortWordCounter = 0;

for (int i = 0; i < array.Length; i++)
{    
    if (array[i].Length <= shortWordLetterCount)
    {        
        shortWordCounter++;                
    }
}

if (shortWordCounter > 0)
{
    String [] resultArray = new String[shortWordCounter];

    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= shortWordLetterCount)
        {
            resultArray[--shortWordCounter] = array[i];            
            Console.Write("\"" + array[i] + "\"");            
            if (shortWordCounter == 0) Console.WriteLine("]");
            else Console.Write(", ");
        }
    }
}
else
{
    Console.WriteLine($"В исходном массиве нет слов меньше {shortWordLetterCount} букв");
}
