using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace dotnet_trial {
    class Program {
        static void Main (string[] args) {
            var re = new Regex ("a((?<=^aa*)a)*");
            for (int i = 0, p = 1; i <= 14; i++, p *= 2) {
                var s = new string ('a', p);
                var sw = new Stopwatch ();
                sw.Start ();
                for (int j = 0; j < 100; j++) {
                    re.Match (s);
                }
                sw.Stop ();
                Console.WriteLine (String.Format ("{0} {1:F5}", p, sw.Elapsed.TotalSeconds));
            }
        }
    }
}
