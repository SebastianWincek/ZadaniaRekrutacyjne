using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class _Gasnica : MonoBehaviour
{
    public GameObject piana;
    public float maxAmmo = 10;
    public float currentAmmo;
    public Text txt;
    private string informacja;


    void Start()
    {
        currentAmmo = maxAmmo;
        informacja = maxAmmo.ToString();
        txt.text = "Pozosta³y proszek:" + informacja;

    }
    void Update()
    {
    }


    public void OnPointerDown()
    {
        piana.SetActive(true);
        StartCoroutine(Ammoo());



    }

    public void OnPointerUp()
    {
        piana.SetActive(false);

    }


    private IEnumerator Ammoo()
    {
        while(piana.activeSelf)
        {
            if (currentAmmo != 0)
            {
                currentAmmo -= 1;
                yield return new WaitForSeconds(1);
                informacja = currentAmmo.ToString();
                txt.text = "Pozosta³y proszek:" + informacja;
            }
            else
            {
                currentAmmo = 0;
                piana.SetActive(false);
                informacja = currentAmmo.ToString();
                txt.text = "Pozosta³y proszek:" + informacja;
                yield return new WaitForSeconds(1);
            }
        }
    }

}






