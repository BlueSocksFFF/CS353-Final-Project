using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorBar : MonoBehaviour
{
    public Image image;
    public void setColor(int a, int b, int c)
    {
        image.color = new Color32((byte)a, (byte)b, (byte)c, 250);
    }
}
