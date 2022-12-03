Console.Clear();
int [] array = {55, 5, 12, 8, 9, 100, 10};
int n = array.Length;
int i = 0;
int maxberrycount = 0;
int berrycount = 0;
berrycount = array[n-1] + array [i] + array [i+1];
maxberrycount = berrycount;
i++;
while (i < n-1 && i!= 0)
    {
        berrycount = array[i-1] + array [i] + array [i+1];
        i++;
        while (maxberrycount < berrycount)
        {
            maxberrycount = berrycount;
        }
        if (i == n-1)
        berrycount = array[i-1] + array [i] + array [0];
        if (maxberrycount < berrycount)
        maxberrycount = berrycount;
    }
Console.Write($"Максимальное число ягод: {maxberrycount}");
    




