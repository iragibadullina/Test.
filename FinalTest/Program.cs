void MethodArray (string [] array)
{
     string[] newArray = new string[array.Length];
     for (int i = 0; i < array.Length; i++)
     {      
        if(array[i].Length <= 3)
        {
        newArray[i] = array[i];;
        Console.WriteLine(newArray[i]); 
        }
     }
        Console.WriteLine(); 
}

void Print(string [] Array){
    for (int i = 0; i < Array.Length; i++){
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}

string [] array = {"hello", "2", "world", ":-)"};

MethodArray(array);
Print(array);