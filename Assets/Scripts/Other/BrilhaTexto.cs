using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BrilhaTexto : MonoBehaviour {

    public GameObject Blink;
    void Start() {
        InvokeRepeating("blinkTheText", 0f, 0.5f);
    }

    void Update() {
       
    }

    void blinkTheText()
    {
        if (Blink.activeInHierarchy)
            {
                Blink.SetActive(false);
            }
            else
            {
                Blink.SetActive(true);

            }

    }


}