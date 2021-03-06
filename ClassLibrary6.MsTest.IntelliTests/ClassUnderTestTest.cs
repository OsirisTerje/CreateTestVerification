// <copyright file="ClassUnderTestTest.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareUnderTest;

namespace SoftwareUnderTest.Tests
{
    /// <summary>This class contains parameterized unit tests for ClassUnderTest</summary>
    [PexClass(typeof(ClassUnderTest))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ClassUnderTestTest
    {
        /// <summary>Test stub for Add(Int32, Int32)</summary>
        [PexMethod]
        public int AddTest(
            [PexAssumeUnderTest]ClassUnderTest target,
            int a,
            int b
        )
        {
            int result = target.Add(a, b);
            return result;
            // TODO: add assertions to method ClassUnderTestTest.AddTest(ClassUnderTest, Int32, Int32)
        }
    }
}
