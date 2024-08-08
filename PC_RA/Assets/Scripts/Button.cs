using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void iniciarJogo()
    {
        SceneManager.LoadScene("Cena PC _programacao");
    }

    public void sairJogo()
    {
       Application.Quit();
    }


}
