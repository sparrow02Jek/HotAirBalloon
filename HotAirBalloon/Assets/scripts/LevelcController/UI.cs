using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public bool isFps = false ;
    public GameObject mainCam;
    public GameObject cam;
    public GameObject Fps;
    public GameObject ExitTable;
    public void Play(){
        SceneManager.LoadScene(1);
        Debug.Log("aws");
    }
    public void Exit(){
        ExitTable.SetActive(true);
    }
    public void ExitT(){
        Application.Quit();
        Debug.Log("Exit");
    }
    public void ExitCancel(){
        ExitTable.SetActive(false);
    }
    public void FpsOn()
    {
        isFps = true;
        Fps.SetActive(true);
        

    }
    public void options(){
        mainCam.SetActive(false);
        cam.SetActive(true);


    }
    
}