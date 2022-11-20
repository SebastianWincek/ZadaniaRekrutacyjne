using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Slider : MonoBehaviour
{
    public GameObject box;

    public void OnSliderChanged(float newValue)
    {
        Vector3 pos = box.transform.position;
        pos.y = newValue;
        box.transform.position = pos;
    }

}
