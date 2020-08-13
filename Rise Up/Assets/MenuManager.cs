using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject baloon;
    [SerializeField]
    private GameObject cylinder;
    [SerializeField]
    private GameObject gameStartPanel;
    
    void Start()
    {
        baloon.SetActive(false);
        cylinder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenuBtn()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayBtn()
    {
        baloon.SetActive(true);
        cylinder.SetActive(true);
        gameStartPanel.SetActive(false);
    }
}
