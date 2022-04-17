using System;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static event Action AppleRemoved;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            AppleRemoved?.Invoke();
            Destroy(gameObject);  
        }
    }
}