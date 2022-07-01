using System.Linq;

List<int> q = new List<int>() { 1, 2, 5, 3, 7, 8, 6, 4 };


var s = 0;
var j = 1;
var count = q.Count;
var r = q.OrderBy(x => x).ToList();

for (var i = 0; i < count; i++)
{
    if (q[i] - (i + 1) > 2)
    {
        Console.WriteLine("Too chaotic");
        break;
    }

    if (j < count && q[i] > q[j])
    {
        var p = r.FindIndex(x => x == q[i]);


    }

    j++;

}

if (s > 0)
    Console.WriteLine(s);
