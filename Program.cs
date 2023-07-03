List<List<int>> arr = new List<List<int>>();
List<int> list = new List<int>() { 1, 2, 3 };
list.AddRange(new List<int>() { 1, 2, 3 });
arr.Add(list);
list.Clear();
list.AddRange(new List<int>() { 4, 5, 6 });
arr.Add(list);
list.Clear();
list.AddRange(new List<int>() { 9, 8, 9 });
arr.Add(list);

for (int i = 0, j = arr.Count - 1; i < arr.Count && j >= 0; i++, j--)
{
    //Console.WriteLine($"{i} {j} arr[i][j] ");
    Console.WriteLine($"{i} {i} arr[i][i] ");

}