// <copyright file="WebTest5CodedTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.WebTesting;
using WebAndLoadTestProject3;

namespace WebAndLoadTestProject3.Tests
{
    /// <summary>This class contains parameterized unit tests for WebTest5Coded</summary>
    [PexClass(typeof(WebTest5Coded))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class WebTest5CodedTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public WebTest5Coded ConstructorTest()
        {
            WebTest5Coded target = new WebTest5Coded();
            return target;
            // TODO: add assertions to method WebTest5CodedTest.ConstructorTest()
        }

        /// <summary>Test stub for GetRequestEnumerator()</summary>
        [PexMethod]
        public IEnumerator<WebTestRequest> GetRequestEnumeratorTest([PexAssumeUnderTest]WebTest5Coded target)
        {
            IEnumerator<WebTestRequest> result = target.GetRequestEnumerator();
            return result;
            // TODO: add assertions to method WebTest5CodedTest.GetRequestEnumeratorTest(WebTest5Coded)
        }
    }
}
