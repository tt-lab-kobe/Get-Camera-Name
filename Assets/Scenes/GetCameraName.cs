using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCameraName : MonoBehaviour
{
    // Start is called before the first frame update
    public Text cameraListText;
    void Start()
    
    {
        UpdateCameraList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCameraList()
    {
        string cameraNames = "カメラリスト:\n";
        foreach (var device in WebCamTexture.devices)
        {
            cameraNames += device.name + "\n";
        }

        cameraListText.text = cameraNames;
    }
}
