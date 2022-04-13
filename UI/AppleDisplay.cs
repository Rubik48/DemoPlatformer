using UnityEngine;
using TMPro;

public class AppleDisplay : MonoBehaviour
{
    [SerializeField] private SpawnerApple _spawner;
    [SerializeField] private TMP_Text _showText;

    private int _countApple;

    private void Start()
    {
        _countApple = _spawner.CountApple;
        _showText.text = "яблок осталось: " + _countApple;

        EventsManager.OnRemoveApple += OnCountChange;
    }

    private void OnDestroy()
    {
        EventsManager.OnRemoveApple -= OnCountChange;
    }

    private void OnCountChange()
    {
        _countApple--;
        _showText.text = "яблок осталось: " + _countApple;
    }
}
