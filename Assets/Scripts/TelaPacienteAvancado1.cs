using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelaPacienteAvancado1 : MonoBehaviour
{
    public GameObject telaPacienteAvancado1;
    public GameObject telaExame;
    public GameObject telaPacienteBasico1;

    public void Voltar(){
        telaPacienteAvancado1.SetActive(false);
        telaPacienteBasico1.SetActive(true);
    }
    public void Exame(){
        telaExame.SetActive(true);
        telaPacienteAvancado1.SetActive(false);
    }
 
}
