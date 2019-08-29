using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Illegal : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.Space))
        {
            CrashGame.Crash("File 'Player.controls' is missing or corrupted");
        }
    }
}