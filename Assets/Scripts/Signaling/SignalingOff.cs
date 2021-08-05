using UnityEngine;

public class SignalingOff : MonoBehaviour
{
    [SerializeField] private Signaling _signaling;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _signaling.TurnOff();
    }
}
