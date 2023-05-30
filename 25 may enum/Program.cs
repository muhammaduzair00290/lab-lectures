using _25_may_enum;
OrderStatus odst = OrderStatus.InProcess;
int v2 =(int)odst;
if  (odst != OrderStatus.Delivered)
{
    Console.WriteLine($" your order is {odst}under process and value is {v2} ");
}
else
{
    Console.WriteLine(" your order is delivered "+odst);
}
CityCode name = CityCode.Karachi;
int code = (int)name;
Console.WriteLine($"{name} and {code} ");