using System.Collections;
using NUnit.Framework;
using Scripts;
using UnityEngine;
using UnityEngine.TestTools;
using TMPro;
using UnityEditor;

namespace Tests
{
    public class CalculatorControllerTestWithPrefab
    {
        private CalculatorController _controller;
        private TextMeshProUGUI result;
        private TMP_InputField inputA;
        private TMP_InputField inputB;

        // For this test it will be used a prefab.
        [OneTimeSetUp]
        public void Setup()
        {
            var calculatorPrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Calculator.prefab", typeof(GameObject));

            _controller = calculatorPrefab.GetComponentInChildren<CalculatorController>();

            TMP_InputField[] inputs = calculatorPrefab.GetComponentsInChildren<TMP_InputField>();
            inputA = inputs[0];
            inputB = inputs[1];

            var resultDisplay = calculatorPrefab.GetComponentInChildren<ResultDisplay>();
            result = resultDisplay.gameObject.GetComponentInChildren<TextMeshProUGUI>();
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
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
