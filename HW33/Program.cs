Console.Write("Please enter a sentence: ");
string A = Console.ReadLine();
A = A.Replace(" ", "");
Console.Write("Enter a number in order to categorize the sentence:  ");
int num = Convert.ToInt32(Console.ReadLine());
int d = A.Length / num;
string a = "";
for (int i = 0; i < d; i++)
{
    for(int j = 0; j < num; j++)
    {
        a += A[j];
    }
    a += ",";
    A = A.Substring(num,A.Length-num);
}
for(int i = 0;i <A.Length; i++)
{
    a += A[i] + ",";
}
a = a.Substring(0,a.Length-1);
Console.Write(a);