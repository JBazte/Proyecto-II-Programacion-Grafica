using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class UICounter : MonoBehaviour {

    [SerializeField] int valor;
    [SerializeField] UP_NoArgsUnityEvent siAlcanzaCifra;
    [SerializeField] UP_NoArgsUnityEvent siAlcanzaCifra1;
    [SerializeField] UP_NoArgsUnityEvent siAlcanzaCifra2;
    [SerializeField] UP_NoArgsUnityEvent siAlcanzaCifra3;

    public int Valor
    {
        get { return valor; }
    }

    public void UP_ModificarContador(int cantidad)
    {
        if (cantidad > 0){
            if(valor < 3){
                valor += cantidad;
                ComprobarAlerta();
            }
        } else {
            valor += cantidad;
            ComprobarAlerta();
        }
    }

    private void ComprobarAlerta()
    {
        if (this.valor == 3)
        {
            siAlcanzaCifra.Invoke();
        } else if (this.valor == 2){
            siAlcanzaCifra1.Invoke();
        } else if (this.valor == 1){
            siAlcanzaCifra2.Invoke();
        } else {
            siAlcanzaCifra3.Invoke();
        }
    }
}
