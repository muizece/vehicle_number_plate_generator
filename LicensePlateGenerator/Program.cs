﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Provide the template number :");

        int templateNumber = int.Parse(Console.ReadLine());
        int templateChoice = templateNumber;

        switch (templateChoice)
        {
            case 1:
                GenerateImagesTemplate1(1000);
                break;
            case 2:
                GenerateImagesTemplate2(1000);
                break;
            case 3:
                GenerateImagesTemplate3(1000, 5);
                break;
            case 4:
                GenerateImagesTemplate4(1000, 6);
                break;
            case 5:
                GenerateImagesTemplate5(1000, 5);
                break;
            case 6:
                GenerateImagesTemplate6(1000, 5);
                break;
            case 7:
                GenerateImagesTemplate7(1000, 5);
                break;
            case 8:
                GenerateImagesTemplate8(1000, 5);
                break;
            case 9:
                GenerateImagesTemplate9(1000, 3);
                break;
            case 10:
                GenerateImagesTemplate10(1000, 4);
                break;
            case 11:
                GenerateImagesTemplate11(1000, 5);
                break;
            case 12:
                GenerateImagesTemplate12(1000, 5);
                break;
            case 13:
                GenerateImagesTemplate13(1000, 5);
                break;
            case 14:
                GenerateImagesTemplate14(1000, 4);
                break;
            case 15:
                GenerateImagesTemplate15(1000, 5);
                break;
            default:
                Console.WriteLine("Invalid template choice.");
                break;
        }

        Console.WriteLine("All images have been generated.");
    }

    static void GenerateImagesTemplate1(int imageCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template1.png");


        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template1");
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


    static void GenerateImagesTemplate2(int imageCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template2.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template2");
        Directory.CreateDirectory(outputDirectory);

        Rectangle eraseArea = new Rectangle(60, 78, 238, 74);
        Rectangle sourceArea = new Rectangle(61, 72, 235, 5);
        Font font = new Font("Roadgeek 2005 Mittelschrift", 60, FontStyle.Regular);
        PointF position = new PointF(48, 66);
        Brush colorBrush = Brushes.White;
        Brush darkShadowBrush = new LinearGradientBrush(new Point(0, 0),new Point(100, 100),Color.FromArgb(120, Color.White),Color.Black);
        Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.Black));
        Random random = new Random();

        int digitCount = random.Next(4, 7);
        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, Rectangle.Empty, Rectangle.Empty, font, position, PointF.Empty, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, false, true);
    }
    static void GenerateImagesTemplate3(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template3.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template3");
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

    static void GenerateImagesTemplate4(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template4.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template4");
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

    static void GenerateImagesTemplate5(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template5.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template5");
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

    static void GenerateImagesTemplate6(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template6.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template6");
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


    static void GenerateImagesTemplate7(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template7.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template7");
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

    static void GenerateImagesTemplate8(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template8.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template8");
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


    static void GenerateImagesTemplate9(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template9.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template9");
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

        GenerateImages(originalImagePath, outputDirectory, eraseArea, sourceArea, eraseAreaSingleDigit, sourceAreaSingleDigit, font, position, positionSingleDigit, colorBrush, darkShadowBrush, lightShadowBrush, imageCount, digitCount, true);
    }

    static void GenerateImagesTemplate10(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template10.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template10");
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

    static void GenerateImagesTemplate11(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template11.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template11");
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

    static void GenerateImagesTemplate12(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template12.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template12");
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

    static void GenerateImagesTemplate13(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template13.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template13");
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

    static void GenerateImagesTemplate14(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template14.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template14");
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

    static void GenerateImagesTemplate15(int imageCount, int digitCount)
    {
        string originalImagePath = Path.Combine(AppContext.BaseDirectory, "Images", "template15.png");
        string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedImages", "Template15");
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
        var blurEffect = new AForge.Imaging.Filters.GaussianBlur(radius, 0);

        Bitmap blurredImage = blurEffect.Apply((Bitmap)image.Clone());

        using (Graphics g = Graphics.FromImage(image))
        {
            g.DrawImage(blurredImage, eraseArea, eraseArea, GraphicsUnit.Pixel);
        }

        return image;
    }

    static void GenerateImages(string originalImagePath, string outputDirectory, Rectangle eraseArea, Rectangle sourceArea, Rectangle eraseAreaSingleDigit, Rectangle sourceAreaSingleDigit, Font font, PointF position, PointF positionSingleDigit, Brush colorBrush, Brush darkShadowBrush, Brush lightShadowBrush, int imageCount, int digitCount, bool includeSingleDigitArea = false, bool applyBlur = false)
    {
        Random random = new Random();
        for (int numberPlate = 0; numberPlate < 3; numberPlate++)
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
            //Brush darkShadowBrush = new SolidBrush(Color.FromArgb(120, Color.Black));
            float darkShadowOffsetX = 3;
            float darkShadowOffsetY = -3;
            graphics.DrawString(randomNumber, font, darkShadowBrush, centeredX + darkShadowOffsetX, position.Y + darkShadowOffsetY);

            //Brush lightShadowBrush = new SolidBrush(Color.FromArgb(150, Color.White));
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
