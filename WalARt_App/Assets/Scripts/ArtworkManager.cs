using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ArtworkManager : MonoBehaviour
{

    public ARRaycastManager raycastManager;

    public GameObject artBase;

    public SpriteRenderer artSpriteRenderer;

    private Artwork artwork;

    private bool isArtworkPlaced = false;


    // Start is called before the first frame update
    void Start()
    {
        this.artwork = new Artwork("ArtSprites/stonks", 0.625, 0.85);


        //x, y, x
        this.artBase.transform.localScale = new Vector3((float)this.artwork.Width, (float)this.artwork.Height, 0.03f);
        this.artSpriteRenderer.sprite = Resources.Load<Sprite>(this.artwork.Image);
        this.artSpriteRenderer.size = new Vector2(1.0f, 1.0f);

        this.artBase.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //do the initial placing on the first detected wall
        if (!this.isArtworkPlaced)
        {
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            this.raycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits);

            Debug.Log("number of hits: "+hits.Count);
            if(hits.Count > 0)
            {
                this.artBase.transform.position = hits[0].pose.position;
                this.artBase.transform.rotation = new Quaternion(0f, hits[0].pose.rotation.y, 0f, hits[0].pose.rotation.w);

                this.artBase.SetActive(true);
                this.isArtworkPlaced = true;
                Debug.Log("artwork placed");
            }
        }   
    }

    public void MoveUp()
    {

    }

    public void ModeDown()
    {

    }

    public void MoveLeft()
    {

    }

    public void MoveRight()
    {

    }

    public void MoveForward()
    {

    }

    public void MoveBackward()
    {

    }

    public void RotateLeft()
    {

    }

    public void RotateRight()
    {

    }
}
