using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artwork
{

    /*
    Imported images need to be put in the Resources/ArtSprites folder.
    They need their texture type set to "Sprite(2D and UI)".
    The image string should be of the form "ArtSprites/stonks" with no
    file ending such as .png or .jpg"
    */
    private string image;
    public string Image
    {
        get => this.image;
        set => this.image = value;
    }

    private double height;
    public double Height
    {
        get => this.height;
        set => this.height = value;
    }

    private double width;
    public double Width
    {
        get => this.width;
        set => this.width = value;
    }

    public Artwork(string image, double height, double width)
    {
        this.image = image;
        this.height = height;
        this.width = width;
    }
    
}
