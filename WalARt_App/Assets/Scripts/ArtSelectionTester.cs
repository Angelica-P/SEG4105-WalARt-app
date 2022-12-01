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


    public void BuyArt(){
        Application.OpenURL("https://www.artwrk.ca/holiday-gift-guide/");
    }

    public void OnMoonSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Moon", "Moon", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnFlowerSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Flower", "Flower", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnJupiterSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Jupiter", "Jupiter", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnKiteSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Kite", "Kite", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnLandscapeSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Landscape", "Landspace", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnMuralSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Mural", "Mural", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnPuzzleSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Puzzle", "Puzzle", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnTigerSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Tiger", "Tiger", "Unknown",0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

}
