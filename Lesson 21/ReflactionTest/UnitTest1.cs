using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson_21;

namespace ReflactionTest
{
    [TestClass]
    public class MyClassTest
    {
        [TestMethod]
        public void TestMethod1_assdad_sfsfs()
        {
            //Arreng
            MyClass calc = new MyClass();

            //Act

            int result = calc.Dev(10, 5);
            //Assert

            Assert.AreEqual(2, result);

        }
    }
}
