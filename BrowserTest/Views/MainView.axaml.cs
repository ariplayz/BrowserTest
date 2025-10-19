using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;

namespace BrowserTest.Views;

public partial class MainView : UserControl
{
    private string CSV_FILE_PATH = string.Empty;
    private Dictionary<string, NumericUpDown> controlMap = new();
    private bool isInitialized = false;

    public MainView()
    {
        // First initialize the component
        InitializeComponent();
    }

    public void calculate()
    {
        double pages = (double)(pagesIn?.Value ?? 0);
        double pagesbonusnum = pages / 50;
        double pagesbonus = Math.Round(pagesbonusnum, 0) * 25;
        double pagepoints = pagesbonus + (pages * 10);

        double lectures = (double)(lecturesIn?.Value ?? 0);
        lectures = lectures * 5;

        double passcheckout = (double)(passcheckoutIn?.Value ?? 0);
        passcheckout = passcheckout + (double)(givecheckoutIn?.Value ?? 0);
        double passcheckoutpoints = passcheckout * 3;
        double findmu = (double)(findmuIn?.Value ?? 0);
        double findmupoints = findmu * 5;
        double checkoutdemo = (double)(checkoutdemoIn?.Value ?? 0);
        double checkoutdemopoints = checkoutdemo * 3;

        double word = (double)(wordIn?.Value ?? 0);
        double wordclearing = (double)(wordclearingIn?.Value ?? 0);
        double theorycoaching = (double)(theorycoachingIn?.Value ?? 0);
        double wordpoints = (word * 3) + (wordclearing * 150) + (theorycoaching * 5);

        double drill = (double)(drillIn?.Value ?? 0);
        double drillpoints = drill * 40;

        double verbatim = (double)(verbatimIn?.Value ?? 0);
        double practical = (double)(practicalIn?.Value ?? 0);
        double completeshortpractical = (double)(completeshortpracticalIn?.Value ?? 0);
        double completelongpractical = (double)(completelongpracticalIn?.Value ?? 0);
        double practicalpoints = (verbatim * 10) + (practical * 150) + (completeshortpractical * 100) + (completelongpractical * 500);

        double checksheetdemo = (double)(checksheetdemoIn?.Value ?? 0);
        double demo = (double)(demoIn?.Value ?? 0);
        double claydemo = (double)(claydemoIn?.Value ?? 0);
        double essay = (double)(essayIn?.Value ?? 0);
        double demopoints = (checksheetdemo * 5) + (demo * 3) + (claydemo * 50) + (essay * 10);

        double course = (double)(courseIn?.Value ?? 0) + (double)(coursebonusIn?.Value ?? 0);
        double coursepoints = course * 2000;

        double penalty = (double)(penaltyIn?.Value ?? 0);
        double penaltypoints = penalty * -200;
        
        double points = pagepoints + lectures + passcheckoutpoints + findmupoints + checkoutdemopoints + 
                       wordpoints + drillpoints + practicalpoints + demopoints + coursepoints + penaltypoints;
        
        if (display != null)
        {
            display.Content = points.ToString();
        }
    }
}