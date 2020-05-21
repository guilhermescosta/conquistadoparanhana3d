using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGUI : MonoBehaviour
{
    public Player _player;
   
    public GameObject _menu;

    public Text textDinheiro;

    public Text textMilho;
    public Text textTabaco;
    public Text textArroz;
    public Text textFeijao;

    public Text textSementeMilho;
    public Text textMudaTabaco;
    public Text textSementeArroz;
    public Text textSementeFeijao;

    public Text textMadeira;
    public Text textPeixe;
    public Text textBanana;

    public GameObject iconeMachado;
    public GameObject iconePa;
    public GameObject iconeFoice;
    public GameObject iconePicareta;



    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && _menu.activeSelf == false)
        {
            _menu.SetActive(true);
            AbreMenu();
        }
        else if ((Input.GetKeyDown(KeyCode.Tab)) && _menu.activeSelf == true)
        {
            _menu.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log( _player._inventory.temMachado);
        }
        
    }


    public void AbreMenu()
    {
        textDinheiro.text = "Dinheiro: "+ _player._inventory.dinheiro.ToString();

        textMilho.text = "Milho: "+_player._inventory.milho.ToString();
        textTabaco.text  = "Tabaco: "+ _player._inventory.tabaco.ToString();
        textArroz.text   = "Arroz: "+ _player._inventory.arroz.ToString();
        textFeijao.text = "Feijão: "+ _player._inventory.feijao.ToString();

        textSementeMilho.text = "Semente de Milho: "+_player._inventory.sementeMilho.ToString();
        textMudaTabaco.text = "Muda de Tabaco: "+ _player._inventory.mudaTabaco.ToString();
        textSementeArroz.text = "Semente de Arroz: "+ _player._inventory.sementeArroz.ToString();
        textSementeFeijao.text = "Semente de Feijão: "+ _player._inventory.sementeFeijao.ToString();

        textMadeira.text = "Madeira: " + _player._inventory.madeira;
        textPeixe.text = "Peixe: " + _player._inventory.peixe;
        textBanana.text = "Banana: " + _player._inventory.banana;

        if (_player._inventory.temMachado)
        {
            iconeMachado.SetActive(true);
        } else
            iconeMachado.SetActive(false);

        if (_player._inventory.temFoice)
        {
            iconeFoice.SetActive(true);
        }else
            iconeFoice.SetActive(false);

        if (_player._inventory.temPa)
        {
            iconePa.SetActive(true);
        } else
            iconePa.SetActive(false);

        if (_player._inventory.temPicareta)
        {
            iconePicareta.SetActive(true);
        } else
            iconePicareta.SetActive(false);

    }
}
