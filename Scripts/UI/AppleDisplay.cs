using UnityEngine;
using TMPro;

public class AppleDisplay : MonoBehaviour
{
    [SerializeField] private SpawnerApple _spawner;
    [SerializeField] private TMP_Text _showText;

    public int Count { get; private set; }

    private void Start()
    {
        Count = _spawner.CountApple;
        _showText.text = "Соберите все яблоки!";
    }

    private void OnEnable()
    {
        Apple.AppleRemoved += OnCountChange;
    }

    private void OnDisable()
    {
        Apple.AppleRemoved -= OnCountChange;
    }

    private void OnCountChange()
    {
        Count--;
        _showText.text = "Яблок осталось: " + Count;
    }
}
