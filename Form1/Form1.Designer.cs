
namespace Lab1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
        button1 = new Button();
        afterSortLabel = new RichTextBox();
        beforeSortLabel = new RichTextBox();
        decreasingRadioButton = new RadioButton();
        increasingRadioButton = new RadioButton();
        randomRadioButton = new RadioButton();
        Sort1RadioButton = new RadioButton();
        Sort2RadioButton = new RadioButton();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        arrayLengthText = new TextBox();
        analyzeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        analyzeButton = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)analyzeChart).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(155, 104);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 0;
        button1.Text = "Sort";
        button1.UseVisualStyleBackColor = true;
        button1.Click += SortButton_OnClick;
        // 
        // afterSortLabel
        // 
        afterSortLabel.Location = new Point(155, 134);
        afterSortLabel.Name = "afterSortLabel";
        afterSortLabel.Size = new Size(108, 194);
        afterSortLabel.TabIndex = 1;
        afterSortLabel.Text = "";
        // 
        // beforeSortLabel
        // 
        beforeSortLabel.Location = new Point(30, 134);
        beforeSortLabel.Name = "beforeSortLabel";
        beforeSortLabel.Size = new Size(100, 194);
        beforeSortLabel.TabIndex = 2;
        beforeSortLabel.Text = "";
        // 
        // decreasingRadioButton
        // 
        decreasingRadioButton.AutoSize = true;
        decreasingRadioButton.Location = new Point(6, 20);
        decreasingRadioButton.Name = "decreasingRadioButton";
        decreasingRadioButton.Size = new Size(83, 19);
        decreasingRadioButton.TabIndex = 3;
        decreasingRadioButton.TabStop = true;
        decreasingRadioButton.Text = "Decreasing";
        decreasingRadioButton.UseVisualStyleBackColor = true;
        decreasingRadioButton.CheckedChanged += DecreasingRadioButton_CheckedChanged;
        // 
        // increasingRadioButton
        // 
        increasingRadioButton.AutoSize = true;
        increasingRadioButton.Location = new Point(6, 45);
        increasingRadioButton.Name = "increasingRadioButton";
        increasingRadioButton.Size = new Size(79, 19);
        increasingRadioButton.TabIndex = 4;
        increasingRadioButton.TabStop = true;
        increasingRadioButton.Text = "Increasing";
        increasingRadioButton.UseVisualStyleBackColor = true;
        increasingRadioButton.CheckedChanged += Increasing_CheckedChanged;
        // 
        // randomRadioButton
        // 
        randomRadioButton.AutoSize = true;
        randomRadioButton.Location = new Point(6, 70);
        randomRadioButton.Name = "randomRadioButton";
        randomRadioButton.Size = new Size(70, 19);
        randomRadioButton.TabIndex = 5;
        randomRadioButton.TabStop = true;
        randomRadioButton.Text = "Random";
        randomRadioButton.UseVisualStyleBackColor = true;
        randomRadioButton.CheckedChanged += Random_CheckedChanged;
        // 
        // Sort1RadioButton
        // 
        Sort1RadioButton.AutoSize = true;
        Sort1RadioButton.Location = new Point(6, 20);
        Sort1RadioButton.Name = "Sort1RadioButton";
        Sort1RadioButton.Size = new Size(52, 19);
        Sort1RadioButton.TabIndex = 6;
        Sort1RadioButton.TabStop = true;
        Sort1RadioButton.Text = "Sort1";
        Sort1RadioButton.UseVisualStyleBackColor = true;
        Sort1RadioButton.CheckedChanged += Sort1RadioButtonCheckedChanged;
        // 
        // Sort2RadioButton
        // 
        Sort2RadioButton.AutoSize = true;
        Sort2RadioButton.Location = new Point(6, 45);
        Sort2RadioButton.Name = "Sort2RadioButton";
        Sort2RadioButton.Size = new Size(52, 19);
        Sort2RadioButton.TabIndex = 7;
        Sort2RadioButton.TabStop = true;
        Sort2RadioButton.Text = "Sort2";
        Sort2RadioButton.UseVisualStyleBackColor = true;
        Sort2RadioButton.CheckedChanged += InsertionRadioButton_CheckedChanged;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ButtonFace;
        groupBox1.Controls.Add(increasingRadioButton);
        groupBox1.Controls.Add(decreasingRadioButton);
        groupBox1.Controls.Add(randomRadioButton);
        groupBox1.Location = new Point(30, 2);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(100, 97);
        groupBox1.TabIndex = 9;
        groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(Sort1RadioButton);
        groupBox2.Controls.Add(Sort2RadioButton);
        groupBox2.Location = new Point(155, 2);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(108, 100);
        groupBox2.TabIndex = 10;
        groupBox2.TabStop = false;
        // 
        // arrayLengthText
        // 
        arrayLengthText.Location = new Point(30, 105);
        arrayLengthText.Name = "arrayLengthText";
        arrayLengthText.Size = new Size(100, 23);
        arrayLengthText.TabIndex = 11;
        arrayLengthText.TextChanged += arrayLengthText_TextChanged;
        // 
        // analyzeChart
        // 
        chartArea2.Name = "ChartArea1";
        analyzeChart.ChartAreas.Add(chartArea2);
        legend2.Name = "Legend1";
        analyzeChart.Legends.Add(legend2);
        analyzeChart.Location = new Point(327, 47);
        analyzeChart.Name = "analyzeChart";
        series3.ChartArea = "ChartArea1";
        series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        series3.Legend = "Legend1";
        series3.Name = "Sort1";
        series4.ChartArea = "ChartArea1";
        series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        series4.Legend = "Legend1";
        series4.Name = "Sort2";
        analyzeChart.Series.Add(series3);
        analyzeChart.Series.Add(series4);
        analyzeChart.Size = new Size(365, 300);
        analyzeChart.TabIndex = 12;
        analyzeChart.Text = "chart1";
        // 
        // analyzeButton
        // 
        analyzeButton.Location = new Point(327, 378);
        analyzeButton.Name = "analyzeButton";
        analyzeButton.Size = new Size(75, 23);
        analyzeButton.TabIndex = 13;
        analyzeButton.Text = "Analyze";
        analyzeButton.UseVisualStyleBackColor = true;
        analyzeButton.Click += AnalyzeButton_OnClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(analyzeButton);
        Controls.Add(analyzeChart);
        Controls.Add(arrayLengthText);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(beforeSortLabel);
        Controls.Add(afterSortLabel);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)analyzeChart).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }



    #endregion

    private Button button1;
    private RadioButton increasingRadioButton;
    private RadioButton randomRadioButton;
    protected RadioButton Sort1RadioButton;
    private GroupBox groupBox1;
    protected RadioButton decreasingRadioButton;
    private GroupBox groupBox2;
    private TextBox arrayLengthText;
    protected RichTextBox afterSortLabel;
    protected RichTextBox beforeSortLabel;
    private Button analyzeButton;
    protected System.Windows.Forms.DataVisualization.Charting.Chart analyzeChart;
    protected RadioButton Sort2RadioButton;
}