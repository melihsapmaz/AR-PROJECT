using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSelect : MonoBehaviour
{
    public void namesButton(){
        SceneManager.LoadScene("names");
    }
    public void historiesButton(){
        SceneManager.LoadScene("histories");
    }
    public void locationsButton(){
        SceneManager.LoadScene("locations");
    }
}
