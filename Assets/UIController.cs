using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI endGameTitle;
    [SerializeField] TextMeshProUGUI currentNumber;
    [SerializeField] TextMeshProUGUI remainNumber;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject confirm;
    [SerializeField] Slider slider;

    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI highScore;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        confirm.SetActive(false);
    }

    public void UpdateCurrentNumber(int value)
    {
        currentNumber.text = value.ToString();
    }

    public void UpdateRemainNumber(int value)
    {
        remainNumber.text = value.ToString();
    }

    public void GameOver(bool isWin)
    {
        gameOver.SetActive(true);

        endGameTitle.text = "Game over!!!";
        if (isWin) endGameTitle.text = "You win!!!";
    }

    public void UpdateScore(int value)
    {
        score.text = value.ToString();
    }

    public void UpdateHighScore(int value)
    {
        highScore.text = value.ToString();
    }

    public void ShowConfirm(bool isShow)
    {
        if(isShow)
        {
            Time.timeScale = 0;
            confirm.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            confirm.SetActive(false);
        }
    }

    public void SetSlider(float value)
    {
        slider.maxValue = value;
        slider.value = value;
    }

    public void UpdateSliderValue(float value)
    {
        slider.value = value;
    }
}
