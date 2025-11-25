using UnityEngine;

public class GameController : MonoBehaviour
{
    public static bool Lose = false;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Lose)
        {
            Time.timeScale = 0;
        }
    }
}
