using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0242;
using R5T.T0243;


namespace R5T.V0002
{
    [TestFixtureMarker]
    public abstract class PathOperatorTestFixture<TTestArticle> : TestFixtureBase<TTestArticle>
        where TTestArticle : IPathOperatorTestArticle
    {
        [TestMethod]
        public void Combine_ToFilePath()
        {
            var expectation = Instances.Expectations.Combine_ToFilePath;

            Instances.TestOperator.Test_Function(
                this.TestArticle.Combine_ToFilePath,
                expectation);
        }

        [TestMethod]
        public void Is_WindowsPath_True()
        {
            //// Explicit setup.
            //var path = Instances.Paths.N001;
            //var expected = Instances.Values.True;

            //var actual = this.TestArticle.Is_Windows(path);

            //Assert.AreEqual(expected, actual);

            //// Use an expectation.
            //var expectation = Instances.Expectations.Is_WindowsPath_True;

            //Instances.TestOperator.Test_Function(
            //    this.TestArticle.Is_Windows,
            //    expectation);

            //// Use the full test.
            //var test = Instances.TestGenerator.Get_Is_WindowsPath_True(this.TestArticle);

            //Instances.TestOperator.Run(test);

            // => I like the expectation the best in the context of a test fixture.
            var expectation =
                Instances.Expectations.Is_WindowsPath_True
                //Instances.Expectations.Is_WindowsPath_ShouldFail
                ;

            Instances.TestOperator.Test_Function(
                this.TestArticle.Is_Windows,
                expectation);
        }
    }
}
