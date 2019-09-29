using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
	[SerializeField] int currentScore = 0;
    [SerializeField] int pointsPerBlockDestroyed = 99;
    [SerializeField] TextMeshProUGUI scoreDisplay;
    [SerializeField] bool autoPlay = false;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void addToScore()
	{
		currentScore += pointsPerBlockDestroyed;
        scoreDisplay.text = currentScore.ToString();
	}

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool getAutoPlay()
    {
        return autoPlay;
    }
}
