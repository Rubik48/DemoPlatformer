using UnityEngine;

public class TrampolineLeft : MonoBehaviour
{
    [SerializeField] private int _jumpForceRight;
    [SerializeField] private int _jumpForceUp;

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
            rbPlayer.AddForce(Vector2.right * _jumpForceRight);
            rbPlayer.AddForce(Vector2.up * _jumpForceUp);

            _animator.SetTrigger(On);
        }
    }
}
