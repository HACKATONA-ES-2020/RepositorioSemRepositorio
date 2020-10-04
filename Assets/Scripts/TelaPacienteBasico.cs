using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

public class TelaPacienteBasico : MonoBehaviour
{
    public GameObject scriptTelaInicial;
    public GameObject scriptTelaBusca;
    public GameObject telaPacienteBasico;
    public GameObject telaPacienteAvancado;
    public GameObject telaInicial;
    //pacientes
    private Paciente paciente1; 

     public GameObject txtnome;
      public GameObject txtdtnasc;
      public GameObject txtgenero;
      public GameObject txtcpf;
      public GameObject txtentrada;

    void Start(){
        paciente1 = new Paciente("Joao da Silva","12/07/1973","Masculino","123","29/10/19","O+");

        txtnome.GetComponent<Text>().text = paciente1.getNome();
        txtdtnasc.GetComponent<Text>().text = paciente1.getDataDeNascimento();
        txtgenero.GetComponent<Text>().text = paciente1.getGenero();
        txtcpf.GetComponent<Text>().text = paciente1.getCPF();
        txtentrada.GetComponent<Text>().text = paciente1.getEntrada();
    }

    public void CliclouBotaoMaisDados(){
        telaPacienteBasico.SetActive(false);
        telaInicial.SetActive(true);
    }
    public void ClicloHistorico(){
        telaPacienteBasico.SetActive(false);
        telaPacienteAvancado.SetActive(true);
    }
}
