using Lab1;
using Lab2;

namespace Lab3;

public partial class Form3 : Form2
{
    private readonly ArrayToolWithInversions _arrayToolSortingToolWithMerge = new ();
    
    public Form3() => InitializeComponent();

    protected override void InitializeSortMethods()
    {
        _sortMethods.Add(SortType.Sort1, _arrayToolSortingToolWithMerge.MergeSort);
        _sortMethods.Add(SortType.Sort2, _arrayToolSortingToolWithMerge.InsertingSort);
    }
}