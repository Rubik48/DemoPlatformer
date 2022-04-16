using UnityEngine;
using TMPro;

public class AppleDisplay : MonoBehaviour
{
    [SerializeField] private SpawnerApple _spawner;
    [SerializeField] private TMP_Text _showText;

    public int CountApple { get; private set; }

    private void Start()
    {
        CountApple = _spawner.CountApple;
        _showText.text = "Соберите все яблоки!";

        EventsManager.OnRemoveApple += OnCountChange;
    }

    private void OnDestroy()
    {
        EventsManager.OnRemoveApple -= OnCountChange;
    }

    private void OnCountChange()
    {
        CountApple--;
        _showText.text = "Яблок осталось: " + CountApple;
    }
}
