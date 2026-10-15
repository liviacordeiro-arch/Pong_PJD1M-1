using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddles : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 directionInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void OnMove(InputValue value)
    {
        directionInput = value.Get<Vector2>();

        if (directionInput.y == -1)
        {
            directionInput = new Vector2(0, -1);
        }
        else if (directionInput.y == 1)
        {
            directionInput = new Vector2(0, 1);
        }
        else 
        {
            directionInput = new Vector2(0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * directionInput * speed * Time.deltaTime);
    }
  
}
