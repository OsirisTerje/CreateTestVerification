// <copyright file="Class1Test.cs">Copyright ©  2015</copyright>
using System;
using SoftwareUnderTest;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;

namespace SoftwareUnderTest.Tests
{
    /// <summary>This class contains parameterized unit tests for Class1</summary>
    [PexClass(typeof(ClassUnderTest))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class ClassNUnit2IntelliTest
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
            // TODO: add assertions to method Class1Test.AddTest(Class1, Int32, Int32)
        }
    }
}
