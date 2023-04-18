using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public int P1Life;
    public int P2Life;

    public GameObject p1Wins;
    public GameObject p2Wins;

    public GameObject[] p1Canes;
    public GameObject[] p2Canes;

    public AudioSource damageSound;

    public string menuScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(P1Life <= 0)
        {
            player1.SetActive(false);
            p2Wins.SetActive(true);
        }

        if (P2Life <= 0)
        {
            player2.SetActive(false);
            p1Wins.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(menuScene);
        }
    }

    public void DamageP1()
    {
        P1Life--;

        for(int i=0; i<p1Canes.Length; i++)
        {
            if(P1Life > i)
            {
                p1Canes[i].SetActive(true);
            } else
            {
                p1Canes[i].SetActive(false);
            }
        }

        damageSound.Play();
    }

    public void DamageP2()
    {
        P2Life--;

        for (int i = 0; i < p2Canes.Length; i++)
        {
            if (P2Life > i)
            {
                p2Canes[i].SetActive(true);
            }
            else
            {
                p2Canes[i].SetActive(false);
            }
        }

        damageSound.Play();
    }
}
