using System;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public static Action OnRemoveApple;

    public static void SendOnRemoveApple()
    {
        OnRemoveApple?.Invoke();
    }
}
