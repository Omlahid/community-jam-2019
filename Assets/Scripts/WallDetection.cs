using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetection : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        transform.parent.GetComponent<Enemy>().Flip();
    }
}
