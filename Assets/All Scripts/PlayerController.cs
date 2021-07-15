  using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpforce, sideforce;
    public bool IsGrounded ,IsPointerDown=false, IsleftPointerDown=false,upbuttonispressed=false,isladder=false,downbuttonispressed=false;
    public float jumpcount=0f;
    public GameObject lyf1,lyf2,lyf3;
    public int counter=0,score=00;
    public int highscore;
    public Audiomanager audiomanager;
   

    public Canvas scorenadlifecanvas,lost3lifescanvas,pausecanvas;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 00);
        audiomanager.Play("bgmgame");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        IsGrounded = true;
    }
    private void OnTriggerEnter2D(Collider2D colpoint)
    {
        if (colpoint.gameObject.tag == "Points") {

            Destroy(colpoint.gameObject);
            audiomanager.Play("coincollection");
            score += 25;
        }
        if (colpoint.gameObject.tag == "rope") {

            isladder = true;

        }
        
    }

    void Update()
    {
        if (jumpcount >= 1) {
            jumpcount = 0f;
            IsGrounded = false;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded==true)
        {
            audiomanager.Play("jump");
            rb.velocity = Vector2.up * jumpforce;
            jumpcount++;
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            
                pausecanvas.gameObject.SetActive(true);
                scorenadlifecanvas.gameObject.SetActive(false);
                Time.timeScale = 0f;
            
          
        }
        sethighscore();
        
       

    }
    
    private void FixedUpdate()
    {
        var movementinput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movementinput*Time.deltaTime*sideforce,0,0);
        if (IsPointerDown)
        {
            rb.velocity = Vector2.right * sideforce * Time.deltaTime * 45f;
        }
        if (IsleftPointerDown)
        {
            rb.velocity = Vector2.left * sideforce * Time.deltaTime * 45f;
        }
        if (upbuttonispressed && isladder) {

            rb.gravityScale = 0f;
            rb.velocity = Vector2.up * Time.deltaTime * 450f;

        }
        if (downbuttonispressed && isladder)
        {

            rb.gravityScale = 0f;
            rb.velocity = Vector2.up * Time.deltaTime * -450f;

        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rope") {

            isladder = false;
        
        }
    }

    public void ResetHighscore()
    {
        PlayerPrefs.DeleteKey("highscore");
        highscore = 00;
    }
    public void lifeconditions() {
       
        if (counter == 0)
        {
            lyf3.SetActive(true);
            lyf2.SetActive(true);
            lyf2.SetActive(true);
          
            
        }
        if (counter == 1)
        {
            lyf3.SetActive(false);
            audiomanager.Play("lostlife");
          
        }

        if (counter == 2)
        {
            lyf3.SetActive(false);
            lyf2.SetActive(false);
           
            audiomanager.Play("lostlife");
        }
        if (counter == 3)
        {
            audiomanager.Play("playerdeath");
            counter = 0;
        
            scorenadlifecanvas.gameObject.SetActive(false);
            Time.timeScale = 0f;
            lost3lifescanvas.gameObject.SetActive(true);
           

        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
     
        if (col.gameObject.tag == "enemy") {
            counter++;
            lifeconditions();

        }
           
    }
    public void sethighscore() {
        if (score >= PlayerPrefs.GetInt("highscore", 00))
        {

            PlayerPrefs.SetInt("highscore", score);
            highscore = score;

        }
    }

    public void jumperbutton() {
        if (IsGrounded)
        {
            audiomanager.Play("jump");
            rb.velocity = Vector2.up * jumpforce;
            jumpcount++;
        }
    }
    public void sidemovepointerdown()
    {
        IsPointerDown = true;
       
    }
    public void sidemovepointerup()
    {
        IsPointerDown = false;
    }

    public void leftsidemovepointerdown()
    {
        IsleftPointerDown = true;

    }
    public void leftsidemovepointerup()
    {
        IsleftPointerDown = false;
    }
    public void upbuttondown() {

        upbuttonispressed = true;
    
    }
    public void upbuttonup()
    {

        upbuttonispressed = false;
        rb.gravityScale = 5f;
    }
    public void downbuttondown() {

        downbuttonispressed = true;
    
    }
    public void downbuttonup()
    {

        downbuttonispressed = false;
        rb.gravityScale = 5f;
    }
}
