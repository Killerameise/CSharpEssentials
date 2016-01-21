// <copyright file="UseGetterOnlyAutoPropertyAnalyzerTest.cs">Copyright © Dustin Campbell 2015</copyright>
using System;
using CSharpEssentials.GetterOnlyAutoProperty;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpEssentials.GetterOnlyAutoProperty.Tests
{
    /// <summary>This class contains parameterized unit tests for UseGetterOnlyAutoPropertyAnalyzer</summary>
    [PexClass(typeof(UseGetterOnlyAutoPropertyAnalyzer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UseGetterOnlyAutoPropertyAnalyzerTest
    {
    }
}

