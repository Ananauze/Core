using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TMP_Text _counterText;

    private void OnEnable()
    {
        _counter.ValueChanged += UpdateView;
    }

    private void OnDisable()
    {
        _counter.ValueChanged -= UpdateView;
    }

    private void UpdateView(int value)
    {
        if (_counterText != null)
            _counterText.text = $"Counter: {value}";
    }
}
