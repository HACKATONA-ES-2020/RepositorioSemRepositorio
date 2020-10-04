using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaInicial : MonoBehaviour
{
    public GameObject telaBusca;
    public GameObject telaInicial;
    public GameObject pacientes;

    //pacientes
    public Paciente paciente1;

    public Paciente paciente2;


    //TXT
    public GameObject txtnome1;
    public GameObject txtnome2;

    //txtentrada1;
    public GameObject txtentrada1;

    public GameObject telaPacienteBasico;
    public GameObject telaPacienteBasico2;

    void Start(){
        paciente1 = new Paciente("Joao da Silva","12/07/1973","Masculino","123","29/10/19","O+");
        paciente2 = new Paciente("Maria da Silva","22/09/1973","Feminino","111234","30/12/19","A+");
        
        txtnome1.GetComponent<Text>().text = paciente1.getNome();
        txtnome2.GetComponent<Text>().text = paciente2.getNome();

        txtentrada1.GetComponent<Text>().text = paciente1.getEntrada();

    }
    

    public void ClicouBotaoAdicionar(){
        telaInicial.SetActive(false);
        telaBusca.SetActive(true);
    }
    public void ClicouBotaoAcompanhar(){
        telaInicial.SetActive(false);
        telaPacienteBasico.SetActive(true);
    }

    public void ClicouBotaoAcompanhar2(){
        telaInicial.SetActive(false);
        telaPacienteBasico2.SetActive(true);
    }
}
