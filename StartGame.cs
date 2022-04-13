using UnityEngine;
using IJunior.TypedScenes;

public class StartGame : MonoBehaviour, ISceneLoadHandler<LevelConfig>
{
    [SerializeField] private Transform _startPosition;

    public void OnSceneLoaded(LevelConfig argument)
    {
        Instantiate(argument.Player, _startPosition.position, Quaternion.identity);
    }
}