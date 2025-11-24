using UnityEngine;

public class GameController : MonoBehaviour
{
    private static bool Lose = false;
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
