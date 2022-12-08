int [] Array (int size){
    int [] b = new int [size];
    for(int i=0; i<b.Length; i++){
        b[i] = new Random().Next(1,10);
    }
    return b;
}
int [] arrays = Array(6);
System.Console.WriteLine($"[{String.Join(", /", arrays)}]");

void Sum(int [] array){
    int sum =0;
    for(int i=0;i<array.Length; i++){
     if (i%2==1) sum +=array[i];
    }
    System.Console.WriteLine(sum);
}
Sum(arrays);