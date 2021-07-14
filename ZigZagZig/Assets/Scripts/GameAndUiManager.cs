
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameAndUiManager : MonoBehaviour
{
    [SerializeField] private GameObject ui;
    [SerializeField] private Transform _playerTransform;

    [SerializeField]private Text scoreText;
    [SerializeField]private Text scoreText2;
    [HideInInspector] public int score=0;
    [HideInInspector] public int score2=0;

    public void RetryButton()
    {
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        scoreText.text = score.ToString();
        scoreText2.text = score2.ToString();
        
        if(_playerTransform.position.y < -0.5f)
        {
            ui.SetActive(true);
        }
    }
}