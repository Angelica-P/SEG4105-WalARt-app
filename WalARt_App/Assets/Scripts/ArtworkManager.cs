using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;

public class ArtworkManager : MonoBehaviour
{

    public ARRaycastManager raycastManager;

    public GameObject artBase;

    public SpriteRenderer artSpriteRenderer;

    public GameObject xAxis;

    public GameObject yAxis;

    public GameObject zAxis;

    public GameObject rotationIndicator;

    public GameObject controlPanel;

    public GameObject prePlacementText;

    private Artwork artwork;

    private bool isArtworkPlaced = false;

    //check for movement
    private bool isMoveUp = false;
    private bool isMoveDown = false;
    private bool isMoveLeft = false;
    private bool isMoveRight = false;
    private bool isMoveForward = false;
    private bool isMoveBackward = false;
    private bool isRotateCW = false;
    private bool isRotateCCW = false;


    // Start is called before the first frame update
    void Start()
    {
        this.artwork = ViewingArt.Art;

        //x, y, x
        this.artBase.transform.localScale = new Vector3((float)this.artwork.Width, (float)this.artwork.Height, 0.03f);
        this.artSpriteRenderer.sprite = Resources.Load<Sprite>(this.artwork.Image);
        this.artSpriteRenderer.size = new Vector2(1.0f, 1.0f);

        //adjust the y axis on the rotation indicator to handle the new width of the art
        this.rotationIndicator.transform.localScale = new Vector3(this.rotationIndicator.transform.localScale.x * (float)this.artwork.Width, this.rotationIndicator.transform.localScale.y * (float)this.artwork.Width, this.rotationIndicator.transform.localScale.z);

        //disable axises
        this.xAxis.SetActive(false);
        this.yAxis.SetActive(false);
        this.zAxis.SetActive(false);
        this.rotationIndicator.SetActive(false);
        this.artBase.SetActive(false);

        this.controlPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //do the initial placing on the first detected wall
        if (!this.isArtworkPlaced)
        {
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            this.raycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits);

            if(hits.Count > 0)
            {
                this.artBase.transform.position = hits[0].pose.position;
                this.artBase.transform.rotation = new Quaternion(0f, hits[0].pose.rotation.y, 0f, hits[0].pose.rotation.w);

                this.artBase.SetActive(true);
                this.xAxis.SetActive(false);
                this.yAxis.SetActive(false);
                this.zAxis.SetActive(false);
                this.rotationIndicator.SetActive(false);
                this.prePlacementText.SetActive(false);
                this.controlPanel.SetActive(true);

                Animator controlPanelAnimator = this.controlPanel.GetComponent<Animator>();
                if (controlPanelAnimator != null)
                {
                    controlPanelAnimator.SetBool("openController", true);
                }

                this.isArtworkPlaced = true;
                Debug.Log("artwork placed");
            }
        }
        else
        {
            //adjust the movement
            if(this.isMoveUp)
            {
                this.artBase.transform.position += new Vector3(0f, 0.01f, 0f);
            }

            if(this.isMoveDown)
            {
                this.artBase.transform.position += new Vector3(0f, -0.01f, 0f);
            }

            if(this.isMoveLeft)
            {
                this.artBase.transform.position += new Vector3(-0.01f, 0f, 0f);
            }

            if(this.isMoveRight)
            {
                this.artBase.transform.position += new Vector3(0.01f, 0f, 0f);
            }

            if(this.isMoveForward)
            {
                this.artBase.transform.position += new Vector3(0f, 0f, -0.01f);
            }

            if(this.isMoveBackward)
            {
                this.artBase.transform.position += new Vector3(0f, 0f, 0.01f);
            }

            if(this.isRotateCW)
            {
                this.artBase.transform.Rotate(0, 1, 0);
            }

            if(this.isRotateCCW)
            {
                this.artBase.transform.Rotate(0, -1, 0);
            }

            this.artBase.SetActive(true);

            //set the axis visibility
            if(this.isMoveUp || this.isMoveDown)
            {
                this.yAxis.SetActive(true);
            }
            else
            {
                this.yAxis.SetActive(false);
            }

            if(this.isMoveLeft || this.isMoveRight)
            {
                this.xAxis.SetActive(true);
            }
            else
            {
                this.xAxis.SetActive(false);
            }

            if(this.isMoveForward || this.isMoveBackward)
            {
                this.zAxis.SetActive(true);
            }
            else
            {
                this.zAxis.SetActive(false);
            }

            if(this.isRotateCW || this.isRotateCCW)
            {
                this.rotationIndicator.SetActive(true);
            }
            else
            {
                this.rotationIndicator.SetActive(false);
            }
        } 
    }

    public void OnBackToCatalogClicked()
    {
        SceneManager.LoadScene("Scenes/CatalogTest");
    }

    public void MoveUpPressed()
    {
        Debug.Log("move up");
        this.isMoveUp = true;
    }

    public void MoveUpUnPressed()
    {
        Debug.Log("move up");
        this.isMoveUp = false;
    }

    public void MoveDownPressed()
    {
        Debug.Log("move down");
        this.isMoveDown = true;
    }

    public void MoveDownUnPressed()
    {
        Debug.Log("move down");
        this.isMoveDown = false;
    }

    public void MoveLeftPressed()
    {
        Debug.Log("move left");
        this.isMoveLeft = true;
    }

    public void MoveLeftUnPressed()
    {
        Debug.Log("move left");
        this.isMoveLeft = false;
    }

    public void MoveRightPressed()
    {
        Debug.Log("move right");
        this.isMoveRight = true;
    }

    public void MoveRightUnPressed()
    {
        Debug.Log("move right");
        this.isMoveRight = false;
    }

    public void MoveForwardPressed()
    {
        Debug.Log("move forward");
        this.isMoveForward = true;
    }

    public void MoveForwardUnPressed()
    {
        Debug.Log("move forward");
        this.isMoveForward = false;
    }

    public void MoveBackwardPressed()
    {
        Debug.Log("move back");
        this.isMoveBackward = true;
    }

    public void MoveBackwardUnPressed()
    {
        Debug.Log("move back");
        this.isMoveBackward = false;
    }

    public void RotateCWPressed()
    {
        Debug.Log("rotate CW");
        this.isRotateCW = true;
    }

    public void RotateCWUnPressed()
    {
        Debug.Log("rotate CW");
        this.isRotateCW = false;
    }

    public void RotateCCWPressed()
    {
        Debug.Log("rotate CCW");
        this.isRotateCCW = true;
    }

    public void RotateCCWUnPressed()
    {
        Debug.Log("rotate CCW");
        this.isRotateCCW = false;
    }
}
