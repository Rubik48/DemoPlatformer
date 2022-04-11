using UnityEngine;
using UnityEngine.Events;

public class Apple : MonoBehaviour
{
    public event UnityAction DestroyApple;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            DestroyApple?.Invoke();
            Destroy(gameObject);  
        }
    }
}