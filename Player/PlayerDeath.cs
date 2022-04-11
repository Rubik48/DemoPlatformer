using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(MovementPlayer))]
public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private float _delayForSpawn;

    private Animator _animator;
    private MovementPlayer _movementPlayer;

    private const string Died = nameof(Died);

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _movementPlayer = GetComponent<MovementPlayer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Trap trap))
        {
            StartCoroutine(Death());
        }
    }

    private IEnumerator Death()
    {
        _movementPlayer.enabled = false;

        _movementPlayer.IdleAnimation();

        _animator.SetTrigger(Died);

        yield return new WaitForSeconds(_delayForSpawn);

        transform.position = _startPoint.position;

        _movementPlayer.enabled = true;

        StopCoroutine(Death());
    }
}