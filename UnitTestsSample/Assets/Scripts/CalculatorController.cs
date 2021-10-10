using UnityEngine;

namespace Scripts
{
    public class CalculatorController : MonoBehaviour
    {
        [SerializeField] private ValueInputField fieldA;
        [SerializeField] private ValueInputField fieldB;
        [SerializeField] private ResultDisplay resultDisplay;

        private float _valueA = 0;
        private float _valueB = 0;
        private float _result = 0;

        public void Construct(ValueInputField fieldA, ValueInputField fieldB, ResultDisplay resultDisplay)
        {
            this.fieldA = fieldA;
            this.fieldB = fieldB;
            this.resultDisplay = resultDisplay;
        }

        private void RefreshFields()
        {
            _valueA = fieldA.Value;
            _valueB = fieldB.Value;
        }

        public void ButtonSum()
        {
            RefreshFields();
            _result = CalculatorLogic.Sum(_valueA, _valueB);
            resultDisplay.PrintResult(_result);
        }

        public void ButtonSubtraction()
        {
            RefreshFields();
            _result = CalculatorLogic.Subtraction(_valueA, _valueB);
            resultDisplay.PrintResult(_result);
        }

        public void ButtonProduct()
        {
            RefreshFields();
            _result = CalculatorLogic.Product(_valueA, _valueB);
            resultDisplay.PrintResult(_result);
        }

        public void ButtonDivision()
        {
            RefreshFields();
            _result = CalculatorLogic.Division(_valueA, _valueB);
            resultDisplay.PrintResult(_result);
        }
    }
}
