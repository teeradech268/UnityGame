using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GamePlayUI GUI;

    // ใช้ใน PauseGame()
    bool isPause = false;

    public GameLevel CurrentLevel;
    public GameLevel NextLevel;



    public enum GameLevel
    {
        //unconment หากมีฉาก MainMenu
        MainMenu,
        MeandTeddy_S1,
        Past1,
        Past2
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //uncomment หาก PauseGame พร้อม
            PauseGame();
            
        }
    }


    //uncomment หาก PauseGame พร้อม
    public void PauseGame()
    {
        if (isPause) // ถ้าเกม Pause อยู่
        {
            Cursor.visible = false;
            isPause = false;
            Time.timeScale = 1;
            
            
            GUI.quit.gameObject.SetActive(false);
            
        }
        else if (!isPause) // ถ้าเกมไม่ได้ Pause
        {
            isPause = true;
            Time.timeScale = 0;
            
            
            GUI.quit.gameObject.SetActive(true);
            Cursor.visible = true;
        }
        
        //GPUI.PausePanel(isPause);
    }


    //โหลดฉากใหม่
    public void Retry()
    {
        SceneManager.LoadScene
            (CurrentLevel.ToString());
    }

    //โหลดฉากถัดไป
    public void LoadNextLevel()
    {
        SceneManager.LoadScene
            (NextLevel.ToString());
    }

    //unconment หากมีฉาก MainMenu
    public void BackToMenu()
    {
        SceneManager.LoadScene
            (GameLevel.MainMenu.ToString());
    }

    //ถ้าอยากเพิ่มอะไรหลังเก็บครบ
    public void Victory()
    {
        //if (!isWin)
        //{
        //    isWin = true;
        //    _soundManager.PlaySoundEffect(_soundManager.FXClips[1]);
        //    GPUI.TriggerVictoryPanel();
        //    HideCursor(true);
        //}
    }

    //uncomment หาก PauseGame พร้อม หรือไม่ได้ใช้
    //void HideCursor(bool isShow)
    //{
    //    Cursor.visible = isShow;
    //    if (isShow)
    //    { Cursor.lockState = CursorLockMode.None; }
    //    else { Cursor.lockState = CursorLockMode.Locked; }
    //}


    //public void PlayGame()
    //{
     //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}


    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
