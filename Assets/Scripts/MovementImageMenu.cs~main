using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementImageMenu : MonoBehaviour
{

    public Texture2D[] frames;
    public int fps = 10;

    void Update()
    {
        if (frames.Length > 0) { 
        int index = (int)(Time.time * fps) % frames.Length;
        GetComponent<RawImage>().texture = frames[index];
        }
    }
}
