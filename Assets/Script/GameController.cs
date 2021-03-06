﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace IndianaBones
{

    public class GameController : MonoBehaviour
    {

        public int turno = 1;
        public int turnoNemici = 1;
        public Scrollbar vita;
        public float barraVita = 1.0f;

        void Awake()
        {
            
        }

        IEnumerator TurnEnemyAfterSeconds(float seconds)
        {
            
            
            int count = 0;
            while (count < 1)
            {


                yield return new WaitForSeconds(seconds);
                Lara lara = FindObjectOfType<Lara>();
                if (lara != null)
                {
                    lara.Posizione();
                    lara.attacco = 1;
                }
                else if (lara == null)
                    turno = 1;

                count++;
            }
            turnoNemici = 1;

        }

        void Update()
        {
            Player elementi = FindObjectOfType<Player>();
            
            if (elementi.movimento == 0)
                turno = 0;
            if (turno == 0 && turnoNemici == 1)
            {
                turnoNemici = 0;
                StartCoroutine(TurnEnemyAfterSeconds(0.2f));
            }

            Scrollbar nuovaVita = vita.GetComponent<Scrollbar>();
            nuovaVita.size = barraVita;



        }
    }
}
