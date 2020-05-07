using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public string titulo;
    [TextArea]
    public string descricao;
    public bool estaAtivo;
    public float dinheiroRecompensa;
    public GameObject itemRecompensa;

    public QuestGoal objetivo;

    public void Complete()
    {
        estaAtivo = false;
        Debug.Log(titulo + " Completa !");
    }

}
