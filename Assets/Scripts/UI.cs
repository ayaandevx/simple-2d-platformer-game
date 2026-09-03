using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public static UI instance;
    [SerializeField] private GameObject gameOverUI;   
    [Space]
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI killCountText;
    private int killCount;

    private void Awake()
    {
        instance = this;
        Time.timeScale = 1.0f;

    }
    private void Update()
    {
        timerText.text = Time.time.ToString("F2")+"s";
    }
    public void EnableGameOverUI()
    {
        Time.timeScale = .5f;
        gameOverUI.SetActive(true);

    }
    public void AddKillCount() {
        killCount++;
        killCountText.text = killCount.ToString();
    }

    public void restartLevel()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }

}
