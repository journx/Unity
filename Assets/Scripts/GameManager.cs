using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float timer;
    public float gameTimeLimit = 30f;
    public float timeLeft;
    public TextMeshProUGUI myText;
    public GameObject myPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        timeLeft = gameTimeLimit - timer;

        if (timeLeft <= 0)
        {
            //end the game
            Destroy(myPlayer);
            Debug.Log("GAME OVER!");
        }
        myText.text = timeLeft.ToString();
    }
    void FixedUpdate()
    {
    float delta = Time.fixedDeltaTime;
    }
       
}

