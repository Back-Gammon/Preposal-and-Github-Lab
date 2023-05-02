using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameLevel : MonoBehaviour
{
    public int levelToLoad = 1;
   
   
   
    // Start is called before the first frame update
   
   
   
   
   
    public void LoadMyLevel()
    {
        SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
