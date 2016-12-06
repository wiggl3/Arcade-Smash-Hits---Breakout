using UnityEngine;
using System.Collections;

public class VelBola : MonoBehaviour {

	Rigidbody2D rb;
	int vel;
    int x;

    MoveBarra mb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        vel = 100;

        x = 10;
        rb.velocity = new Vector3 (x,vel*Time.deltaTime,0);
        mb = FindObjectOfType<MoveBarra>();

	}
	
	// Update is called once per frame
	void Update () {
		//rb.AddForce (new Vector3 (1*Time.deltaTime, 500 * Time.deltaTime, 0));
		//transform.Translate (new Vector3 (0, vel * Time.deltaTime, 0));
  

	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "Vermelho") 
		{
            mb.pontos += 20;
		}

        if (other.gameObject.tag == "Rosa")
        {
            mb.pontos += 10;
        }

        if (other.gameObject.tag == "Azul")
        {
            mb.pontos += 15;
        }

        if (other.gameObject.tag == "Verde")
        {
            mb.pontos += 30;
        }

        if (other.gameObject.tag == "Amarelo")
        {
            mb.pontos += 20;
        }

        if (other.gameObject.tag == "end")
        {
           Destroy(gameObject, 0.3f);
           mb.spawn();
           mb.vida--;
        }

        if (other.gameObject.tag == "Esquerda")
        {
        }

        if (other.gameObject.tag == "Direita")
        {
        }
	}
}
