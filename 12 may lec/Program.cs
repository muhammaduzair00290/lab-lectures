// arrays :
int[] marks=new int[15];
marks[0] = 10;
marks[1] = 20;
marks[2] = 30;
marks[3] = 40;
marks[4] = 50;
marks[5] = 60;
marks[6] = 70;
marks[7] = 80;
marks[8] = 90;
marks[3] = 50;
Console.WriteLine(marks[5]);
// copying one array to other 
int[] array1=new int[20];
int len=marks.Length;
marks.CopyTo(array1, 0);
for (int i=0;i<len;i++ )
{
    Console.WriteLine(array1[i]);
}






Console.ReadLine();

