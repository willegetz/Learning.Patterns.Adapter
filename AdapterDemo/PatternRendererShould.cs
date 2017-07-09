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
         * We want the PatternRenderer to display its data like the DataRenderer displays data.
         * Before we can refactor, we have to finish writing our tests to ensure the code doesn't
         * break as we work.
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

            var renderer = new PatternRenderer();

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

            var renderer = new PatternRenderer();

            var result = renderer.ListPatterns(patterns);

            Approvals.Verify(result);
        }
    }
}