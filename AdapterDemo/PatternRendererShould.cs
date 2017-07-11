using AdapterDemo.Model;
using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AdapterDemo
{
    [TestClass]
    [UseReporter(typeof(VisualStudioReporter))]
    public class PatternRendererShould
    {
        /*
         * PatternRenderer now expects an object in its constructor.
         * I'm passing 'null' as it is the simplest way to make the tests pass.
         */

        [TestMethod]
        public void RenderOneRowGivenOnePatternInList()
        {
            var pattern = new Pattern
            {
                Id = 1,
                Name = "A Pattern",
                Description = "Test object for testing."
            };

            var patterns = new List<Pattern>() { pattern };

            var renderer = new PatternRenderer(null);

            var result = renderer.ListPatterns(patterns);

            Approvals.Verify(result);
        }

        [TestMethod]
        public void RenderTwoRowsGivenTwoPatternsInList()
        {
            var patternOne = new Pattern
            {
                Id = 1,
                Name = "A Pattern",
                Description = "Test object for testing."
            };

            var patternTwo = new Pattern
            {
                Id = 2,
                Name = "Another Pattern",
                Description = "A friend to pattern one."
            };

            var patterns = new List<Pattern>() { patternOne, patternTwo };

            var renderer = new PatternRenderer(null);

            var result = renderer.ListPatterns(patterns);

            Approvals.Verify(result);
        }
    }
}