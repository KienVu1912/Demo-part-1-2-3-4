using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    public GameObject bgMusic;
    public GameObject gameWinUI;
    void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
        playerHealth.onDead += OnGameOver;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
{
OnGameWin();
}
    }
    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }
    private void OnGameWin()
{
gameWinUI.SetActive(true);
bgMusic.SetActive(false);
playerHealth.gameObject.SetActive(false);
}
public void ReturnToMainMenu() => SceneManager.LoadScene("MainMenu");
}
