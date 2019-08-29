using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        SceneManager.LoadScene("End", LoadSceneMode.Single);
    }
}
