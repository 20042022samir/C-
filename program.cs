

#region task-1
do
{
    try
    {

        Console.WriteLine("neçe eded daxil etmek isteyirsiniz?");
        int numbers = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("zehmet olmasa " + (i + 1) + "-ci ededi daxil edin");
            int x = Convert.ToInt32(Console.ReadLine());
            array[i] = x;
        }

        Console.WriteLine("zehmet olmasa yoxlamaq istediyiniz ededi daxil edin");
        int num = Convert.ToInt32(Console.ReadLine());

        sum(num);
        void sum(int eded)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine("eded vardir");

                }
            }
        }
    }
    catch (Exception)
    {
        Console.WriteLine("duzgun eded daxil edin");
    }
}
while (true);
#endregion





#region task-->2
try
{
    Console.WriteLine("zehmet olmasa nece eded daxil etmek istediyinzi daxil edin");
    int numbers = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[numbers];

    for (int i = 0; i < numbers; i++)
    {
        Console.WriteLine("zehmet olmasa " + (i + 1) + "-ci ededi daxil edin");
        int x = Convert.ToInt32(Console.ReadLine());
        array[i] = x;
    }

    int biggest = 0;
    sum(array);
    void sum(int[] araliq)
    {
        for (int i = 0; i < araliq.Length; i++)
        {
            if (araliq[i] > biggest)
            {
                biggest = araliq[i];
            }
        }
    }
    Console.WriteLine("daxil etdiyiniz ededler arasinda en boyuyu-->"+biggest);
}
catch (Exception)
{
    Console.WriteLine("zehmet olmasa duzgun eded daxil edin");
}
#endregion
