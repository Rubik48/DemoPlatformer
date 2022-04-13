using UnityEngine;
using IJunior.TypedScenes;

public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            Level2.Load();
        }
    }
}
