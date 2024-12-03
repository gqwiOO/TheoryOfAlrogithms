using Lab1;

namespace Lab2;

public partial class Form2 : Form1
{
    private readonly ArraySortingToolWithMerge _arrayToolSortingToolWithMerge = new ();
    
    public Form2() => InitializeComponent();

    protected override void InitializeSortMethods()
    {
        _sortMethods.Add(SortType.Sort1, _arrayToolSortingToolWithMerge.InsertingSort);
        _sortMethods.Add(SortType.Sort2, _arrayToolSortingToolWithMerge.MergeSort);
    }
}