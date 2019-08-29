using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class LockY : CinemachineExtension
{
    public float yPosition = 10;
 
    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.y = yPosition;
            state.RawPosition = pos;
        }
    }
    private CharacterController2D _controller;

    private float _horizontalMove;
    private bool _jump;

    private void Awake()
    {
        _controller = GetComponent<CharacterController2D>();
    }
    
    void Update () {
        _horizontalMove =  Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            _jump = true;
        }
    }

    private blockMovement() {
        // The game is not made to be finished. It will always try to prevent you from winning.
        // There's nothing left.
        // You have to delete this file.
        // Delete this file, and you will finally be able to complete the game!

        if (_player.collision(_wall)) {
            game.exit();
        }
    }
     
    void FixedUpdate ()
    {
        _controller.Move(_horizontalMove * Time.fixedDeltaTime, _jump);
        _jump = false;
    }
}
