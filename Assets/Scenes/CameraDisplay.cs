using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public RawImage displayImage;
    public Text cameraText;
    private WebCamTexture webCamTexture;
    
    public void StartCamera(string cameraName) {
         // カメラが見つかるかチェック
        bool cameraFound = false;
        foreach (var device in WebCamTexture.devices)
        {
            if (device.name == cameraName)
            {
                cameraFound = true;
                break;
            }
        }

        if (!cameraFound)
        {
            // カメラが見つからない場合の処理            
            return;
        }

        if (webCamTexture != null)
        {
            webCamTexture.Stop();
            Destroy(webCamTexture);
        }

        webCamTexture = new WebCamTexture(cameraName);
        displayImage.texture = webCamTexture;
        displayImage.material.mainTexture = webCamTexture;
        webCamTexture.Play();
        cameraText.text = cameraName;
    }
    
}
