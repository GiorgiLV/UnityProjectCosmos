using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static bool Lose;
    [SerializeField] private TextMeshProUGUI loseText;
    [SerializeField] private Button restartButton;
    private int timer;
    void Start()
    {
        Lose = false;
        loseText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        timer = 0;
    }
    
    void Update()
    {
        if (Lose)
        {
            loseText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            loseText.text = $"You Lose! Time: {timer/100} s";
        }
        else
        {
            timer++;
        }
    }
}
