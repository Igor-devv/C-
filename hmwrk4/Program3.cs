//task 29

int [] array ()
{
    int [] result = new int [8];
    for (int i = 0; i <8; i++){

        int numbercc = new Random ().Next(100,999);
        result[i] = numbercc;
        Console.WriteLine(result[i]);

    }


    return result;
}

array();