using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrashGame : MonoBehaviour
{
    private static GameObject _gameObject;

    private void Awake()
    {
        _gameObject = gameObject;
        _gameObject.SetActive(false);
    }

    public static void Crash(String message)
    {
        _gameObject.SetActive(true);
        GameObject.FindWithTag("ErrorMessage").GetComponent<Text>().text = message;
        Time.timeScale = 0;
    }
}
