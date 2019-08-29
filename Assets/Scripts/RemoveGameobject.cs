using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RemoveGameobject : MonoBehaviour
{
    private void Awake()
    {
        if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "_Assets/scenes/Scene1.cs")))
        {
            gameObject.SetActive(false);
        }
    }
}