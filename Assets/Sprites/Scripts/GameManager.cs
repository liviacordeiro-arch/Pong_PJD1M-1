using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour

{
    [SerializeField] private int playerScore;
    [SerializeField] private int aiScore;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI aiScoreText;

    public void PlayerAddPoint()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
    }
}