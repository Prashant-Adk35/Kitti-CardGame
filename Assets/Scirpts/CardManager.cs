using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;
using Random = UnityEngine.Random;


    public class CardManager : MonoBehaviour
    {
        [SerializeField]
        // public List<Sprite> CardSprite = new List<Sprite>();
        public GameObject Container;
        private Card _card;
        
        // public GameObject CardHolder;
        // public GameObject CardPrefab;
        
        private float xOffset;
        private int cardName;

        

        
        private void Start()
        {
            
            DistributeDeck();
            ShuffleDeck();
            // for (int i = 0; i < 51; i++)
            // {
            //     cardName = i;
            //     SpawnCard();
            // }
            
        }

        public void ShuffleDeck()
        {
            for (int i = 0; i < Card.GetInstance().CardSprites.Count; i++)
            {
                var temp = Card.GetInstance().CardSprites[i];
                int randomIndex = Random.Range(i, Card.GetInstance().CardSprites.Count);
                Card.GetInstance().CardSprites[i] = Card.GetInstance().CardSprites[randomIndex];
                Card.GetInstance().CardSprites[randomIndex] = temp;
                for (int ii = 0; i < 8; i++)
                {
                    Instantiate(Card.GetInstance().CardSprites[ii], Container.transform.position, Quaternion.identity);

                }
            }
        }

        public void DistributeDeck()
        {
            
            // foreach (var i in Card.GetInstance().CardSprites)
            // {
            // }
        }

        // void SpawnCard()
        // {
        //     GameObject card = Instantiate(CardPrefab, Container.transform);
        //     card.name = "Card " + cardName;
        //     card.GetComponent<Card>().SetImage(CardSprite[cardName]);
        // }
    }
    

