using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class _OgienZycie : MonoBehaviour

{
    public ParticleSystem ogienParticleSystem;
    public Slider slider;
    public GameObject gasnica;
    public float zycie = 200;
    private float obecneZycie;

    // Start is called before the first frame update
    void Start()
    {
        obecneZycie = zycie;

    }

    // Update is called once per frame
    void Update()
    {
        zmianaOgnia();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.layer == 6)
        { 
            Damage();
            
        }
    }

    void Damage()
    {
        obecneZycie = obecneZycie-(2- slider.value);
        Debug.Log(obecneZycie);
    }
    void zmianaOgnia()
    {
        var main = ogienParticleSystem.main;
        if (obecneZycie < 200 && obecneZycie > 150)
        {
            main.startLifetime = 4;
        }
        else if (obecneZycie < 150 && obecneZycie > 100)
        {
            main.startLifetime = 3;
        }
        else if (obecneZycie < 100 && obecneZycie >= 50)
        {
            main.startLifetime = 2;
        }
        else if (obecneZycie < 50 && obecneZycie > 0)
        {
            main.startLifetime = 1;
        }
        else if (obecneZycie == 0)
        {
            obecneZycie = 0;
            main.startLifetime = 0;
        }
    }
    public void OnPointerUp()
    {
        StartCoroutine(HPregen());

    }
    public IEnumerator HPregen()
    {
        {
            while(gasnica.activeInHierarchy ==false)
            {
                if (obecneZycie <= 200 && obecneZycie >= 0)
                {
                    yield return new WaitForSeconds(0.5f);
                    obecneZycie = obecneZycie + 2;
                    Debug.Log(obecneZycie);
                }
                else if (obecneZycie > 200 || obecneZycie < 0)
                {
                    obecneZycie = 200;
                }
            }
        }
    }


}



