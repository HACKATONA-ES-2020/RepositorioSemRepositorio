using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

public class TelaPacienteBasico : MonoBehaviour
{
    private static Semaphore _pool;
    public GameObject scriptTelaInicial;
    public GameObject scriptTelaBusca;
    public GameObject telaPacienteBasico;
    public GameObject telaPacienteAvancada;

    public GameObject txtnome;

    public GameObject Deus;
    //pacientes
    private Paciente paciente; 

    public static int valor;

    void Update(){
        valor = scriptTelaBusca.GetComponent<TeladeBusca>().npaciente;
        //paciente = scriptTelaBusca.GetComponent<TeladeBusca>().pacienteSelecionado;
        //txtnome1.GetComponent<Text>().text = paciente1.getNome();
        Debug.Log(valor);
    }

    public void CliclouBotaoMaisDados(){
        telaPacienteBasico.SetActive(false);
        telaPacienteAvancada.SetActive(true);
    }
}
