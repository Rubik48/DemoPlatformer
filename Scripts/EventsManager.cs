using System;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public static Action OnRemoveApple;
    public static Action OnDeadPlayer;
    public static void SendOnRemoveApple()
    {
        OnRemoveApple?.Invoke();
    }

    public static void SendOnDeadPlayer()
    {
        OnDeadPlayer?.Invoke();
    }
}
