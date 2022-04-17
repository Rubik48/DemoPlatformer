using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(MovementPlayer))]
public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private float _delay;

    private Animator _animator;
    private MovementPlayer _movementPlayer;

    public static event Action PlayerDied;

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
            _movementPlayer.enabled = false;

            _movementPlayer.Idle();

            _animator.SetTrigger(Died);

            SendOnPlayerDied();

            Invoke("EnableMove", _delay);
        }
    }

    private void EnableMove()
    {
        _movementPlayer.enabled = true;
    }

    public static void SendOnPlayerDied()
    {
        PlayerDied?.Invoke();
    }
}