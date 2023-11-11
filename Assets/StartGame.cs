using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] TextMeshProUGUI contador;

    public float time = 3;


    void Start()
    {
        StartCoroutine(Cuenta());
    }


    IEnumerator Cuenta()
    {
        while (time > 0)
        {
            contador.text = "El juego comienza en: " + time.ToString();
            time--;

            yield return new WaitForSeconds(1f);
        }
        
        panel.SetActive(false);
    }
}
