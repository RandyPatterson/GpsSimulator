using Microsoft.Extensions.Configuration;
using System.Threading;

namespace IoTGpsSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            SetupConfig();
            string conn = _configuration["deviceConnectionString"];

            var currentNum = 0;
            var program = new Program();

            while (true)
            {
                GeoPoint geoPoint = program.coordinates[currentNum++ % program.coordinates.Length];
                var payload = new Payload(geoPoint.Latitude, geoPoint.Longitude);

                AzureIoTHub.SendDeviceToCloudMessageAsync(payload, conn).Wait();
                //Transmit every 5 seconds
                Thread.Sleep(5000);
            }
        }

        private static void SetupConfig()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile("appsettings.prod.json",optional: true, reloadOnChange: true);

            _configuration = configurationBuilder.Build();
        }


        public GeoPoint[] coordinates =
        {
            new GeoPoint(28.42175002m, -81.57573703m),
            new GeoPoint(28.41851686m, -81.58886294m),
            new GeoPoint(28.41366043m, -81.57864576m),
            new GeoPoint(28.41864165m, -81.58339892m),
            new GeoPoint(28.41946254m, -81.57964785m),
            new GeoPoint(28.42039291m, -81.58750498m),
            new GeoPoint(28.42341078m, -81.58533063m),
            new GeoPoint(28.41297745m, -81.57946428m),
            new GeoPoint(28.41520702m, -81.58630846m),
            new GeoPoint(28.42456244m, -81.57822776m),
            new GeoPoint(28.41460433m, -81.57722991m),
            new GeoPoint(28.42129243m, -81.58206893m),
            new GeoPoint(28.4239777m, -81.58310416m),
            new GeoPoint(28.41716679m, -81.57821795m),
            new GeoPoint(28.42202159m, -81.57837547m),
            new GeoPoint(28.41588179m, -81.57922848m),
            new GeoPoint(28.41679995m, -81.57864975m),
            new GeoPoint(28.41527592m, -81.58198885m),
            new GeoPoint(28.41461267m, -81.58347538m),
            new GeoPoint(28.42151691m, -81.57691307m),
            new GeoPoint(28.41573203m, -81.57664729m),
            new GeoPoint(28.41421251m, -81.57533915m),
            new GeoPoint(28.42334834m, -81.57730445m),
            new GeoPoint(28.42001586m, -81.57843564m),
            new GeoPoint(28.41916342m, -81.57689572m),
            new GeoPoint(28.42339063m, -81.58621614m),
            new GeoPoint(28.41615892m, -81.58319881m),
            new GeoPoint(28.41407574m, -81.58321036m),
            new GeoPoint(28.41742847m, -81.57345745m),
            new GeoPoint(28.4131759m, -81.586162m),
            new GeoPoint(28.41718744m, -81.5832092m),
            new GeoPoint(28.41544603m, -81.5840826m),
            new GeoPoint(28.42058869m, -81.58135477m),
            new GeoPoint(28.41990626m, -81.58270135m),
            new GeoPoint(28.41973981m, -81.58209893m),
            new GeoPoint(28.42084349m, -81.58126233m),
            new GeoPoint(28.41908467m, -81.58231927m),
            new GeoPoint(28.4205522m, -81.58095492m),
            new GeoPoint(28.41962854m, -81.58208561m),
            new GeoPoint(28.42117249m, -81.5811806m),
            new GeoPoint(28.42117665m, -81.58174237m),
            new GeoPoint(28.42088524m, -81.58129054m),
            new GeoPoint(28.42151459m, -81.58114364m),
            new GeoPoint(28.42025961m, -81.57974343m),
            new GeoPoint(28.42112712m, -81.581506m),
            new GeoPoint(28.42111924m, -81.58043081m),
            new GeoPoint(28.41914266m, -81.58133067m),
            new GeoPoint(28.42015985m, -81.58030859m),
            new GeoPoint(28.42077714m, -81.58117679m),
            new GeoPoint(28.42092619m, -81.58133805m),
            new GeoPoint(28.41949967m, -81.58047577m),
            new GeoPoint(28.42069706m, -81.58071111m),
            new GeoPoint(28.41957794m, -81.57986605m),
            new GeoPoint(28.41850202m, -81.58042626m),
            new GeoPoint(28.42271104m, -81.58000892m),
            new GeoPoint(28.41840358m, -81.58281656m),
            new GeoPoint(28.42168628m, -81.58078404m),
            new GeoPoint(28.41844246m, -81.58177497m),
            new GeoPoint(28.41928596m, -81.57844403m),
            new GeoPoint(28.41859773m, -81.58400239m),
            new GeoPoint(28.42270671m, -81.58142772m),
            new GeoPoint(28.41925324m, -81.58257335m),
            new GeoPoint(28.42097712m, -81.58047464m),
            new GeoPoint(28.4216304m, -81.5821561m),
            new GeoPoint(28.41866295m, -81.57897805m),
            new GeoPoint(28.42133678m, -81.57939551m),
            new GeoPoint(28.42137686m, -81.58177479m),
            new GeoPoint(28.42188929m, -81.58176049m),
            new GeoPoint(28.4186742m, -81.57874414m),
            new GeoPoint(28.41872528m, -81.58318099m),
            new GeoPoint(28.42007411m, -81.58256097m),
            new GeoPoint(28.42081807m, -81.58126252m),
            new GeoPoint(28.42068044m, -81.58131194m),
            new GeoPoint(28.42166261m, -81.58121441m),
            new GeoPoint(28.42247447m, -81.57986749m),
            new GeoPoint(28.42047106m, -81.57859923m),
            new GeoPoint(28.42116736m, -81.58030595m),
            new GeoPoint(28.41743234m, -81.58207419m),
            new GeoPoint(28.41772274m, -81.58099826m),
            new GeoPoint(28.41899134m, -81.5822575m),
            new GeoPoint(28.42006123m, -81.57904315m),
            new GeoPoint(28.42128412m, -81.58281894m),
            new GeoPoint(28.41838468m, -81.5828614m)

        };

        private static IConfiguration _configuration;
    }
    
}