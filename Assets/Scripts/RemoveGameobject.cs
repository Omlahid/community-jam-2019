using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGameobject : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            gameObject.SetActive(false);
        }
    }
}
