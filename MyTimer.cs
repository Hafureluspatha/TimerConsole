using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

class MyTimer : System.Timers.Timer
{
    public MyTimer(double interval)
        : base(interval)
    {
        timer1 = new Stopwatch();
        timer2 = new Stopwatch();
        timer3 = new Stopwatch();

        enabled1 = ' ';
        enabled2 = ' ';
        enabled3 = ' ';

        shift1 = 0;
        shift2 = 0;
        shift3 = 0;
    }

    public static Stopwatch timer1;//147Basic
    public static Stopwatch timer2;//285Good
    public static Stopwatch timer3;//396Happiness

    public static TimeSpan ts1;
    public static TimeSpan ts2;
    public static TimeSpan ts3;

    public static char enabled1;
    public static char enabled2;
    public static char enabled3;

    public static int shift1;
    public static int shift2;
    public static int shift3;

    public static void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        Console.Clear();

        ts1 = timer1.Elapsed;
        ts2 = timer2.Elapsed;
        ts3 = timer3.Elapsed;

        //Output
        Console.WriteLine("147Basic      {0}:{1:d2} {2}", ts1.Hours * 60 + ts1.Minutes + shift1, ts1.Seconds, enabled1);
        Console.WriteLine("285Good       {0}:{1:d2} {2}", ts2.Hours * 60 + ts2.Minutes + shift2, ts2.Seconds, enabled2);
        Console.WriteLine("396Happiness  {0}:{1:d2} {2}", ts3.Hours * 60 + ts3.Minutes + shift3, ts3.Seconds, enabled3);

    }//t_Elapsed
}//MyTimer