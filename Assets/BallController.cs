using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public int Score;
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private GameObject ScoreText;
    // Use this for initialization
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.ScoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
        this.ScoreText.GetComponent<Text>().text = Score.ToString();
    }
    public void AddPoint(int Point)
    {
        Score += Point;
    }
}