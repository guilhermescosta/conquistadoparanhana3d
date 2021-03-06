﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public bool canWalk;
    public GameObject _icon_text;
    public GameObject _charInteraction;

    public Inventory _inventory = new Inventory();

    public int _textIndex;
    public int _index;

    
    public bool onTree;

    
    public bool isArable;
    public bool isPlough;
    GameObject groundObject;
   

    public GameObject _arvore;
    public Rigidbody rb;
    public GameObject textBackground;
    public Text _chatText;


    // Use this for initialization
    void Start () {
        _index = 0;
        canWalk = true;

        rb = this.GetComponent<Rigidbody>();

       
    }
	
	// Update is called once per frame
	void Update () {

        if (rb.velocity.magnitude > 15f)   //todo: create a new variable for the max speed
        {
            rb.velocity = rb.velocity.normalized * 15f;
        }

        if (canWalk == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //transform.Translate(0, 0, .5f);
                
                rb.AddForce(transform.forward * 1000f);


            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, 0, -.5f);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up * -5f);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up * 5f);
            }
        }


        // Falar com personagens
        if (_icon_text.activeSelf==true) {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_index - 1 < _textIndex)
                {
                    canWalk = false;
                    textBackground.SetActive(true);
                }

                Debug.Log( _charInteraction.GetComponent<CharacterText>().texts[_index] );
                _chatText.text = _charInteraction.GetComponent<CharacterText>().texts[_index];
                if (_index + 1 < _textIndex)
                {
                    _index++;

                }
                else
                {
                    canWalk = true;

                    if (_charInteraction.GetComponent<CharacterText>()._item == CharacterText.ItemGiven.Machado)
                    {
                         _inventory.temMachado = true;
                    }
                }
            }
        }


        // Cortar Arvore
        if (onTree && _inventory.temMachado) {
            if (Input.GetKeyDown(KeyCode.Space)){
                _inventory.madeira += 10;
                _arvore.GetComponent<MeshRenderer>().enabled = false;

            }
        }

        // Arar Terra
        
        if (isArable ){    //&& _inventory.temPa
            if (Input.GetKeyDown(KeyCode.Space)){
                groundObject.GetComponent<MeshRenderer>().material = groundObject.GetComponent<Plow>().materialPlow;

            }
        }



    }

    private void OnTriggerEnter(Collider other)
    {
      
        _icon_text.SetActive(true);
        _charInteraction = other.gameObject;
        _textIndex = other.gameObject.GetComponent<CharacterText>().texts.Length;


    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject);
        _icon_text.SetActive(false);
        _charInteraction = null;
        _index = 0;

        if(textBackground.activeSelf==true )
            textBackground.SetActive(false);



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("tree"))
        {
            onTree = true;
            _arvore = collision.gameObject;
        }

        if (collision.gameObject.CompareTag("arable"))
        {
            isArable = true;
            groundObject = collision.gameObject;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("tree"))
        {
            onTree = false;
            _arvore = null;
        }

        if (collision.gameObject.CompareTag("arable"))
        {
            isArable = false;
            groundObject = null;
        }
    }

  

    public void Arar()
    {

    }

}
