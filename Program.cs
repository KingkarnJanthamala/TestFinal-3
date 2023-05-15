using System;

class Program {
    static void Main(string[] args) {
        string FileInput = Console.ReadLine(); //FileInput คือ ที่อยู่ของไฟล์ข้อมูลภาพนำเข้า
        string FileConvolutionKernel = Console.ReadLine(); //FileConvolutionKernel คือ ที่อยู่ของไฟล์ข้อมูล Convolution Kernel
        string FileResult = Console.ReadLine(); //FileResult คือ ที่อยู่ของไฟล์ข้อมูลภาพผลลัพธ์
        ReadImageDataFromFile(FileInput);
        ReadImageDataFromFile(FileConvolutionKernel);


    }
    static double[,] ReadImageDataFromFile(string imageDataFilePath) {
	string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
	int imageHeight = lines.Length;
	int imageWidth = lines[0].Split(',').Length;
	double[,] imageDataArray = new double[imageHeight, imageWidth];
 
	for(int i=0; i<imageHeight; i++)
	{
    	string[] items = lines[i].Split(',');
    	for(int j=0; j<imageWidth; j++)
    	{
        	imageDataArray[i, j] = double.Parse(items[j]);
    	}
	}
	return imageDataArray;
}
}