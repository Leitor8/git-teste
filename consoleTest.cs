public int sumInt(){
    int sum = 0;
    for(int i = 0; i <= 100; i++){
        sum += i;
    }
    return sum;
}

public void consoleSeven() {
    for (int i = 0; i < 100; i++) {
        if (i % 7 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

public void fibonacci() {
    int count = 1;
    int prev = 1;
    Console.WriteLine(prev);
    Console.WriteLine(count);
    while (count <= 100)
    {
        int inter = count;
        count += prev;
        prev = inter;
        Console.WriteLine(count); 
    }
}

