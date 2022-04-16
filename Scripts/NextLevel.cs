using UnityEngine;
using IJunior.TypedScenes;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private AppleDisplay _appleDisplay;

    private int _goalApple = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            if (_appleDisplay.CountApple == _goalApple)
            {
                Level2.Load();
            }
            else
            {
                Destroy(player.gameObject);
                EventsManager.SendOnDeadPlayer();
            }
            
        }
    }
}
