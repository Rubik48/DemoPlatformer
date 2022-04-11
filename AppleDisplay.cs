using UnityEngine;
using TMPro;

public class AppleDisplay : MonoBehaviour
{
    [SerializeField] private ContainerForApple _container;
    [SerializeField] private TMP_Text _showText;

    private void Start()
    {
        _showText.text = _container.CountChild.ToString();
    }

    private void OnEnable()
    {
        _container.RemoveApple += OnCountChange;
    }

    private void OnDisable()
    {
        _container.RemoveApple -= OnCountChange;
    }

    private void OnCountChange(int countApple)
    {
        _showText.text = countApple.ToString();
    }
}
