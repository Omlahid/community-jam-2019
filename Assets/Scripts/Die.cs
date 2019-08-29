using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Die : MonoBehaviour
{
    [SerializeField] private String[] messages;

    private void OnTriggerStay2D(Collider2D other)
    {
        CrashGame.Crash(messages[Random.Range(0, messages.Length)]);
    }
}