using UnityEngine;
using UnityEngine.UI;

public class SkinSelected : MonoBehaviour
{
    [SerializeField] private Toggle _toggle1;
    [SerializeField] private Toggle _toggle2;
    [SerializeField] private Toggle _toggle3;
    [SerializeField] private GameObject _virtualGuy;
    [SerializeField] private GameObject _pinkMan;
    [SerializeField] private GameObject _maskDude;
    

    private void Awake()
    {
        _toggle1.onValueChanged.AddListener(OnSkinOneSelected);
        _toggle2.onValueChanged.AddListener(OnSkinTwoSelected);
        _toggle3.onValueChanged.AddListener(OnSkinThreeSelected);
    }

    private void OnSkinOneSelected(bool active)
    {
        _virtualGuy.gameObject.SetActive(active);
        PlayerPrefs.SetInt("Skin", 1);
    }
    private void OnSkinTwoSelected(bool active)
    {
        _pinkMan.gameObject.SetActive(active);
        PlayerPrefs.SetInt("Skin", 2);
    }
    private void OnSkinThreeSelected(bool active)
    {
        _maskDude.gameObject.SetActive(active);
        PlayerPrefs.SetInt("Skin", 3);
    }
}
