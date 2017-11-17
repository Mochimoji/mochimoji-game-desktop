using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class TESTTriggerScript : MonoBehaviour {

    private CamModalPanel modalPanel;
    private WebCamTexture webcamTex;
    private string webcamName;
    public GameObject modalPanelObject;
    public WebcamSource cam;
    // public GameObject webcam;

    void Awake()
    {
        modalPanel = CamModalPanel.Instance();
        cam.Awake();
    }
    // If Player collides with PowerUp, then text will be triggered.
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            modalPanelObject.SetActive(true);
            cam.Awake();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // If Player presses "x", it will load the Game Over scene.
            if (Input.GetKeyDown(KeyCode.X))
            {
                // Bring up webcam here.
            }
        }
    }
    // If Player moves away from Object, then text will disappear.
    void OnTriggerExit2D(Collider2D collision)
    {
        modalPanelObject.SetActive(false);
    }

}
