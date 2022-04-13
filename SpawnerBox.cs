using System.Collections;
using UnityEngine;

public class SpawnerBox : MonoBehaviour
{
    [SerializeField] private Box _templateBox;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private int _delay;

    private void Start()
    {
        StartCoroutine(SpawnBox());
    }

    private IEnumerator SpawnBox()
    {
        while (true)
        {
            Instantiate(_templateBox, _spawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(_delay);
        }
    }
}
