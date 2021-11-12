using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject cube;public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(onButtonPressed);
        Vb.RegisterOnButtonReleased(onButtonReleased);
        cube.SetActive(false);
    }

    public void onButtonPressed(VirtualButtonBehaviour vb){
        cube.SetActive(true);
    }
    public void onButtonReleased(VirtualButtonBehaviour vb){
        cube.SetActive(false);
    }
}
