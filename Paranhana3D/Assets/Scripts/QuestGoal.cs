using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    public TipoObjetivo tipoObjetivo;

    public int quantidadeNecessaria;
    public int quantidadeAtual;

    public bool FoiAtingido()
    {
        return (quantidadeAtual >= quantidadeNecessaria);
    }

    public enum TipoObjetivo
    {
        COLETAR, ENTREGAR, CONSTRUIR
    }

    public void ItemColetado()
    {
        if (tipoObjetivo == TipoObjetivo.COLETAR)
        {
            quantidadeAtual++;
        }
    }

    public void ItemEntregue()
    {
        if (tipoObjetivo == TipoObjetivo.ENTREGAR)
        {
            quantidadeAtual++;
        }
    }

    public void ItemConstruido()
    {
        if (tipoObjetivo == TipoObjetivo.CONSTRUIR)
        {
            quantidadeAtual++;
        }
    }


}
