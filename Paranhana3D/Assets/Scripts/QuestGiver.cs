using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public GameObject janelaQuest;
    public Text titulo;
    public Text descricao;
    public Text dinheiro;
    public bool questComItem;
    public Text item;
    public Player player;

    public void AbreJanelaQuest()
    {
        janelaQuest.SetActive(true);
        titulo.text = quest.titulo;
        descricao.text = quest.descricao;
        dinheiro.text = quest.dinheiroRecompensa.ToString();
        if (questComItem)
        {
            item.text = quest.itemRecompensa.name;
        }
    }

    public void AceitarQuest()
    {
        /*
        janelaQuest.SetActive(false);
        quest.estaAtivo = true;
        player.quest = quest;
        */
    }


}
