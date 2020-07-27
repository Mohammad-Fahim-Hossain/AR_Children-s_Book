using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecneManager : MonoBehaviour
{
    public void QuitApp() {

        Application.Quit();

    }
    public void BanglaAlpha() {
        SceneManager.LoadScene("BanglaAlpha");
    }
    public void BanglaFruit()
    {
        SceneManager.LoadScene("BanglaFruit");
    }
    public void BanglaVideo()
    {
        SceneManager.LoadScene("BanglaVideo");
    }


    public void EnglishAlpha()
    {
        SceneManager.LoadScene("EnglishAlpha");
    }
    public void EnglishFruit()
    {
        SceneManager.LoadScene("EnglishFruit");
    }
    public void EnglishVideo()
    {
        SceneManager.LoadScene("EnglishVideo");
    }
    public void Mainmanu()
    {
        SceneManager.LoadScene("UI");

    }



}
