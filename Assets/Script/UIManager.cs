using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI scoreText;
    public int score;
    public void TurnOnUI()
    {
        panel.SetActive(true);
    }
    public void HideUI()
    {
        panel.SetActive(false);
    }
    public void Defeat()
    {
        scoreText.text = score.ToString();
        TurnOnUI();
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
