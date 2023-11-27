using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SliderController : MonoBehaviour
{

    public Slider sl;
    public TextMeshProUGUI slidertxt;     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slidertxt.text = sl.value.ToString("0.00"); 
    }
}
