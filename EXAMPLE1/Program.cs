Console.WriteLine("Введите пятизначное число"); 
int a=  Convert.ToInt32 (Console.ReadLine()); 
string n=a.ToString(); 
if(n[0] == n[4])  
{ 
   if(n[1] == n[3])  
{ 
    Console.WriteLine("Да"); 
} 
 else Console.WriteLine("Нет"); 
} 
 else  
 Console.WriteLine("Нет");