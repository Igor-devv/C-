//task 27

int sum (int N){
    int result = 0;
    for (int i = 0; i<=N; i++){
        result +=1;
    }
    Console.WriteLine("Sum from i to {0} is {1} ", N, result);
    return result;
}

sum(452);
sum(82);
sum(9012);