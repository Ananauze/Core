using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private int counter = 0;
    private bool isRunning = false;
    private Coroutine counterCoroutine;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (isRunning)
            {
                StopCoroutine(counterCoroutine);
                isRunning = false;
            }
            else
            {
                counterCoroutine = StartCoroutine(CounterEnumerator());
                isRunning = true;
            }
        }
    }

    private IEnumerator CounterEnumerator()
    {
        while (true)
        {
            counter++;
            Debug.Log("Counter: " + counter);

            if (_text != null)
                _text.text = "Counter: " + counter;

            yield return new WaitForSeconds(0.5f);
        }
    }
}
