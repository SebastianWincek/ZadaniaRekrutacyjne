using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Temperatura : MonoBehaviour
{
    [SerializeField] private float temperatura;
    public Text txt;
    public float obecnaTemperatura;


    void Start()
    {
        
    }


    void Update()
    {
        obecnaTemperatura = float.Parse(txt.text);

    }
    private void OnTriggerStay(Collider other)
    {
        StartCoroutine(Count());
      
    }
    IEnumerator Count()
    {
        if (obecnaTemperatura != temperatura && obecnaTemperatura > temperatura)  // 0>-100 1000 > -100    
        {
            obecnaTemperatura -= 2;                                                     
            obecnaTemperatura = Mathf.Clamp(obecnaTemperatura, temperatura, obecnaTemperatura);
            txt.text = obecnaTemperatura.ToString();
            yield return null;
        }
        else if(obecnaTemperatura != temperatura && obecnaTemperatura < temperatura)
        {
            obecnaTemperatura += 2;
            obecnaTemperatura = Mathf.Clamp(obecnaTemperatura, obecnaTemperatura, temperatura);
            txt.text = obecnaTemperatura.ToString();
            yield return null;
        }

    }



    
    }


