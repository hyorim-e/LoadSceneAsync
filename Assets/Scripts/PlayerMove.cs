using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 0.01f;
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        transform.position = new Vector2(transform.position.x + h * speed, 0);
    }
}
