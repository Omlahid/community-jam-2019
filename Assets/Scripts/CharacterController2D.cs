using System.IO;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float jumpForce = 400f; // Amount of force added when the player jumps.
    [SerializeField] private float runForce = 40f; // Amount of force added when the player jumps.

    [Range(0, .3f)] [SerializeField] private float movementSmoothing = .05f; // How much to smooth out the movement
    [SerializeField] private bool airControl; // Whether or not a player can steer while jumping;
    [SerializeField] private LayerMask whatIsGround; // A mask determining what is ground to the character
    [SerializeField] private Transform groundCheck; // A position marking where to check if the player is grounded.

    const float GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
    private bool _grounded; // Whether or not the player is grounded.
    private new Rigidbody2D _rigidbody2D;
    private bool _facingRight = true; // For determining which way the player is currently facing.
    private Vector3 _velocity = Vector3.zero;
    private Animator _animator;

    [Header("Events")] [Space] public UnityEvent onLandEvent;
    private static readonly int Speed = Animator.StringToHash("speed");
    private static readonly int Grounded = Animator.StringToHash("grounded");
    private AudioSource _audioSource;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();

        if (onLandEvent == null)
            onLandEvent = new UnityEvent();
    }

    private void FixedUpdate()
    {
        bool wasGrounded = _grounded;
        _grounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, GroundedRadius, whatIsGround);
        foreach (var collider in colliders)
        {
            if (collider.gameObject == gameObject) continue;
            _grounded = true;
            if (!wasGrounded)
                onLandEvent.Invoke();
        }

        _animator.SetBool(Grounded, _grounded);
    }


    public void Move(float move, bool jump)
    {
        if (_grounded || airControl)
        {
            var velocity = _rigidbody2D.velocity;
            Vector3 targetVelocity = new Vector2(move * runForce, velocity.y);
            _rigidbody2D.velocity =
                Vector3.SmoothDamp(velocity, targetVelocity, ref _velocity, movementSmoothing);

            _animator.SetFloat(Speed, Mathf.Abs(_rigidbody2D.velocity.x));

            if (move > 0 && !_facingRight)
            {
                Flip();
            }
            else if (move < 0 && _facingRight)
            {
                Flip();
            }
        }

        if (_grounded && jump)
        {
            _grounded = false;
            _rigidbody2D.AddForce(new Vector2(0f, jumpForce));
            _audioSource.Play();
        }
    }


    private void Flip()
    {
        _facingRight = !_facingRight;

        var transform1 = transform;
        Vector3 theScale = transform1.localScale;
        theScale.x *= -1;
        transform1.localScale = theScale;
    }
}