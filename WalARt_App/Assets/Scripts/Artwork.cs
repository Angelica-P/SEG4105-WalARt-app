using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artwork
{

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
