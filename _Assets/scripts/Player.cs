using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController2D _controller;

    private float _horizontalMove;
    private bool _jump;

    private void Awake()
    {
        _controller = GetComponent<CharacterController2D>();
    }
    
    // Update is called once per frame
    void Update () {
        _horizontalMove =  Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            _jump = true;
        }
    }
          
    void FixedUpdate ()
    {
        _controller.Move(_horizontalMove * Time.fixedDeltaTime, _jump);
        _jump = false;
    }
}
