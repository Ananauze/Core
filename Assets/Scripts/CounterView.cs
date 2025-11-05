using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TMP_Text _counterText;

    private void OnEnable()
    {
        _counter.OnValueChanged += UpdateView;
    }

    private void OnDisable()
    {
        _counter.OnValueChanged -= UpdateView;
    }

    private void UpdateView(int value)
    {
        if (_counterText != null)
            _counterText.text = $"Counter: {value}";
    }
}
