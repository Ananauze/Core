using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        _text.text = "";
        StartCoroutine(CountDown(1));
    }

    private IEnumerator CountDown(float delay, int start = 10)
    {
        var wait = new WaitForSeconds(delay);

        for (int i = start; i > 0; i--)
        {
            DisplayCountDown(i);
            yield return wait;
        }
    }

    private void DisplayCountDown(int count)
    {
        _text.text = count.ToString("");
    }
}
