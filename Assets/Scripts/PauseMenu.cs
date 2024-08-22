using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject puzzlePanel;
    [SerializeField] private Button swordButton;
    [SerializeField] private Button bowButton;
    [SerializeField] private Button potionButton;
    [SerializeField] private GameObject audioController;


    private void Start()
    {
        pauseMenu.SetActive(false);        
    }

    public void PauseButtonPressed()
    {
        puzzlePanel.SetActive(false);
        audioController.GetComponent<AudioController>().PickUpPlay();
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        swordButton.interactable = false;
        bowButton.interactable = false;
        potionButton.interactable = false;       
    }

    public void BackToGaMeButtonPressed()
    {
        puzzlePanel.SetActive(true);
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        swordButton.interactable = true;
        bowButton.interactable = true;
        potionButton.interactable = true;
        audioController.GetComponent<AudioController>().PickUpPlay();
    }

    public void GoToMainMenuPressed()
    {
        puzzlePanel.SetActive(true);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        audioController.GetComponent<AudioController>().PickUpPlay();
    }

    public void RestartLevelButtonPressed()
    {
        puzzlePanel.SetActive(true);
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        audioController.GetComponent<AudioController>().PickUpPlay();
    }
}
