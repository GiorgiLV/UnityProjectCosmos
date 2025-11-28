using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static bool Lose, Win;
    [SerializeField] private TextMeshProUGUI loseText, distant;
    [SerializeField] private Button restartButton;
    private int timer, distance;
    [NonSerialized] public static GameObject Player, Station;
    void Start()
    {
        Lose = false;
        Win = false;
        loseText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        timer = 0;
    }
    
    void Update()
    {
        distance = Convert.ToInt32(Vector2.Distance(Player.transform.position, Station.transform.position));
        distant.text = $"До станции: {distance}м";
        if (Lose)
        {
            loseText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            loseText.text = $"You Lose! Time: {timer/100} s";
        }
        else if (Win)
        {
            loseText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            loseText.text = $"You Win! Time: {timer/100} s";
        }
        else
        {
            timer++;
        }
    }
}
