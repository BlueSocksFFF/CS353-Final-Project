using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorBar : MonoBehaviour
{
    public Image image;
    public void setColor(byte a, byte b, byte c)
    {
        image.color = new Color32(a, b, c, 250);
    }
}
