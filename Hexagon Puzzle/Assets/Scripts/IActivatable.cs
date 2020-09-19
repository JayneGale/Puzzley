internal interface IActivatable
{
//    when the player activates a tri, SwapTri is the number (1-5) of the other target Tri affected ie tri 1 is North, 2 NE, 3 SE, 4 SW 5 NW NB it can affect itself?
//    T ChangeFactor { get; set; }
    //the changefactor can be an angle to rotate, an RGB colour amount or a bool flip
//    void Activate(int SwapTri, T ChangeFactor);
    void Activate();

}