using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CalculateEredmeny : MonoBehaviour
{
    public Slider elso;
    public Slider masodik;
    public Slider harmadik;
    public TextMeshProUGUI eredmeny;
    public Button gomb;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = gomb.GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        double vegeredmeny = Math.Round(Math.PI * Math.Pow(elso.value, 2) * masodik.value * harmadik.value, 2);
        eredmeny.text = vegeredmeny.ToString();

    }
}
