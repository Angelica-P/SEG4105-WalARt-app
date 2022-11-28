using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArtSelectionTester : MonoBehaviour
{
    public GameObject artworks;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDefaultSelect()
    {
        ViewingArt.Art =  new Artwork("../TextMesh Pro/Examples & Extras/Textures/Sunny Days - Seamless.jpg", "Amogus", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnAmogusSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/amogus", "Amogus", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnStonksSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/stonks", "Stonks", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnThisIsntGeographySelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/this_isnt_geography","Geography", "Unknown", 0.96, 0.60);
        SceneManager.LoadScene("Scenes/ViewArt");
    }
}
