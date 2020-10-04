using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TelaPacienteBasico2 : MonoBehaviour
{
    public GameObject scriptTelaInicial;
    public GameObject scriptTelaBusca;
    public GameObject telaPacienteBasico;
    public GameObject telaPacienteAvancado2;
    public GameObject telaInicial;
    //pacientes
    private Paciente paciente; 

     public GameObject txtnome;
      public GameObject txtdtnasc;
      public GameObject txtgenero;
      public GameObject txtcpf;
      public GameObject txtentrada;

    void Start(){
        paciente = new Paciente("Maria da Silva","22/09/1973","Feminino","111234","30/12/19","A+");

        txtnome.GetComponent<Text>().text = paciente.getNome();
        txtdtnasc.GetComponent<Text>().text = paciente.getDataDeNascimento();
        txtgenero.GetComponent<Text>().text = paciente.getGenero();
        txtcpf.GetComponent<Text>().text = paciente.getCPF();
        txtentrada.GetComponent<Text>().text = paciente.getEntrada();
    }

    public void CliclouBotaoMaisDados(){
        telaPacienteBasico.SetActive(false);
        telaInicial.SetActive(true);
    }

    public void ClicloHistorico(){
        telaPacienteBasico.SetActive(false);
        telaPacienteAvancado2.SetActive(true);
    }
}
