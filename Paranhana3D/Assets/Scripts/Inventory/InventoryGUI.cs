using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGUI : MonoBehaviour
{
    public Inventory _inventory;
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

        
    }


    public void AbreMenu()
    {
        textDinheiro.text = _inventory.dinheiro.ToString();

        textMilho.text = _inventory.milho.ToString();
        textTabaco.text  =  _inventory.tabaco.ToString();
        textArroz.text   =   _inventory.arroz.ToString();
        textFeijao.text =   _inventory.feijao.ToString();

        textSementeMilho.text = _inventory.sementeMilho.ToString();
        textMudaTabaco.text = _inventory.mudaTabaco.ToString();
        textSementeArroz.text = _inventory.sementeArroz.ToString();
        textSementeFeijao.text = _inventory.sementeFeijao.ToString();

        if (_inventory.temMachado)
        {
            iconeMachado.SetActive(true);
        }

        if (_inventory.temFoice)
        {
            iconeFoice.SetActive(true);
        }

        if (_inventory.temPa)
        {
            iconePa.SetActive(true);
        }

        if (_inventory.temPicareta)
        {
            iconePicareta.SetActive(true);
        }

    }
}
