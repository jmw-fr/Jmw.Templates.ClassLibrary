// <copyright file="Class1UnitTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassLibraryUnitTest
{
    using System;
    using ClassLibrary;
    using Xunit;

    /// <summary>
    /// <see cref="Class1"/> unit tests.
    /// </summary>
    public class Class1UnitTest
    {
        /// <summary>
        /// Test that <see cref="Class1.Method1" /> returns <c>true</c>.
        /// </summary>
        [Fact]
        public void Test1()
        {
            // Arrange
            var sut = new Class1();

            // Act
            bool computed = sut.Method1();

            // Assert
            Assert.True(computed);
        }
    }
}
