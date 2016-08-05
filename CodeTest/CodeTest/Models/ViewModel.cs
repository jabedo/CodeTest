using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.Models
{
    public class ViewModel
    {
        public string Num { get; set; }
        public List<int> Values { get; set; }

        public String DisplayValues()
        {
            String val = String.Empty;

            foreach(var val1 in Values)
            {
                if (String.IsNullOrEmpty(val.ToString()))
                    val = string.Format("{0}", val1);
                else
                    val = string.Format("{0},{1}", val, val1);


            }


            return string.Format("[{0}]", val);
        }

    }

    public class Utility
    {
        public static List<int> GetValues(Models.ViewModel model)
        {
            string num = model.Num;
            const int subStringValue = 10;
            List<int> values = new List<int>();

            if (!String.IsNullOrEmpty(num))
            {
                int iterVal = int.Parse(num) + 1;

                for (int i = 0; i < iterVal; i++)
                {
                    int total = 0;
                    char[] chars = i.ToString().ToCharArray();
                    foreach (char c in chars)
                    {
                        total += int.Parse(c.ToString());

                    }

                    if (total == subStringValue)
                        values.Add(i);

                }

            }
            return values;
        }
    }
}