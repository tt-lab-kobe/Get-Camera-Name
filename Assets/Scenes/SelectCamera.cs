using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCamera : MonoBehaviour
{
    public int camNo;
    public Text camText;
    public CameraDisplay CameraDisplay;
    
    private void Start() {
        camNo = 0;
    }
    public void SelectNextCamera() {
        if (WebCamTexture.devices.Length > 0) {
            int camNum = WebCamTexture.devices.Length;
            camNo = (camNo + 1) % camNum;
            string cameraName = WebCamTexture.devices[camNo].name;
            CameraDisplay.StartCamera(cameraName);
            camText.text = cameraName;
        }
        
    }
}
