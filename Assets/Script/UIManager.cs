using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject mainMenu;
    public GameObject settingsPanel;
    public GameObject creditsPanel;
    public GameObject pauseMenu;

    [Header("Jugadores")]
    public MovementWASD player1;
    public MovementArrows player2;

    [Header("Sliders y textos")]
    public Slider sliderP1;
    public TMP_Text textP1;
    public Slider sliderP2;
    public TMP_Text textP2;

    private bool isPaused = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainMenu.SetActive(true);
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
        pauseMenu.SetActive(false);

        sliderP1.value = player1.Speed;
        sliderP2.value = player2.Speed;
        textP1.text = player1.Speed.ToString("F1");
        textP2.text = player2.Speed.ToString("F1");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
}
    // -- MENU PRINCIPAL --
    public void PlayGame()
    {
        mainMenu.SetActive(false);
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);
    }

    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);

        if (isPaused)
            pauseMenu.SetActive(true);
        else
            mainMenu.SetActive(true);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    // ---------- PAUSA ----------
    public void TogglePause()
    {
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f;
    }

    public void ContinueGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    // ---------- SLIDERS ----------
    public void OnSliderP1Changed(float value)
    {
        player1.SetSpeed(value);
        textP1.text = value.ToString("F1");
    }

    public void OnSliderP2Changed(float value)
    {
        player2.SetSpeed(value);
        textP2.text = value.ToString("F1");
    }
}
