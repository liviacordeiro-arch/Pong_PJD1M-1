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

    public void OnMove(InputValue value)
    {
        directionInput = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up);
    }//ee
}
