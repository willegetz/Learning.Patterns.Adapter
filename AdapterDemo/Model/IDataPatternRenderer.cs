using System.Collections.Generic;

namespace AdapterDemo.Model
{
    public interface IDataPatternRenderer
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}