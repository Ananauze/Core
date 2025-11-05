using System.Collections;
using System;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public event Action<int> OnValueChanged;

    [SerializeField] private float _interval = 0.5f;

    private int _count;
    private bool _isRunning;
    private Coroutine _counterCoroutine;
    private WaitForSeconds _wait;

    private void Awake()
    {
        _wait = new WaitForSeconds(_interval);
    }

    public void Toggle()
    {
        if (_isRunning)
            StopCounting();
        else
            StartCounting();
    }

    public void StartCounting()
    {
        if (_isRunning) return;
        _isRunning = true;
        _counterCoroutine = StartCoroutine(CountRoutine());
    }

    public void StopCounting()
    {
        if (!_isRunning || _counterCoroutine == null) return;
        StopCoroutine(_counterCoroutine);
        _counterCoroutine = null;
        _isRunning = false;
    }

    private IEnumerator CountRoutine()
    {
        while (enabled)
        {
            _count++;
            OnValueChanged?.Invoke(_count);
            yield return _wait;
        }
    }
}
