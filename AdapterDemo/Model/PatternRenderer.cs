using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace AdapterDemo.Model
{
    public class PatternRenderer
    {
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return patterns.ToString();
        }
    }
}