double [] Array (int size){
    double [] b = new double [size];
    for(int i=0; i<b.Length; i++){
        b[i] = new Random().NextDouble() * 20.0+30.0;
    }
    return b;
}
double [] arrays = Array(6);
System.Console.WriteLine($"[{String.Join(", /", arrays)}]");

void Raz(double [] array){
    double max =array[0];
    double min =array[0];
    for(int i=0;i<array.Length; i++){
     if (array[i]>max) max=array[i];
     if (array[i]<min) min= array[i];
    }
    double result = max -min;
    System.Console.WriteLine(result);
}
Raz(arrays);