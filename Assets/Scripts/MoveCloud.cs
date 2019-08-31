using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    private RectTransform _canvas;
    private RectTransform _cloud;
    private Vector3 _startingPosition;
    public float speed = -4f;

    void Start()
    {
        _cloud = gameObject.GetComponent<RectTransform>();
        _canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
        _startingPosition = transform.position;
    }

    void FixedUpdate()
    {
        transform.Translate(speed, 0f, 0f);

        if (_cloud.position.x < -_cloud.rect.width - 100)
            transform.position = new Vector3((_canvas.rect.width + _cloud.rect.width + 100) * _canvas.localScale.x,
                (_canvas.rect.height * 0.5f + Random.Range(-_canvas.rect.height * 0.2f, _canvas.rect.height * 0.4f)) *
                _canvas.localScale.y, _startingPosition.z);
    }
}