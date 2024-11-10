using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Provide the template number :");
        Console.WriteLine("1. For Private, Private Transport, and Export templates");
        Console.WriteLine("2. For Private template");
        Console.WriteLine("3. For Private Transport template");
        Console.WriteLine("4. For Under Experiment template");
        Console.WriteLine("5. For Export template");
        Console.WriteLine("6. For Equipment template");
        Console.WriteLine("7. For M/Cycle Template");
        Console.WriteLine("8. For Taxi template");
        Console.WriteLine("9. For Public Transport template");
        Console.WriteLine("10. For Diplomatic template");
        Console.WriteLine("11. For United Nation template");
        Console.WriteLine("12. For Limousine template");
        Console.WriteLine("13. For Commercial template");
        Console.WriteLine("14. For Police template");
        Console.WriteLine("15. For Police  Second template");
        Console.WriteLine("16. For Trailer template");

        int templateNumber = int.Parse(Console.ReadLine());
        int templateChoice = templateNumber;

        switch (templateChoice)
        {
            case 1:
                GenerateImagesForPrivateTemplate(1000);
                GenerateImagesForPrivateTransportTemplate(1000);
                GenerateImagesForExportTemplate(1000, 6);
                break;
            case 2:
                GenerateImagesForPrivateTemplate(1000);
                break;
            case 3:
                GenerateImagesForPrivateTransportTemplate(1000);
                break;
            case 4:
                GenerateImagesForUnderExperimentTemplate(1000, 5);
                break;
            case 5:
                GenerateImagesForExportTemplate(1000, 6);
                break;
            case 6:
                GenerateImagesForEquipmentTemplate(1000, 5);
                break;
            case 7:
                GenerateImagesMCycleTemplate(1000, 5);
                break;
            case 8:
                GenerateImagesForTaxiTemplate(1000, 5);
                break;
            case 9:
                GenerateImagesForPublicTransportTemplate(1000, 5);
                break;
            case 10:
                GenerateImagesForDiplomaticTemplate(1000, 3);
                break;
            case 11:
                GenerateImagesForUnitedNationTemplate(1000, 4);
                break;
            case 12:
                GenerateImagesForLimousineTemplate(1000, 5);
                break;
            case 13:
                GenerateImagesForCommercialTemplate(1000, 5);
                break;
            case 14:
                GenerateImagesForPoliceTemplate(1000, 5);
                break;
            case 15:
                GenerateImagesForPoliceTemplate2(1000, 4);
                break;
            case 16:
                GenerateImagesForTrailerTemplate(1000, 5);
                break;
            default:
                Console.WriteLine("Invalid template choice.");
                break;
        }

        Console.WriteLine("All images have been generated.");
    }


    static void GenerateImagesForPrivateTemplate(int imageCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "PrivateTemplate.png");


        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Private Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(57, 81, 254, 69);
        Rectangle sourceArea = new Rectangle(57, 73, 34, 10);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 62, FontStyle.Regular);
        PointF position = new PointF(50, 70);
        Brush colorBrush = Brushes.Black;

        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Gray));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        Random random = new Random();

        int digitCount = random.Next(4, 7);

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }


    static void GenerateImagesForPrivateTransportTemplate(int imageCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "PrivateTransortTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Private Transport Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(60, 78, 234, 73);
        Rectangle sourceArea = new Rectangle(61, 72, 235, 5);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 60, FontStyle.Regular);
        PointF position = new PointF(48, 66);
        Brush colorBrush = new SolidBrush(Color.FromArgb(245, 245, 230));
        Brush darkShadowBrush = new LinearGradientBrush(new Point(0, 0),new Point(100, 100),Color.FromArgb(130, Color.WhiteSmoke),Color.Black);
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.Black));
        Random random = new Random();

        int digitCount = random.Next(4, 7);
        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, false);
    }
    static void GenerateImagesForUnderExperimentTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "UnderExperimentTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Under Experiment Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(130, 80, 182, 70);
        Rectangle sourceArea = new Rectangle(135, 68, 167, 10);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 58, FontStyle.Bold);
        PointF position = new PointF(115, 72);
        Brush colorBrush = Brushes.Black;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Gray));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static void GenerateImagesForExportTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "ExportTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Export Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(130, 80, 180, 70);
        Rectangle sourceArea = new Rectangle(130, 60, 83, 13);
        Font font = new Font("Bahnschrift SemiBold Condensed", 58, FontStyle.Regular);
        PointF position = new PointF(115, 80);
        Brush colorBrush = Brushes.Black;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Gray));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static void GenerateImagesForEquipmentTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "EquipmentTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Equipment Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(132, 84, 194, 70);
        Rectangle sourceArea = new Rectangle(137, 19, 40, 40);
        Font font = new Font("Bahnschrift SemiBold", 54, FontStyle.Bold);
        PointF position = new PointF(120, 85);
        Brush colorBrush = Brushes.Black;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Gray));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static void GenerateImagesMCycleTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "M_CycleTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "M_Cycle Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(19, 50, 200, 66);
        Rectangle sourceArea = new Rectangle(34, 23, 34, 23);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 60, FontStyle.Regular);
        PointF position = new PointF(08, 40);
        Brush colorBrush = Brushes.Black;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.White));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));


        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }


    static void GenerateImagesForTaxiTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "TaxiTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Taxi Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(120, 73, 175, 70);
        Rectangle sourceArea = new Rectangle(122, 64, 34, 08);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 56, FontStyle.Regular);
        PointF position = new PointF(108, 68);
        Brush colorBrush = Brushes.Black;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.White));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static void GenerateImagesForPublicTransportTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "PublicTransportTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Public Transport Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(130, 83, 180, 70);
        Rectangle sourceArea = new Rectangle(122, 64, 34, 08);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 60, FontStyle.Regular);
        PointF position = new PointF(116, 72);
        Brush colorBrush = Brushes.Black;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.White));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }


    static void GenerateImagesForDiplomaticTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "DiplomaticTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Diplomatic Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(125, 90, 78, 38);
        Rectangle sourceArea = new Rectangle(225, 85, 73, 28);

        Rectangle eraseAreaSingleDigit = new Rectangle(145, 35, 37, 40); 
        Rectangle sourceAreaSingleDigit = new Rectangle(128, 42, 19, 20);

        Font font = new Font("Bahnschrift SemiBold", 32, FontStyle.Bold);
        PointF position = new PointF(122, 90);
        PointF positionSingleDigit = new PointF(152, 39);
        Color sampledColor;
        using (Bitmap bitmap = new Bitmap(originalImagePath))
        {

            sampledColor = GetAverageColor(bitmap, new Rectangle(47, 50, 43, 4));
        }

        Brush colorBrush = new SolidBrush(sampledColor);
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Gray));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, eraseAreaSingleDigit, sourceAreaSingleDigit, font, position, positionSingleDigit, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount,true);
    }

    static void GenerateImagesForUnitedNationTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "UnitedNationTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "United Nation Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(94, 50, 142, 69);
        Rectangle sourceArea = new Rectangle(17, 60, 60, 40);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 58, FontStyle.Bold);
        PointF position = new PointF(76, 40);
        Color sampledColor;
        using (Bitmap bitmap = new Bitmap(originalImagePath))
        {

            sampledColor = GetAverageColor(bitmap, new Rectangle(149, 60, 5, 44));
        }

        Brush colorBrush = new SolidBrush(sampledColor);
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Gray));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static void GenerateImagesForLimousineTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "LimousineTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Limousine Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(135, 85, 185, 80);
        Rectangle sourceArea = new Rectangle(132, 64, 34, 08);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 58, FontStyle.Regular);
        PointF position = new PointF(120, 80);
        Brush colorBrush = Brushes.Black;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.White));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static void GenerateImagesForCommercialTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "CommercialTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Commercial Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(140, 85, 185, 80);
        Rectangle sourceArea = new Rectangle(132, 64, 34, 08);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 62, FontStyle.Regular);
        PointF position = new PointF(122, 75);
        Brush colorBrush = Brushes.Black;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Gray));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static void GenerateImagesForPoliceTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "PoliceTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Police Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(21, 61, 244, 80);
        Rectangle sourceArea = new Rectangle(34, 23, 34, 23);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 60, FontStyle.Bold);
        PointF position = new PointF(21, 64);
        Brush colorBrush = Brushes.White;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Black));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.Black));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static void GenerateImagesForPoliceTemplate2(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "PoliceTemplate2.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Police Template 2");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(91, 18, 168, 60);
        Rectangle sourceArea = new Rectangle(256, 18, 40, 56);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 58, FontStyle.Regular);
        PointF position = new PointF(91, 10);
        Brush colorBrush = Brushes.White;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Black));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.Black));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static void GenerateImagesForTrailerTemplate(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Sample Template Images", "TrailerTemplate.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Trailer Template");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(130, 75, 190, 80);
        Rectangle sourceArea = new Rectangle(132, 64, 34, 08);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 62, FontStyle.Regular);
        PointF position = new PointF(115, 75);
        Brush colorBrush = Brushes.Black;
        Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Gray));
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.WhiteSmoke));

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }

    static Color GetAverageColor(Bitmap bitmap, Rectangle sampleArea)
    {
        int r = 0, g = 0, b = 0;
        int pixelCount = 0;


        for (int x = sampleArea.Left; x < sampleArea.Right; x++)
        {
            for (int y = sampleArea.Top; y < sampleArea.Bottom; y++)
            {
                Color pixelColor = bitmap.GetPixel(x, y);
                r += pixelColor.R;
                g += pixelColor.G;
                b += pixelColor.B;
                pixelCount++;
            }
        }


        r /= pixelCount;
        g /= pixelCount;
        b /= pixelCount;

        return Color.FromArgb(r, g, b);
    }

    public static Bitmap ApplyGaussianBlur(Bitmap image, Rectangle eraseArea, float radius)
    {
        var blurEffect = new AForge.Imaging.Filters.GaussianBlur(radius, 1);

        Bitmap blurredImage = blurEffect.Apply((Bitmap)image.Clone());

        using (Graphics g = Graphics.FromImage(image))
        {
            g.DrawImage(blurredImage, eraseArea, eraseArea, GraphicsUnit.Pixel);
        }

        return image;
    }

    static void GenerateImages(string originalImagePath, string outputDirectory, Rectangle eraseArea, Rectangle sourceArea, Rectangle eraseAreaSingleDigit, Rectangle sourceAreaSingleDigit, Font font, PointF position, PointF positionSingleDigit, Brush colorBrush, Brush darkShadowBrush, Brush lightShadowBrush, int imageCount, int digitCount, bool includeSingleDigitArea=false, bool applyBlur=false)
    {
        Random random = new Random();
        for (int numberPlate = 0; numberPlate < imageCount; numberPlate++)
        {
            using (Bitmap bitmap = new Bitmap(originalImagePath))
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                processImage(outputDirectory, numberPlate, graphics, bitmap, sourceArea, eraseArea, font, position, colorBrush, darkShadowBrush, lightShadowBrush, random, digitCount,applyBlur);

                if (includeSingleDigitArea)
                {
                    processImage(outputDirectory, numberPlate, graphics, bitmap, sourceAreaSingleDigit, eraseAreaSingleDigit, font, positionSingleDigit, colorBrush, darkShadowBrush, lightShadowBrush, random, 1,applyBlur);

                }

            }
        }
    }

    static void processImage(string outputDirectory, int numberPlate, Graphics graphics, Bitmap bitmap, Rectangle sourceArea, Rectangle eraseArea, Font font, PointF position, Brush colorBrush, Brush darkShadowBrush, Brush lightShadowBrush, Random random, int digitCount, bool applyBlur)
    {
        {
            Bitmap clonedSection = bitmap.Clone(sourceArea, bitmap.PixelFormat);
            graphics.DrawImage(clonedSection, eraseArea);

            string randomNumber = GenerateRandomNumber(random, digitCount);

            SizeF textSize = graphics.MeasureString(randomNumber, font);

            // Calculate the centered X position
            float centeredX = eraseArea.X + (eraseArea.Width - textSize.Width) / 2;

            // Shadow effects
            float darkShadowOffsetX = 3;
            float darkShadowOffsetY = -3;
            graphics.DrawString(randomNumber, font, darkShadowBrush, centeredX + darkShadowOffsetX, position.Y + darkShadowOffsetY);

            float lightShadowOffsetX = -0.75f;
            float lightShadowOffsetY = -0.75f;
            graphics.DrawString(randomNumber, font, lightShadowBrush, centeredX + lightShadowOffsetX, position.Y + lightShadowOffsetY);

            // Draw the main text at the centered position
            graphics.DrawString(randomNumber, font, colorBrush, centeredX, position.Y);

            if (applyBlur)
            {
                using (Bitmap blurredImage = ApplyGaussianBlur(bitmap, eraseArea, 1))
                {

                    string filePath1 = Path.Combine(outputDirectory, $"plate_{numberPlate + 1}.png");
                    blurredImage.Save(filePath1, ImageFormat.Png);
                    Console.WriteLine($"Generated image {numberPlate + 1} with number {randomNumber}");
                }
            }
            else
            {

                string filePath = Path.Combine(outputDirectory, $"plate_{numberPlate + 1}.png");
                bitmap.Save(filePath, ImageFormat.Png);
                Console.WriteLine($"Generated image {numberPlate + 1} with number {randomNumber}");
            }
        }

        static string GenerateRandomNumber(Random random, int digitCount)
        {
            int minValue = (int)Math.Pow(10, digitCount - 1);
            int maxValue = (int)Math.Pow(10, digitCount) - 1;
            return random.Next(minValue, maxValue + 1).ToString();
        }
    }
}
