using UnityEngine;
using IJunior.TypedScenes;

public class Finish : MonoBehaviour
{
    [SerializeField] private AppleDisplay _appleDisplay;

    private int _goalApple = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            if (_appleDisplay.CountApple == _goalApple)
            {
                EndGame.Load();
            }
            else
            {
                EventsManager.SendOnDeadPlayer();
            }

        }
    }
}
