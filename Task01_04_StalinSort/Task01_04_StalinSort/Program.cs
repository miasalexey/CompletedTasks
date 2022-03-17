using static System.Int32;

// input from console numbers
Console.WriteLine("Please enter numbers over space");
var inputText = Console.ReadLine();
var splitInputText = inputText?.Split(' ');
var numberList = new List<int>();
if (splitInputText != null)
    foreach (var number in splitInputText)
    {
        if (TryParse(number, out var j))
        {
            numberList.Add(j);
        }
    }

// Call function 
var listAfterStalinSort = Task4(numberList);

// outPut result 
foreach (var number in listAfterStalinSort)
{
    Console.Write($"{number} ");
}

// Task4 function 
static List<int> Task4(IReadOnlyList<int> array)
{
    // initialize a temporary leaf with the maximum possible capacity
    var res = new List<int>(array.Count);
    for (var i = array.Count - 1; i > 0; i--)
    {
        if (array[i] >= array[i - 1])
        {
            res.Add(array[i]);
        }
    }

    // the first leftmost number is added anyway
    res.Add(array[0]);
    res.Reverse();
    return res;
}