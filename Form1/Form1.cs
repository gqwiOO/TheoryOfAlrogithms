using System.Diagnostics;

namespace Lab1;

public partial class Form1 : Form
{
    protected SortType _currentSortType;
    protected SortOrder _currentSortOrder;

    private int[] _unsortedArray;
    private int _arrayLength;

    private ArraySortingTool _arraySortingTool = new();

    protected readonly Dictionary<SortType, SortDelegate> _sortMethods = new();

    protected delegate int[] SortDelegate(int[] array); 

    public Form1()
    {
        InitializeComponent();
        
        _arrayLength = 10;

        InitializeSortMethods();
    }

    protected virtual void InitializeSortMethods()
    {
        _sortMethods.Add(SortType.Sort1, _arraySortingTool.BubbleSort);
        _sortMethods.Add(SortType.Sort2, _arraySortingTool.InsertingSort);
    }

    protected int[] SortWithTimer(SortDelegate sortDelegate, int[] array)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        var result = sortDelegate.Invoke(array);
        
        stopwatch.Stop();
        
        return result;
    }


    private void Form1_Load(object sender, EventArgs e)
    {
        Sort1RadioButton.PerformClick();
        decreasingRadioButton.PerformClick();

        arrayLengthText.Text = _arrayLength.ToString();
    }

    private void SortButton_OnClick(object sender, EventArgs e)
    {
        var result = SortArray();
        UpdateSortedView(result);
    }

    private int[] SortArray()
    {
        var result = _sortMethods[_currentSortType].Invoke(_unsortedArray);
        return result;
    }

    private void SortAndUpdateView(int[] result)
        => beforeSortLabel.Text = string.Join("\n", result);

    private void UpdateUnsortedView()
        => beforeSortLabel.Text =  string.Join("\n", _unsortedArray);
    private void UpdateSortedView(int[] array)
        => afterSortLabel.Text = string.Join("\n", array);

    private void DecreasingRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        _currentSortOrder = SortOrder.Decreasing;
        _unsortedArray = new int[_arrayLength];

        for (int i = 0; i <= _arrayLength - 1; i++)
            _unsortedArray[i] = i;

        _unsortedArray = _unsortedArray.Reverse().ToArray();

        UpdateUnsortedView();
    }

    private void Increasing_CheckedChanged(object sender, EventArgs e)
    {
        _currentSortOrder = SortOrder.Increasing;
        _unsortedArray = new int[_arrayLength];

        for (int i = 0; i <= _arrayLength - 1; i++)
            _unsortedArray[i] = i;

        UpdateUnsortedView();
    }

    private void Random_CheckedChanged(object sender, EventArgs e)
    {
        _currentSortOrder = SortOrder.Random;
        _unsortedArray = new int[_arrayLength];

        for (int i = 0; i < _arrayLength - 1; i++)
            _unsortedArray[i] = new Random().Next(1, _arrayLength + 1);

        UpdateUnsortedView();
    }

    private void arrayLengthText_TextChanged(object sender, EventArgs e)
    {
        if (!Int32.TryParse(arrayLengthText.Text, out _arrayLength))
            Debug.WriteLine("[Form1] Array length field is not correct");
    }

    private void Sort1RadioButtonCheckedChanged(object? sender, EventArgs e)
        => _currentSortType = SortType.Sort1;

    private void InsertionRadioButton_CheckedChanged(object? sender, EventArgs e)
        => _currentSortType = SortType.Sort2;

    private void AnalyzeButton_OnClick(object sender, EventArgs e)
    {
        ClearSeries();
        var methods = GetTwoAnalyzeSortMethods();
        for (int i = 0; i < methods.Count; i++)
            Analyze(methods[i], i);
    }

    protected virtual void ClearSeries()
    {
        analyzeChart.Series[0].Points.Clear();
        analyzeChart.Series[1].Points.Clear();
    }

    private void Analyze(SortDelegate sortDelegate, int seriesIndex)
    {
        Stopwatch stopwatch = new();
        for (int elements = 10; elements <= 5010; elements += 500)
        {
            stopwatch.Start();
            var array = sortDelegate.Invoke(_unsortedArray);
            stopwatch.Stop();
            analyzeChart.Series[seriesIndex].Points.AddXY(elements, stopwatch.ElapsedTicks);
        }
    }

    protected virtual List<SortDelegate> GetTwoAnalyzeSortMethods() 
        => [_sortMethods[SortType.Sort1], _sortMethods[SortType.Sort2]];
}