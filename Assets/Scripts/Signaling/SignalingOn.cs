using UnityEngine;

public class SignalingOn : MonoBehaviour
{
    [SerializeField] private Signaling _signaling;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _signaling.TurnOn();
    }
}
