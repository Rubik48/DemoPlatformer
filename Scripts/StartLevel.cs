using UnityEngine;

public class StartLevel : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Player _virtualGuy;
    [SerializeField] private Player _pinkMan;
    [SerializeField] private Player _maskDude;

    private Player _player;
    
    private void Awake()
    {
        CreatePlayer();

        PlayerDeath.PlayerDied += RespawnPlayer;
    }

    private void OnDisable()
    {
        PlayerDeath.PlayerDied -= RespawnPlayer;
    }

    private void RespawnPlayer()
    {
        _player.transform.position = _startPoint.position;
    }

    private void CreatePlayer()
    {
        switch (PlayerPrefs.GetInt(SkinSelected.Skin))
        {
            case 1:
                _player = Instantiate(_virtualGuy, _startPoint.position, Quaternion.identity);
                break;
            case 2:
                _player = Instantiate(_pinkMan, _startPoint.position, Quaternion.identity);
                break;
            case 3:
                _player = Instantiate(_maskDude, _startPoint.position, Quaternion.identity);
                break;
            default:
                Debug.LogError("¬ыбранного персанажа не существует!");
                break;
        }
    }


}
