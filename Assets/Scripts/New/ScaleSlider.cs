using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScaleSlider : MonoBehaviour
{
    public Slider ScaleSliderX;
    public float scaleSliderNumber;





    void Update()
    {
        scaleSliderNumber = ScaleSliderX.value;
        Vector3 scale = new Vector3(scaleSliderNumber, scaleSliderNumber, scaleSliderNumber);
        this.transform.localScale = scale;
    }
}
