using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatalogManager : MonoBehaviour
{
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
        ViewingArt.Art =  new Artwork("ArtSprites/Moon", "Moon", "Unknown",1.412, 2.048);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnFlowerSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Flower", "Flower", "Unknown", 0.518, 0.920);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnJupiterSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Jupiter", "Jupiter", "Unknown", 0.410, 0.728);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnKiteSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Kite", "Kite", "Unknown", 0.518, 0.920);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnLandscapeSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Landscape", "Landspace", "Unknown", 0.450, 0.800);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnMuralSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Mural", "Mural", "Unknown", 0.518, 0.920);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnPuzzleSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Puzzle", "Puzzle", "Unknown", 0.552, 0.775);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnTigerSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Tiger", "Tiger", "Unknown", 0.518, 0.920);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnCloudSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/Cloud", "Cool Cloud", "Unknown", 0.410, 0.728);
        SceneManager.LoadScene("Scenes/ViewArt");
    }
}
