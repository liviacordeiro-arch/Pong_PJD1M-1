using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (CompareTag("AIWall"))
            {
               gameManager.PlayerAddPoint();
            }
      
            if (CompareTag("PlayerWall"))
            {

            }
        }
    }
}
