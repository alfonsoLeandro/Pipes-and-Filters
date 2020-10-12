using System.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using TwitterUCU; 

namespace CompAndDel
{

    public class TwitterSender
    {
        int pipe=1;

        string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";

        TwitterImage twitter;
        public TwitterSender()
        {
            this.twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);


        }
     
       public void publishFilter (string path)
        {
           
           string stringpipe= "Imagen luego del " + pipe + " pipe"; 
           twitter.PublishToTwitter(stringpipe, path);
           pipe++;
      
        }






    }
}