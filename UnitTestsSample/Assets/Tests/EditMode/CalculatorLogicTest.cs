using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Scripts;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CalculatorLogicTest
    {
        private float _a;
        private float _b;

        [OneTimeSetUp]
        public void Setup()
        {
            _a = 2;
            _b = 0;
        }

        [Test]
        public void SumShouldReturnAPlusB()
        {
            Assert.AreEqual(_a + _b, CalculatorLogic.Sum(_a, _b));
        }

        [Test]
        public void SubtractionShouldReturnALessB()
        {
            Assert.AreEqual(_a - _b, CalculatorLogic.Subtraction(_a, _b));
        }

        [Test]
        public void ProductShouldReturnATimesB()
        {
            Assert.AreEqual(_a * _b, CalculatorLogic.Product(_a, _b));
        }

        [Test]
        public void DivisionShouldReturnADividedByB()
        {
            Assert.AreEqual(_a / _b, CalculatorLogic.Division(_a, _b));
        }



    }
}
