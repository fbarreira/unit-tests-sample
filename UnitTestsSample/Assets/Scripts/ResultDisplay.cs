using TMPro;
using UnityEngine;

namespace Scripts
{
    public class ResultDisplay : MonoBehaviour
    {
        [SerializeField] private TMP_Text result;

        public void Construct(TextMeshProUGUI result)
        {
            this.result = result;
        }

        public void PrintResult(float value) => result.text = value.ToString();
    }
}