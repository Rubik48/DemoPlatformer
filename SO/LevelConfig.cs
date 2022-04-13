using UnityEngine;

[CreateAssetMenu(fileName = "LevelConfig", menuName = "Create Level Config")]
public class LevelConfig : ScriptableObject
{
    [SerializeField] private Suite _suite;

    public Player Player => _suite.Player;
}
