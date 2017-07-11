using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace AdapterDemo.Model
{
    public class PatternRenderer
    {
        private readonly IDataPatternRenderer dataPatternRenderer;

        public PatternRenderer(IDataPatternRenderer dataPatternRenderer)
        {
            this.dataPatternRenderer = dataPatternRenderer;
        }

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return dataPatternRenderer.ListPatterns(patterns);
            
        }
    }
}