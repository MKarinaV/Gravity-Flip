using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float topY = 3f;    
    public float bottomY = -3f; 
    private bool isTop = false; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Flip();
        }
    }

    void Flip()
    {
        if (isTop)
        {
            transform.position = new Vector2(transform.position.x, bottomY);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, topY);
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        isTop = !isTop;
    }
}