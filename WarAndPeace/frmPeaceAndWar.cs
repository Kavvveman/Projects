using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarAndPeace
{
    public partial class frmPeaceAndWar : Form
    {
        //Done By Kaven Mclean 2022/05/05

        public frmPeaceAndWar()
        {
            InitializeComponent();
            lbWords.Items.Clear();
        }


        //Sorts top 50 longest words
        private void btnSortAll_Click(object sender, EventArgs e)
        {

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Thread.Sleep(500);

            var allWords = Regex.Split(File.ReadAllText(@"C:\Users\Kaven\source\repos\WarAndPeace\Book\WarAndPeace.txt"), @"[\s,;:.—!?-]+");

            List<string> AllWordsCollection = allWords.ToList();

            List<string> Top50Longest = allWords.OrderByDescending(n => n.Length).Take(50).ToList();

            Top50Longest.Sort((a, b) => b.Length - a.Length);

            lbWords.DataSource = Top50Longest;

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            lbElapsedTime.Text =
             +ts.Hours + " Hours \n"
             + ts.Minutes + "Minutes \n"
             + ts.Seconds + "Seconds \n"
             +ts.Milliseconds + "MilliSeconds"; 

        }


        //Top 50 where words longer than 6 chars(Shows Count)
        private void btnTop50_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Thread.Sleep(500);

            var allWords = Regex.Split(File.ReadAllText(@"C:\Users\Kaven\source\repos\WarAndPeace\Book\WarAndPeace.txt"), @"[\s,;:.—!?/-]+");

            List<string> AllWordsCollection = allWords.ToList();

            List<string> Words6characters = new List<string>(2);


            var dtWordProperties = Words6characters;

     
            foreach (var item in AllWordsCollection)
            {
                if (item.Length > 6)
                {
                    Words6characters.Add(item);
                }
            }
        
            //Get the top 50 (Words with Highest Count

            var mostCommons = Words6characters.GroupBy(x => x)
             .Select(x => new { x.Key, Count = x.Count() })
             .OrderByDescending(x => x.Count).Take(50);

            lbWords.DataSource = mostCommons.ToList();

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            lbElapsedTime.Text =
             +ts.Hours + " Hours \n"
             + ts.Minutes + "Minutes \n"
             + ts.Seconds + "Seconds \n"
             +ts.Milliseconds + "MilliSeconds";
        }
    }
}
