using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _panelSkinMenu;
    [SerializeField] private LevelConfig _levelConfig;

    public void StartGame()
    {
        Level1.Load(_levelConfig);
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
