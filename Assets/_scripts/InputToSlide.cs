using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputToSlide : MonoBehaviour
{
    public Slider slider;
    public TMP_InputField sliderText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xd = float.Parse(sliderText.text);
        slider.value = xd;
    }
}
