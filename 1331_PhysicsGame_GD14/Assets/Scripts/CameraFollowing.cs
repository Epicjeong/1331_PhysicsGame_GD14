using UnityEngine;

public class CameraFollowing : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(45, 0, 0);
    }
}
