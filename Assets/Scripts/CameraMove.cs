using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, 0f, -10f);
    }
}
