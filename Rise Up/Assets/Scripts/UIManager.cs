using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject optionPanel;
    [SerializeField]
    private GameObject exitBtn, startBtn, optionBtn;
    public void StartBtn()
    {
        SceneManager.LoadScene("Level01");
    }
    public void ExitBtn()
    {
        Application.Quit();
    }
    public void OptionBtn()
    {
        optionPanel.SetActive(true);
        exitBtn.SetActive(false);
        startBtn.SetActive(false);
        optionBtn.SetActive(false);
    }

    public void BackBtn()
    {
        optionPanel.SetActive(false);
        exitBtn.SetActive(true);
        startBtn.SetActive(true);
        optionBtn.SetActive(true);
    }

}
