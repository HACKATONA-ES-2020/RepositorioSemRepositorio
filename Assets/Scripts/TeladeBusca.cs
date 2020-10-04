using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeladeBusca : MonoBehaviour
{
    public InputField inputSenha;
    public InputField inputProntuario;
    public GameObject TelaPerfil;
    public GameObject TelaBusca;
    public GameObject TelaPaciente1;
    public GameObject TelaPaciente2;
    public GameObject scriptTelaInicial;

    private string numeroProntuario;
    private Text senha;
    private Paciente paciente1;
    private Paciente paciente2;

    public GameObject Paciente;

    public Paciente pacienteSelecionado;

    public int npaciente;
    
    void Start(){
        paciente1 = new Paciente("Joao da Silva","12/07/1973","Masculino","123","29/10/19","O+");
        paciente2 = new Paciente("Maria da Silva","22/09/1973","Feminino","111234","30/12/19","A+");
        //Debug.Log(paciente1.getNome());

        numeroProntuario = "";
        numeroProntuario = inputProntuario.text;
        npaciente = 0;
    }

    
    public void GravouSenha(){
        numeroProntuario = inputProntuario.text;
    }
    public void clicouBotao(){
        numeroProntuario = inputProntuario.text;
        Debug.Log("Numero       ");
        Debug.Log(numeroProntuario);
        if(numeroProntuario.Equals(paciente1.getCPF())){
            //pacienteSelecionado = paciente1;
            npaciente = 1;
            TelaPaciente1.SetActive(true);
        }
        if(numeroProntuario.Equals(paciente2.getCPF())){
            //pacienteSelecionado = paciente2;
            npaciente = 2;
            TelaPaciente2.SetActive(true);
        }
        Debug.Log("Anivia");
        TelaBusca.SetActive(false);
    }
}
