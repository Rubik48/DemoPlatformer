using UnityEngine;
using UnityEngine.Events;

public class ContainerForApple : MonoBehaviour
{
    [SerializeField] private Apple _apple;

    public event UnityAction<int> RemoveApple;
    public int CountChild { get; private set; }

    private void Start()
    {
        CountChild = transform.childCount;
    }

    private void OnEnable()
    {
        _apple.DestroyApple += OnRemoveApple;
    }

    private void OnDisable()
    {
        _apple.DestroyApple -= OnRemoveApple;
    }

    private void OnRemoveApple()
    { 
        CountChild--;
        RemoveApple?.Invoke(CountChild);
    }
}
