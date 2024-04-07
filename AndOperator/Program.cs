
//MAth >=90; Bilogy >=90; Chemistry >= 90;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

int math, biology, chemistry;
Console.WriteLine(" Enter your Math result:");
math= Int32.Parse(Console.ReadLine());

Console.WriteLine(" Enter your Bilogy result:");
biology = Int32.Parse(Console.ReadLine()); 

Console.WriteLine(" Enter your Chemistr result:");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90) 
{
    Console.WriteLine("Congratualtiona! Youare accepted");
}
else
{
    Console.WriteLine(" You are  not accepted");
}


