// See https://aka.ms/new-console-template for more information
//Console.WriteLine("operators ");
//a=p+p*1*n
//p =investment:
//n = duration:
Console.WriteLine(" please enter your desired investment ");
string? temp = Console.ReadLine();
int p =Convert.ToInt32(temp);

Console.WriteLine(" please enter your duration ");
string? temp1 = Console.ReadLine();
int n = Convert.ToInt32(temp1);



float i = 0.1f;
int a=(int)(p+p*i*n);
Console.WriteLine($"now your amount is  { a}after investment {p }  with interest of { i}");
