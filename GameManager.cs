
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public RectTransform target;
    public float timeToTap = 2f;
    private float timer;
    private int score = 0;

    void Start()
    {
        MoveTarget();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            GameOver();
        }
    }

    public void OnTargetClicked()
    {
        score++;
        timeToTap = Mathf.Max(0.5f, timeToTap - 0.1f); // aumenta dificultad
        MoveTarget();
    }

    void MoveTarget()
    {
        float x = Random.Range(100f, Screen.width - 100f);
        float y = Random.Range(100f, Screen.height - 100f);
        target.anchoredPosition = new Vector2(x - Screen.width / 2, y - Screen.height / 2);
        timer = timeToTap;
    }

    void GameOver()
    {
        Debug.Log("Perdiste. Puntaje final: " + score);
    }
}
