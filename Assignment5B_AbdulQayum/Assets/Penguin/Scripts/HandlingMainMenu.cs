using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlingMainMenu : MonoBehaviour
{
    public GameObject mainmenupanel;
    public GameObject mainpanel;
    public GameObject mlagentpanel;
    public GameObject computationalpanel;
    public GameObject matchingparenpanel;
    public GameObject pallanguagepanel;
    public GameObject parenthesislanguagepanel;
    public GameObject coursepanel;
    public string url;


    // Start is called before the first frame update
    void Start()
    {
        mainmenupanel.SetActive(true);
    }
    public void mainmenubutton()
    {
        mainmenupanel.SetActive(false);
        mainpanel.SetActive(true);
    }
    public void coursebutton()
    {
        mainmenupanel.SetActive(false);
        coursepanel.SetActive(true);
    }
    public void mlagentbutton()
    {
        mainpanel.SetActive(false);
        mlagentpanel.SetActive(true);
    }
    public void computationalbutton()
    {
        mainmenupanel.SetActive(false);
        computationalpanel.SetActive(true);
    }
    public void matchingparenthesisbutton()
    {
        mainmenupanel.SetActive(false);
        matchingparenpanel.SetActive(true);
    }
  
    public void Penguingame()
    {
        SceneManager.LoadScene("Penguins");
    }
    public void Battlewithmlagent()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
    public void rollballgame()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void terrainballgame()
    {
        SceneManager.LoadScene("Second Ball Terrain");
    }
    public void gobacktomainpanel()
    {
        mlagentpanel.SetActive(false);
        mainpanel.SetActive(true);
    }
    public void languagechosenbutton()
    {
        pallanguagepanel.SetActive(true);
        computationalpanel.SetActive(false);
    }
    public void gobacktocomputationalpanel()
    {
        computationalpanel.SetActive(true);
        pallanguagepanel.SetActive(false);
    }
    public void gobackfromcompute()
    {
        computationalpanel.SetActive(false);
        mainpanel.SetActive(true);
    }
    public void gobackfromparenthesis()
    {
        matchingparenpanel.SetActive(false);
        mainpanel.SetActive(true);
    }
    public void languagechosenbuttonforparenthesis()
    {
        parenthesislanguagepanel.SetActive(true);
        matchingparenpanel.SetActive(false);
    }
    public void gobacktoparenthesispanel()
    {
        matchingparenpanel.SetActive(true);
        parenthesislanguagepanel.SetActive(false);
    }
    public void gobacktmainmenupanel()
    {
        mainmenupanel.SetActive(true);
        mainpanel.SetActive(false);
    }
    public void gobackfromcourse()
    {
        mainmenupanel.SetActive(true);
        coursepanel.SetActive(false);
    }
    public void Open()
    {
        Application.OpenURL(url);
    }
    public void Quit()
    {
        Debug.Log("game quit");
        Application.Quit();
        Application.OpenURL("about:blank");
    }

}
