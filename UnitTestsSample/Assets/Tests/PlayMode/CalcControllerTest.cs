using System.Collections;
using NUnit.Framework;
using Scripts;
using UnityEngine;
using UnityEngine.TestTools;
using TMPro;

namespace Tests
{
    public class CalculatorControllerTest
    {
        private CalculatorController _controller;
        private TextMeshProUGUI result;
        private TMP_InputField inputA;
        private TMP_InputField inputB;

        [OneTimeSetUp]
        public void Setup()
        {
            var rootObject = new GameObject();
            _controller = rootObject.AddComponent<CalculatorController>();

            var resultObject = new GameObject();
            var resultDisplay = resultObject.AddComponent<ResultDisplay>();
            result = resultObject.AddComponent<TextMeshProUGUI>();
            resultDisplay.Construct(result);

            var fieldObjectA = new GameObject();
            var fieldInputA = fieldObjectA.AddComponent<ValueInputField>();
            inputA = fieldObjectA.GetComponent<TMP_InputField>();

            var fieldObjectB = new GameObject();
            var fieldInputB = fieldObjectB.AddComponent<ValueInputField>();
            inputB = fieldObjectB.GetComponent<TMP_InputField>();

            _controller.Construct(fieldInputA, fieldInputB, resultDisplay);
        }

        [UnityTest]
        public IEnumerator ButtonSumShouldSetSum()
        {
            inputA.text = "4";
            inputB.text = "5";
            _controller.ButtonSum();
            yield return null;
            Assert.AreEqual("9", result.text);
        }

        [UnityTest]
        public IEnumerator ButtonSubtractionShouldSetSubtraction()
        {
            inputA.text = "4";
            inputB.text = "5";
            _controller.ButtonSubtraction();
            yield return null;
            Assert.AreEqual("-1", result.text);
        }

        [UnityTest]
        public IEnumerator ButtonProductShouldSetProduct()
        {
            inputA.text = "4";
            inputB.text = "5";
            _controller.ButtonProduct();
            yield return null;
            Assert.AreEqual("20", result.text);
        }

        [UnityTest]
        public IEnumerator ButtonDivisionShouldSetDivision()
        {
            inputA.text = "4";
            inputB.text = "5";
            _controller.ButtonDivision();
            yield return null;
            Assert.AreEqual("0,8", result.text);
        }
    }
}
