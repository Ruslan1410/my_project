//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

int NunFunc(int first){
    int num = 1;
    for(int i=1;i<=first;i++){
        Console.Write(num=num*num, num++ + ',');
    }
    return num;

}


Console.WriteLine("enter numb");
int num = Convert.ToInt32(Console.ReadLine());
int res = NunFunc(num);
Console.WriteLine(res);
