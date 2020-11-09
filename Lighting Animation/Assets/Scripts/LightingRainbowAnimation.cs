using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingRainbowAnimation : MonoBehaviour
{
    Light mainLight;

    byte red = 0;
    byte green = 0;
    byte blue = 0;
    byte alpha = 255;

    private void Awake()
    {
        mainLight = GetComponent<Light>();
        red = 255;
        mainLight.color = new Color32 (red, green, blue, alpha);
        Debug.Log("Set main light color's R value to 255.");
    }

    // Update is called once per frame
    void Update()
    {
        if (red == 0 && green == 0 && blue == 0)
            red = 255;
        else if (red == 0 && green < 255 && blue == 255)
            green++;
        else if (red == 0 && green == 255 && blue > 0)
            blue--;
        else if (red == 255 && green == 0 && blue < 255)
            blue++;
        else if (red > 0 && green == 0 && blue == 255)
            red--;
        else if (red < 255 && blue == 0 && green == 255)
            red++;
        else if (red == 255 && green > 0 && blue == 0)
            green--;

        mainLight.color = new Color32(red, green, blue, alpha);
    }
}
