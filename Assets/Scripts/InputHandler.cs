using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _counter.Toggle();
        }
    }
}
