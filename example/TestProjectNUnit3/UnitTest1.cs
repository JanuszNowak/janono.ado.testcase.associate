﻿using NUnit.Framework;

namespace TestProjectNUnit3
{
    [janono.ado.testcase.associate.Organization("janono-pub")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [janono.ado.testcase.associate.TestCase(5)]
        [TestCase("Test Desc")]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        [janono.ado.testcase.associate.TestCase(6)]
        public void Test2()
        {
            Assert.Pass();
        }

        [Test]
        [janono.ado.testcase.associate.TestCase("TestCaseUniqTitle")]
        public void Test3()
        {
            Assert.Pass();
        }
    }
}
