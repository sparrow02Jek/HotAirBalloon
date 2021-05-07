using UnityEngine;
using UnityEngine.Events;


public class Player1 : MonoBehaviour
{
    [SerializeField] private GameObject sound;//for sound if player touch ball
    [SerializeField] private GameObject restart;// button to restart Scene

    private Score _target;
    private int _currentScore;

    public event UnityAction<int> ScoreEvent;
    private void Start()
    {
        Time.timeScale = 1f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var score = collision.gameObject.GetComponent<Score>();
        
        switch(collision.collider.tag)// возьмёт значения case-а!
        {
            case("Score"):
                if (score)
                {
                    ScoreEvent?.Invoke(score.Prise + _currentScore);
                    _currentScore++;
                }
                break;
            case("CoinCloud"):
                    _currentScore++;
                    break;
                
            case ("Enemy"):
                //Debug.Log("add");
                //Destroy(gameObject);
                restart.SetActive(true);
                //Time.timeScale = 0;
                break;
        }
    }
}

