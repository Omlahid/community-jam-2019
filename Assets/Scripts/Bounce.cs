using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private RectTransform _canvas;
    private RectTransform _cloud;
    public float speed = -4f;
    private float x = 1;
    private float y = 1;
    
    void Start()
    {
        _cloud = gameObject.GetComponent<RectTransform>();
        _canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
    }

    void FixedUpdate()
    {
        transform.Translate(0, speed * y, 0f);

        if (_cloud.position.x <= _cloud.rect.width * 0.5f || _cloud.position.x >= _canvas.rect.width + _cloud.rect.width * 0.4f)
        {
            x *= -1;
        }

        if (_cloud.position.y <= _cloud.rect.height * 0.5f || _cloud.position.y >= _canvas.rect.height)
        {
            y *= -1;
        }
            
    }
}
