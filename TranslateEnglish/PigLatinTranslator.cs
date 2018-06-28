using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateEnglish
{
    class PigLatinTranslator : ITranslator
    {
        public string Translate(string text)
        {
            var result = new List<string>();
            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = text.Split().Select(x => x.Trim(punctuation));
            foreach (string i in words)
            {
                result.Add(i);
            }
            for (int i = 0; i < result.Count; i++)
            {
                result[i] = "Latin" + result[i];
            }
            string k = string.Join(" ", result.ToArray());
            return k;
        }
    }
}
