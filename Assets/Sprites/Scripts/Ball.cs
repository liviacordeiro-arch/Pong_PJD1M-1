using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Jobs;


public class Ball : MonoBehaviour
{
    public float rotationBallSpeed = 5;

    private Rigidbody2D rb;

    [SerializeField] private float ballSpeed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        Launch();
    }

    private void Update()
    {
        transform.Rotate(0,0, rotationBallSpeed * Time.deltaTime);
    }
    private void Launch()
    {
     

        Vector2 direction = Vector2.zero;

        if (Random.value <= 0.5f)
        {
            direction += Vector2.left;
        }
        else
        {
            direction += Vector2.right;
        }

        if (Random.value <= 0.5f)
        {
            direction += Vector2.up;
        }
        else
        {
            direction += Vector2.down;
        }

        rb.linearVelocity = direction * ballSpeed;
    }

}


