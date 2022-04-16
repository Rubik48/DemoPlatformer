using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Trampoline : MonoBehaviour
{
    [SerializeField] private int _jumpForce;

    private Animator _animator;

    private const string On = nameof(On);

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            Rigidbody2D rbPlayer = player.GetComponent<Rigidbody2D>();
            rbPlayer.AddForce(Vector2.up * _jumpForce);

            _animator.SetTrigger(On);
        }
    }
}