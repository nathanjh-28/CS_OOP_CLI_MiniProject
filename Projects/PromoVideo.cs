///////////////////////////////////////////////////////////////////////////////
/// Filename: PromoVideo.cs
/// Author: Nathan Harris
/// Date: 2025-06-09
/// Description: This derived class is a Project type of Video Promo Shoot
///////////////////////////////////////////////////////////////////////////////

namespace Projects;

public class PromoVideo : Project
{
    public int VideoLength;
    // constructor
    public PromoVideo(string clientName, int shootDays, int videoLength) : base(clientName, shootDays)
    => VideoLength = videoLength;

    // override method
    public override void PrepForShoot()
    {
        AddTask("sign video agreement", 1);
        AddTask("confirm shoot dates", 2);
        AddTask("book video camera operator", 1);
    }

}
