using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeladeBusca : MonoBehaviour
{
    public InputField inputSenha;
    public GameObject TelaPerfil;
    public GameObject TelaBusca;
    // Start is called before the first frame update
    public void clicouBotao(){
        //pegar as informações do iput(inputSenha.text) e achar o respecivo perfil
        
        Debug.Log(inputSenha.text);
        TelaPerfil.SetActive(true);
        TelaBusca.SetActive(false);
    }

}
