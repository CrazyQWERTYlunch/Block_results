
string [] CreateArray (int size){
    string [] array = new string[size];
    for (int i = 0; i < size; i++){
        Console.Write("Input elements array: ");
        array[i] = Console.ReadLine();
    } return array;
}

string [] ReworkArray ( string[] array){
    
    string [] newArray = new string[array.Length];
    int limiter = 4;
    int j = 0;
    for (int i = 0; i < array.Length; i ++){
        if (array[i].Length < limiter ) {
            newArray[j] = array[i];
            j += 1;
        }
    } return newArray;
}

void ShowArray( string [] array){
    for ( int i = 0; i < array.Length; i ++){
        Console.Write(array[i]+ " ");
    } Console.WriteLine();
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

// string [] array = CreateArray(size);
// string [] newArray = ReworkArray(array);
// ShowArray(array);
// ShowArray(newArray);

ShowArray(ReworkArray(CreateArray(size)));