using System.Collections;
using NUnit.Framework;
using Scripts;
using UnityEngine;
using UnityEngine.TestTools;
using TMPro;

namespace Tests
{
    public class ResultDisplayTest
    {
        private ResultDisplay _controller;
        private TextMeshProUGUI _textDisplay;

        [OneTimeSetUp]
        public void Setup()
        {
            var gameObject = new GameObject();
            _controller = gameObject.AddComponent<ResultDisplay>();
            _textDisplay = gameObject.AddComponent<TextMeshProUGUI>();
            _controller.Construct(_textDisplay);
        }

        [UnityTest]
        public IEnumerator PrintResultShouldDisplayValue()
        {
            _controller.PrintResult(1);

            yield return null;

            Assert.AreEqual("1", _textDisplay.text);
        }
    }
}
