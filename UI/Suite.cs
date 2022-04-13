using UnityEngine;
using UnityEngine.UI;

public class Suite : MonoBehaviour
{
    [SerializeField] private Toggle _toggle1;
    [SerializeField] private Toggle _toggle2;
    [SerializeField] private Toggle _toggle3;
    [SerializeField] private Player _virtualGuy;
    [SerializeField] private Player _pinkMan;
    [SerializeField] private Player _maskDude;

    public Player Player { get; private set; }

    private void Awake()
    {
        _toggle1.onValueChanged.AddListener(OnSkinOneSelected);
        _toggle2.onValueChanged.AddListener(OnSkinTwoSelected);
        _toggle3.onValueChanged.AddListener(OnSkinThreeSelected);
    }

    private void OnSkinOneSelected(bool active)
    {
        _virtualGuy.gameObject.SetActive(active);
        Player = _virtualGuy;
    }
    private void OnSkinTwoSelected(bool active)
    {
        _pinkMan.gameObject.SetActive(active);
        Player = _pinkMan;
    }
    private void OnSkinThreeSelected(bool active)
    {
        _maskDude.gameObject.SetActive(active);
        Player = _maskDude;
    }
}
