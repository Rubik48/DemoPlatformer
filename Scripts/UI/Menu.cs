using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _panelSkinMenu;

    public void StartGame()
    {
        PreGame.Load();
    }

    public void OpenSkinMenu() 
    {
        _panelSkinMenu.SetActive(true);
    }

    public void CloseSkinMenu()
    {
        _panelSkinMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
