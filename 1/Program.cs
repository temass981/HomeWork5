int [] Array (int size){
    int [] b = new int [size];
    for(int i=0; i<b.Length; i++){
        b[i] = new Random().Next(100,1000);
    }
    return b;
}
int [] arrays = Array(4);
System.Console.WriteLine($"[{String.Join(", /", arrays)}]");

void Even(int [] array){
    int count =0;
    for(int i=0;i<array.Length; i++){
     if (array[i]%2==0) count++;
    }
    System.Console.WriteLine(count);
}
Even(arrays);