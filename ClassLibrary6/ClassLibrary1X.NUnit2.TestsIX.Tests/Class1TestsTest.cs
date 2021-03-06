// <copyright file="Class1TestsTest.cs">Copyright ©  2015</copyright>
using System;
using ClassLibrary1.Tests;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;

namespace ClassLibrary1.Tests.Tests
{
    /// <summary>This class contains parameterized unit tests for Class1Tests</summary>
    [PexClass(typeof(Class1Tests))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class Class1TestsTest
    {
        /// <summary>Test stub for AddTest()</summary>
        [PexMethod]
        public void AddTestTest([PexAssumeUnderTest]Class1Tests target)
        {
            target.AddTest();
            // TODO: add assertions to method Class1TestsTest.AddTestTest(Class1Tests)
        }
    }
}
