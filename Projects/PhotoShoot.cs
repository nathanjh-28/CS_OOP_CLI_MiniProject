///////////////////////////////////////////////////////////////////////////////
/// Filename: PhotoShoot.cs
/// Author: Nathan Harris
/// Date: 2025-06-09
/// Description: This derived class is a Project type of Video Promo Shoot
///////////////////////////////////////////////////////////////////////////////

namespace Projects;

public class PhotoShoot : Project
{
    public int NumImages;
    // constructor
    public PhotoShoot(string clientName, int shootDays, int numImages) : base(clientName, shootDays)
        => NumImages = numImages;


    // override method
    public override void PrepForShoot()
    {
        AddTask("sign photo agreement", 1);
        AddTask("confirm shoot dates", 2);
        AddTask("book photo assistant", 1);
    }

}
