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
            var sb = new StringBuilder();
            sb.AppendLine("Rendering Data:");
            sb.AppendLine("Id".PadRight(20) + " " + "Name".PadRight(20) + " " + "Description".PadRight(20) + " ");

            foreach (var pattern in patterns)
            {
                sb.AppendLine(pattern.Id.ToString().PadRight(20) + " " + pattern.Name.ToString().PadRight(20) + " " + pattern.Description.ToString().PadRight(20) + " ");
            }

            return sb.ToString().Trim();
        }
    }
}