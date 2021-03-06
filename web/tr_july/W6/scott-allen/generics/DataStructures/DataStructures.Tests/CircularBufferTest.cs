// <copyright file="CircularBufferTest.cs" company="SAXO">Copyright © SAXO 2017</copyright>
using System;
using DataStructures;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    /// <summary>This class contains parameterized unit tests for CircularBuffer</summary>
    [PexClass(typeof(CircularBuffer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CircularBufferTest
    {
        /// <summary>Test stub for .ctor(Int32)</summary>
        [PexMethod]
        public CircularBuffer ConstructorTest(int capacity)
        {
            CircularBuffer target = new CircularBuffer(capacity);
            return target;
            // TODO: add assertions to method CircularBufferTest.ConstructorTest(Int32)
        }
    }
}
