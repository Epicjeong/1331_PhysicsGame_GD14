using UnityEngine;

public class KillBox : MonoBehaviour
{
    [SerializeField] private PlayerSpawn _spawn;
    [SerializeField] private GameObject _ball;
    private Rigidbody _ballRB;

    private void Start()
    {
        _ballRB = _ball.GetComponent<Rigidbody>();
    }
    private void OnTriggerExit(Collider other)
    {
        _ballRB.linearVelocity = Vector3.zero;
        _ball.transform.position = _spawn.transform.position;
    }
}
