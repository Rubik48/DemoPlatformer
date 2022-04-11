using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Apple _templateApple;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _container;

    private void Awake()
    {
        SpawnApple();
    }

    private void SpawnApple()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_templateApple, _spawnPoints[i].position, Quaternion.identity, _container.transform);
        }
    }
}