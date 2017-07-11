using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterDemo.Model
{
    class DataPatternRenderer : IDataPatternRenderer
    {
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
