using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacaoGabinete : MonoBehaviour
{
    private Animator anim;
    public string nomeAnimacao;
    public bool verificarAnimacao,verificarAnimacao2, verificarAnimacao3, verificarAnimacao4, verificarAnimacao5, verificarAnimacao6, verificarAnimacao7, verificarAnimacao8;
    public GameObject placaMaeAnim;
    private Animation animat;

    public bool fimAnim;

  
    void Start()
    {
        anim = GetComponent<Animator>();
        animat = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
      if(nomeAnimacao == "PlacaMae" && verificarAnimacao == false)
        {
            anim.SetBool("PlacaMae", true);
            anim.SetBool("CPU", false);
          
            verificarAnimacao = true;
        }else

        if (nomeAnimacao == "CPU" && verificarAnimacao2 == false)
        {


            anim.SetBool("PlacaMae", false);
            anim.SetBool("CPU", true);



            verificarAnimacao2 = true;
        }else
        if (nomeAnimacao == "Fonte" && verificarAnimacao3 == false)
        {

            anim.SetBool("PlacaMae", false);
            anim.SetBool("CPU", false);
            anim.SetBool("Fonte", true);


            verificarAnimacao3 = true;
        }
        else
        if (nomeAnimacao == "Cooler" && verificarAnimacao4 == false)
        {

            anim.SetBool("PlacaMae", false);
            anim.SetBool("CPU", false);
            anim.SetBool("Fonte", false);
            anim.SetBool("Cooler", true);


            verificarAnimacao4 = true;
        }
        else
        if (nomeAnimacao == "MemoriaRAM" && verificarAnimacao5 == false)
        {

            anim.SetBool("PlacaMae", false);
            anim.SetBool("CPU", false);
            anim.SetBool("Fonte", false);
            anim.SetBool("Cooler", false);
            anim.SetBool("MemoriaRAM", true);


            verificarAnimacao5 = true;
        }else
        if (nomeAnimacao == "VGA" && verificarAnimacao6 == false)
        {

            anim.SetBool("PlacaMae", false);
            anim.SetBool("CPU", false);
            anim.SetBool("Fonte", false);
            anim.SetBool("Cooler", false);
            anim.SetBool("MemoriaRAM", false);
            anim.SetBool("VGA", true);


            verificarAnimacao6 = true;
        }
        else
        if (nomeAnimacao == "SSD" && verificarAnimacao7 == false)
        {

            anim.SetBool("PlacaMae", false);
            anim.SetBool("CPU", false);
            anim.SetBool("Fonte", false);
            anim.SetBool("Cooler", false);
            anim.SetBool("MemoriaRAM", false);
            anim.SetBool("VGA", false);
            anim.SetBool("SSD", true);


            verificarAnimacao7 = true;
        }
        else
        if (nomeAnimacao == "Tampa" && verificarAnimacao8 == false)
        {

            anim.SetBool("PlacaMae", false);
            anim.SetBool("CPU", false);
            anim.SetBool("Fonte", false);
            anim.SetBool("Cooler", false);
            anim.SetBool("MemoriaRAM", false);
            anim.SetBool("VGA", false);
            anim.SetBool("SSD", false);
            anim.SetBool("Tampa", true);


            verificarAnimacao8 = true;
        }
        if (fimAnim == true)
        {
            Debug.Log("remove");
            animat.Stop("CPU");
            animat.RemoveClip("CPU");
        }
    }


  public void fimAnimacaoPlacaMae()
    {
        anim.SetBool("PlacaMae", false);
    }


    public void fimAnimacaoCPU()
    {
        anim.SetBool("CPU", false);
    }

    public void fimAnimacaoFonte()
    {
        anim.SetBool("Fonte", false);
    }

    public void fimAnimacaoCooler()
    {
        anim.SetBool("Cooler", false);
    }
    public void fimAnimacaoMemoriaRAM()
    {
        anim.SetBool("MemoriaRAM", false);
    }
    public void fimAnimacaoVGA()
    {
        anim.SetBool("VGA", false);
    }

    public void fimAnimacaoSSD()
    {
        anim.SetBool("SSD", false);
    }

    public void fimAnimacaoTampa()
    {
        anim.SetBool("Tampa", false);
    }


}
