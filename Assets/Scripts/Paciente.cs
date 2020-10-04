using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paciente : MonoBehaviour
{
            private string nome;
            private string data_de_nascimento;
            private string genero;
            private string cpf;
            private string entrada;
            private string tipo_sanguineo;
            public Paciente(string nome, string data_de_nascimento, string genero, string cpf, string entrada, string tipo_sanguineo){
                this.data_de_nascimento = data_de_nascimento;
                this.nome = nome;
                this.genero = genero;
                this.cpf = cpf;
                this.entrada = entrada;
                this.tipo_sanguineo = tipo_sanguineo;
            }
            public string getNome(){
                return this.nome;
            }
            public string getDataDeNascimento(){
                return this.data_de_nascimento;
            }
            public string getGenero(){
                return this.genero;
            }
            public string getCPF(){
                return this.cpf;
            }
            public string getEntrada(){
                return this.entrada;
            }
            public string getTipoSanguineo(){
                return this.tipo_sanguineo;
            }
}
