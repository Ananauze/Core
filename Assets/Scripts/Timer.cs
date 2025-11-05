using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private int _counter = 0;
    private bool _isRunning = false;
    private Coroutine _counterCoroutine;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (_isRunning)
            {
                StopCoroutine(_counterCoroutine);
                _isRunning = false;
            }
            else
            {
                _counterCoroutine = StartCoroutine(CounterEnumerator());
                _isRunning = true;
            }
        }
    }

    private IEnumerator CounterEnumerator()
    {
        while (true)
        {
            _counter++;
            Debug.Log("Counter: " + _counter);

            if (_text != null)
                _text.text = "Counter: " + _counter;

            yield return new WaitForSeconds(0.5f);
        }
    }
}
