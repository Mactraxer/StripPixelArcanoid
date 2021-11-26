using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyStringEvent : UnityEvent<Sprite>
{
}

public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;
    public MyStringEvent Response;

    private void OnEnable() { Event.RegisterListener(this); }

    private void OnDisable() { Event.UnregisterListener(this); }

    public void OnEventRaised(Sprite sprite) { Response.Invoke(sprite); }
}
