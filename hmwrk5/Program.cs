//task 34

int B = 10;
int [] arr = new int [B];
Random rnd = new Random();
int count = 0;

for (int i = 0; i <B; i++) {

    arr[i] = rnd.Next(100,1000);
    if (arr[i] % 2 == 0) {
        count++;
    }
}

//task 37

int C = 10;
int [] arr = new int [C];
Random rnd = new Random();
int count = 0;


for (int i = 0; i <C; i++) {

    arr[i] = rnd.Next(100,1000);
    if (i % 2) {
        sun+= arr [i];
    }
}



//task 38

double [] num = new double [5]{4,8,22,4,76};
int amin = 0;
int amax = 0;
double result = 0;

 for (int i = 0; i <5; i++){

        if (num[i] > num [amax])
        {
            amax = i;
        }

        else if (num[i] < num [amin])
        {
                 amin = i;
        }

           
}

        

    
result = num[amax] - num[amin];
Console.WriteLine(result);