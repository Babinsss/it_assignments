Console.WriteLine(@"
Select A Number:

1 -> MinMax.cs
2 -> ArraySum.cs
");

switch (Int16.Parse(Console.ReadLine())) {
    case 1:
        MinMax.MinMaxSolution();
        break;
    case 2: 
        ArraySum.ArraySumSolution();
        break;
}