using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDojo
{
    public class Finder
    {
        public static ArrayList MatchedText(string Pattern, ListBox TextBox)
        {
            ArrayList found = new ArrayList();
            Regex r = new Regex(Pattern, RegexOptions.IgnoreCase);
            foreach (var item in TextBox.Items)
            {
                string[] words = item.ToString().Split(' ');
                foreach (string word in words)
                {
                    if (r.IsMatch(word))
                    {
                        found.Add(word);
                    }
                }
            }
            return found;
        }


    }
}
