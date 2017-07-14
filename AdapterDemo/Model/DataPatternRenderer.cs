using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdapterDemo.Model
{
    class DataPatternRenderer : IDataPatternRenderer
    {
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            /*
             * This class is what will call the datarenderer render method we want to use.
             * A new dataAdapter needs to be created which will fullfill the contract with datarendere
             * for patterns.
             */
            string renderedData;
            var patternDataAdapter = new PatternDataAdapter(patterns);

            var renderer = new DataRenderer(patternDataAdapter);

            using (var writer = new StringWriter())
            {
                renderer.Render(writer);
                renderedData = writer.ToString();
            }

            return renderedData.Trim();
        }
    }
}
