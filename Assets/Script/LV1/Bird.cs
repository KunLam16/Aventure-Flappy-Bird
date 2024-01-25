using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float jumpForce;
    private bool levelStart;
    public GameObject gameController;
    public GameObject lblStart;
    public GameObject lblWin;
    public GameObject lblLvUp;
    public GameObject lblEnd;
    public GameObject pipe;
    public GameObject preFabs;
    

    public int score;
    public Text scoreText;
    public Text endScore;
    public Image playAgain;
    public Image ImageLv2;
    public Image backLv;




    // Start is called before the first frame update
    private void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        /*if(rigidbody != null)
        {
            Debug.Log("Da tim thay rigibody2D");
        }*/
        levelStart = false;
        rigidbody.gravityScale = 0;
        score = 0;
        lblStart.GetComponent<SpriteRenderer>().enabled = true;
        lblEnd.GetComponent<SpriteRenderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) 
        {
            SoundController.instance.PlayThisSound("wing", 0.2f);
            if(levelStart == false)
            {
                levelStart = true;
                rigidbody.gravityScale = 3;
                gameController.GetComponent<PipeGene>().choPhepSinhOng = true;
                lblStart.GetComponent<SpriteRenderer>().enabled = false;

            }
            BirdMoveUp();
            NextLevel();
        }
    }
    private void BirdMoveUp()
    {
        rigidbody.velocity = Vector2.up * jumpForce;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundController.instance.PlayThisSound("hit", 0.1f);

        //Debug.Log("Va cham");
        //lblEnd.GetComponent<SpriteRenderer>().enabled = true;
        //if (lblEnd.GetComponent<SpriteRenderer>().enabled = true)
        //{
        /* if (Input.GetKeyDown(KeyCode.KeypadEnter))
         {
             ReloadScene();
             lblEnd.GetComponent<SpriteRenderer>().enabled = false;

         }*/
        //}
            PlayerLose();
        Time.timeScale = 0f;
            

            //Invoke("ReloadScene", 1.5f);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("+1");
        score += 1;
        scoreText.text = "SCORE: "+score.ToString();
        SoundController.instance.PlayThisSound("point", 0.15f);
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(1);
        score = 0;
        pipe.GetComponent<Pipe>().speed = 4;
    }
    public void PlayerLose()
    {
        
        /*gameController.GetComponent<PipeGene>().choPhepSinhOng = false;
        //preFabs.SetActive(false);
        jumpForce = 0;
        pipe.GetComponent<Pipe>().speed = 0;
        rigidbody.gravityScale = 0;*/
        lblEnd.GetComponent<SpriteRenderer>().enabled = true;
        endScore.GetComponent<Text>().enabled = true;
        endScore.text = "CHÚC MỪNG BẠN DÀNH ĐƯỢC " + score.ToString() + " ĐIỂM!";
        playAgain.GetComponent<Image>().enabled = true;
    }
    public void NextLevel()
    {
        if(score == 55)
        {
            Time.timeScale = 0f;
            playAgain.GetComponent<Image>().enabled = true;
            lblWin.GetComponent<SpriteRenderer>().enabled = true;
            lblLvUp.GetComponent<SpriteRenderer>().enabled = true;
            ImageLv2.GetComponent<Image>().enabled = true;
            backLv.GetComponent<Image>().enabled = true;
            
        }    
    }
    
}
