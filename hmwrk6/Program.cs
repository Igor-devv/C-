//tash 41 

int N = Convert.ToInt32(Console.ReadLine());
int Countpos = 0;
for (int i = 0; i <N; i++){
    int dig = Convert.ToInt32(Console.ReadLine());
    if (dig > 0) {
        Countpos++;
    }
}

//task43

double x0, y0;

void getCoord (double k1, double b2, double k1, double k2) {
    double x = (b1 - b2) / (k2 - k1);
    double y = x * k1 +b1;
}