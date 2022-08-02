//task 21

double num (double x1, double y1, double x2, double y2, double z1, double z2)
{
    double result =0;
    if (x1 ==x2 && y1 == y2)
    {
        return result;
    }
    result = Math.Sqrt(Math.Pow( x2 - x1,3)+ Math.Pow (y2 - y1, 3));

    return result;

}

double A = num (3,6,8,2,1,-7);
Console.WriteLine(A);

//task23

Console.WriteLine("Put a number");
int numm = Convert.ToInt32(Console.ReadLine());
int [] mass = new int [numm];

for(int i = 0; i<= numm; i++)
{
    mass [i-1] = i * i * i;
    Console.WriteLine(mass [i -1]);
}


//task19

Console.WriteLine("Put a number");
int bim = Convert.ToInt32(Console.ReadLine());

int [] mass1 = new int [bim];

for(int i = 0; i<= numm; i++)
{
    if ( mass1 [0] == 4 && mass1 [1] == 3){
        Console.WriteLine("Polyndrom");
    }
}




