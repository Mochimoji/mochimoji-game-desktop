using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TESTTriggerScript : MonoBehaviour {

    private CamModalPanel modalPanel;
    private WebCamTexture webcamTex;
    private string webcamName = "";
    public GameObject modalPanelObject;
    public WebcamSource cam;

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
            GameObject.FindWithTag("WebCam").SetActive(true);

            webcamTex = new WebCamTexture(webcamName);
            // cam.OnApplyTexture(webcamTex);

            RawImage rawimage = GetComponent<RawImage>();
            
            rawimage.texture = webcamTex;

            Debug.Log("*************** reached collision CamModalPanel");
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


    // public void OnApplyTexture(Texture tex)
    // {
    //     RawImage rawimage = GetComponent<RawImage>();
    //     if (rawimage)
    //     {
    //         rawimage.texture = tex;
    //         //rawimage.material.mainTexture = tex;
    //     }
    // }

    // public void OnSetAspectRatio(int width, int height)
    // {
    //     AspectRatioFitter ratioFitter = GetComponent<AspectRatioFitter>();
    //     if (ratioFitter)
    //     {
    //         ratioFitter.aspectRatio = (float)width / (float)height;
    //     }
    // }
}
