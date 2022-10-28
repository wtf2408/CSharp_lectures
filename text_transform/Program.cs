/*Console.Clear();
string text = "Ну привет, Ивашка, как дела у тебя ?";

string TextTransform (string txt , char lastCharacter, char newCharacter)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
       if (txt[i]==lastCharacter) result = result + $"{newCharacter}";
       else result = result + $"{txt[i]}";
    }
    return result;
}

string newText = TextTransform (text, ',', '$');
Console.WriteLine(newText);

newText = TextTransform (newText, 'е', 'Е');
Console.WriteLine(newText);*/

int[] array = {1,6,2,7,9,3,1};


void PrintArray (int [] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Method (int[] arr)
{
   for (int i = 0; i < arr.Length - 1; i++)
   {
    int minPosition = i;
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[j]<arr[minPosition]) minPosition = j;
    }
    int x = arr[i];
    arr[i]=arr[minPosition];
    arr[minPosition] = x;
   } 
}
Method(array);
PrintArray(array);



