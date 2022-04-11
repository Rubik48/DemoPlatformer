using UnityEngine;
using DG.Tweening;

public class RotationTrap : MonoBehaviour
{
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _asixZ;

    private Transform _transform;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        transform.DORotate(new Vector3(0, 0, _asixZ), _speedRotation).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
