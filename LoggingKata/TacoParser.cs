namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");
            var cells = line.Split(',');
            if (cells.Length < 3)
            {
                return null; 
            }
            double longitude;
            double latitude;
            string name;
            double.TryParse(cells[1], out longitude);
            double.TryParse(cells[0], out latitude);
            name = cells[2];
            var taco = new TacoBell();
            taco.Name = name;
            var point = new Point();
            point.Longitude = longitude;
            point.Latitude = latitude;
            taco.Location = point;
            
            return taco;
            // grab the longitude from your array at index 1
            // grab the name from your array at index 2
            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            // You'll need to create a TacoBell class
            // that conforms to ITrackable
            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
        }
    }
}