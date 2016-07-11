﻿using UnityEngine;
using System.Collections;

namespace IndianaBones
{

    public class enemyCollision : MonoBehaviour
    {

        public GameObject laraCroft;
        public GameObject denteSpawn;

        public void OnCollisionEnter2D(Collision2D coll)
        {



            if (coll.gameObject.name == "dente(Clone)")
            {
                Griglia objGriglia = FindObjectOfType<Griglia>();
                Lara newLara = FindObjectOfType<Lara>();

                GameObject newDente = Instantiate(denteSpawn);
                newDente.transform.position = laraCroft.transform.position;
                objGriglia.scacchiera[(int)newDente.transform.position.x, (int)newDente.transform.position.y].status = -1;
                

                newLara.vita -= 1;
                Destroy(coll.gameObject);
                Destroy(laraCroft.gameObject);


            }

            



        }
    }
}
