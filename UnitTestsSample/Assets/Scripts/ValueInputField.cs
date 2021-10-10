using UnityEngine;
using TMPro;
using UnityEngine.Events;

namespace Scripts
{
    [RequireComponent(typeof(TMP_InputField))]
    public class ValueInputField : MonoBehaviour
    {
        [SerializeField] private TMP_InputField field;

        public UnityEvent<float> updateFieldEvent;

        private void Awake() => field = GetComponent<TMP_InputField>();

        public float Value => GetParsedValue();

        private float GetParsedValue() => ParserUtil.TryParseFloat(field.text);
    }
}