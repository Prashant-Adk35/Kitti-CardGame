using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class Card : MonoBehaviour
    {
        public static Card Instance { get; set; }
   
        public static Card GetInstance()
        {
            return Instance == null ? FindObjectOfType<Card>() : Instance;
        }

        public List<Sprite> CardSprites;
        public GameObject ImagePrefab;
        //
        // public void CardProperties(int i)
        // {
        //     CardIndexs = i;
        //     CardNumbers = i % 13 + 1;
        //     
        // }
        //
        // private void Awake()
        // {
        //     img = GetComponent<Image>();
        // }
        //
        // public void SetImage(Sprite sprites)
        // {
        //     img.sprite = sprites;
        //     // CardSprites = sprites;
        // }

    }
