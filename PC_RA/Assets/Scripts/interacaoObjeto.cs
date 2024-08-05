using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacaoObjeto : MonoBehaviour
{
    private bool isVerificarToque;
  
    public string nomeAnimacao;
    private animacaoGabinete _animacaoGabinete;
    
    // Start is called before the first frame update
    void Start()
    {
        
        _animacaoGabinete = FindObjectOfType(typeof(animacaoGabinete)) as animacaoGabinete;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {
                _animacaoGabinete.nomeAnimacao = nomeAnimacao;
               // anim.enabled = true;
               //  anim.SetTrigger("PlacaMae");
                Debug.Log(this.gameObject.name);
            }
        }
    }

    private void OnMouseDown()
    {
        isVerificarToque = true;
    }

    private void OnMouseExit()
    {
        isVerificarToque = false;
    }
}
