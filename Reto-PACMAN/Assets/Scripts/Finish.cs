using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour

{
    [SerializeField] private int cantidadPuntos;
    [SerializeField] private int puntosEliminados;
    private Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
        cantidadPuntos = GameObject.FindGameObjectsWithTag("Puntos").Length;
    }

    private void ActivarScore()
    //private void ActivarFinish()
    {
        animator.SetTrigger("Activar");
    }

    public void PuntosEliminado()
    
    {
        puntosEliminados += 1;

        if (puntosEliminados == cantidadPuntos);
        {
           // ActivarFinish();
        }
    } 
    
}
