using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveBarra : MonoBehaviour {
	
    Rigidbody2D rb;

    [SerializeField]
    GameObject[] vidas;
    
    public int vida;
    
    [SerializeField]
    GameObject ball;

    [SerializeField]
    Text score;
    
    public int pontos;

	
    // Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
        spawn();
        pontos = 0;
        vida = 3;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3 (10*Time.deltaTime * Input.GetAxisRaw ("Horizontal"), 0, 0));
        score.text = "Pontos: " + pontos.ToString();

        if (pontos == 1305 || vida==0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (vida == 3)
        {
            vidas[0].SetActive(true);
            vidas[1].SetActive(true);
            vidas[2].SetActive(true);
        }

        else if (vida == 2)
        {
            vidas[0].SetActive(false);
        }
        
        else if (vida == 1)
        {
            vidas[1].SetActive(false);
        }
    }

    public void spawn()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
