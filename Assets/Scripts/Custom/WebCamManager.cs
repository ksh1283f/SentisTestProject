using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class WebCamManager : MonoBehaviour
{
    WebCamTexture webCamTexture;
    
    void Start()
    {
        WebCamDevice myDevice = new WebCamDevice();
        WebCamDevice[] devices = WebCamTexture.devices;
        Debug.Log(devices.Length);
        for (int i = 0; i < devices.Length; i++)
        {
            Debug.Log(devices[i].name);
            myDevice = devices[0];
        }
        webCamTexture = new WebCamTexture(myDevice.name);
        Renderer renderer = GetComponent<Renderer>();

        renderer.material.mainTexture = webCamTexture;
        webCamTexture.Play();
            
    }

}
