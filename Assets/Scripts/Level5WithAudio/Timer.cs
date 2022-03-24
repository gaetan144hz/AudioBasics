using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public float delay;
    public bool startOnAwake;
    public bool loop;

    public UnityEvent onStart, onStop, onEnd, onTick;

    private Coroutine coroutine;

    private void Awake()
    {
        if (startOnAwake)
            StartTimer();
    }

    public void StartTimer()
    {
        if (coroutine == null)
            onStart?.Invoke();
        coroutine = StartCoroutine(TimerCoroutine());
    }

    public void StopTimer()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
            onStop?.Invoke();
        }
        coroutine = null;
    }

    public void RestartTimer()
    {
        StopTimer();
        StartTimer();
    }

    private IEnumerator TimerCoroutine()
    {
        yield return new WaitForSeconds(delay);
        onTick?.Invoke();
        if (loop)
            StartTimer();
        else
            onEnd?.Invoke();
    }
}
